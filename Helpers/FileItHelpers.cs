using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileIT.Helpers
{
    public static class FileItHelpers
    {
        public static List<FileInfo> _sourceFiles = new List<FileInfo>();

        /// <summary>
        /// Open folder dialog
        /// </summary>
        /// <returns>
        /// Folder path or null
        /// </returns>
        public static string? OpenFolderDialog()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }

            return null;
        }

        /// <summary>
        /// Open file dialog
        /// </summary>
        /// <returns></returns>
        public static string? OpenCSVFile()
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Filter = "CSV (*.csv) | *.csv";
            DialogResult result = fbd.ShowDialog();

            if(result == DialogResult.OK)
            {
                return fbd.FileName;
            }

            return null;
        }

        /// <summary>
        /// Filters files by its last modified date that is in bewteen "from" and "to" (including "from" and "to"), then returns number of files found.
        /// </summary>
        /// <param name="from">Date of file's last modified date</param>
        /// <param name="to">Date of file's last modified date</param>
        /// <returns>
        /// Number of files that falls in between the "from" and "to".
        /// </returns>
        public static int FilterFilesByDate(DateTime? from, DateTime? to)
        {
            if (from != null) _sourceFiles = _sourceFiles.Where(f => f.LastWriteTime >= from).ToList();
            if (to != null) _sourceFiles = _sourceFiles.Where(f => f.LastWriteTime <= to).ToList();

            return _sourceFiles.Count;
        }

        /// <summary>
        /// Finds all files from the path. If set to recursive, finds all files from all sub-folders.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="recursive"></param>
        /// <param name="files"></param>
        /// <returns>
        /// List of FileInfo objects
        /// </returns>
        public static List<FileInfo> GetFiles(string path, bool recursive, List<FileInfo> files)
        {
            files.Clear();
            Queue<DirectoryInfo> dirs = new Queue<DirectoryInfo>();
            if(!string.IsNullOrEmpty(path))
            {
                dirs.Enqueue(new DirectoryInfo(path));

                while (dirs.Count > 0)
                {
                    DirectoryInfo currDir = dirs.Dequeue();

                    foreach(FileInfo file in currDir.GetFiles())
                    {
                        files.Add(file);
                    }

                    if(recursive)
                    {
                        foreach(DirectoryInfo subDir in currDir.GetDirectories())
                        {
                            dirs.Enqueue(subDir);
                        }
                    }
                }
            }

            return files;
        }

        public static List<string> SearchFiles(string path, string fileName, string fileType)
        {
            List<string> files = new();
            Regex pattern = new Regex($"({fileName}.+)(\\.({fileType}))", RegexOptions.IgnoreCase);

            Queue<DirectoryInfo> dirs = new Queue<DirectoryInfo>();
            if (!string.IsNullOrEmpty(path))
            {
                dirs.Enqueue(new DirectoryInfo(path));

                while (dirs.Count > 0)
                {
                    DirectoryInfo currDir = dirs.Dequeue();

                    foreach (FileInfo file in currDir.GetFiles())
                    {

                        if (pattern.IsMatch(file.Name.ToLower()))
                        {
                            files.Add(file.FullName);
                        }
                    }

                    foreach (DirectoryInfo subDir in currDir.GetDirectories())
                    {
                        dirs.Enqueue(subDir);
                    }
                }
            }

            return files;
        }

        /// <summary>
        /// Copy files from source to destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="recursive"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="bgw"></param>
        /// <returns>
        /// True if there were any errors during the operation
        /// </returns>
        public static bool CopyFiles(string source, string destination, bool recursive, DateTime? from, DateTime? to, BackgroundWorker bgw)
        {
            int progress = 0;
            bool errors = false;

            GetFiles(source, recursive, _sourceFiles);
            FilterFilesByDate(from, to);
            
            foreach(var file in _sourceFiles)
            {
                string loc = Path.GetDirectoryName(file.FullName.Replace(source, destination));
                try
                {
                    Directory.CreateDirectory(loc);
                    File.Copy(file.FullName, Path.Combine(loc, file.Name), true);
                    RecordHelper.LogResult(ActionTypes.COPY, ActionTypes.SUCCESS, file.FullName, loc, "NULL");
                    progress++;
                    bgw.ReportProgress(progress);
                }catch(Exception err)
                {
                    errors = true;

                    // Record failures
                    RecordHelper.LogResult(ActionTypes.COPY, ActionTypes.ERROR, file.FullName, loc, err.Message);
                }
            }

            return errors;
        }


        /// <summary>
        /// Move files from source to desntination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="recursive"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="bgw"></param>
        /// <returns>
        /// True if there were any errors during the operation
        /// </returns>
        public static bool MoveFiles(string source, string destination, bool recursive, DateTime? from, DateTime? to, BackgroundWorker bgw)
        {
            int progress = 0;
            GetFiles(source, recursive, _sourceFiles);
            FilterFilesByDate(from, to);
            string root = Path.GetFileName(source);
            string _dest = Path.Combine(destination, root);
            bool errors = false;

            foreach (var file in _sourceFiles)
            {
                string loc = Path.GetDirectoryName(file.FullName.Replace(source, _dest));
                try
                {
                    Directory.CreateDirectory(loc);
                    File.Move(file.FullName, Path.Combine(loc, file.Name), true);
                    RecordHelper.LogResult(ActionTypes.MOVE, ActionTypes.SUCCESS, file.FullName, loc, "NULL");
                    progress++;
                    bgw.ReportProgress(progress);
                }
                catch (Exception err)
                {
                    errors = true;

                    // Record failures
                    RecordHelper.LogResult(ActionTypes.MOVE, ActionTypes.ERROR, file.FullName, loc, err.Message);
                }

                var sourceDir = new DirectoryInfo(Path.GetDirectoryName(file.FullName));
                if (sourceDir.Exists && IsEmpty(sourceDir))
                {
                    Directory.Delete(sourceDir.FullName);
                }
            }

            return errors;
        }

        public static void DeleteEmptyDirectories(string root)
        {
            HashSet<string> skipped = new HashSet<string>();
            Stack<string> dirStack = new Stack<string>();
            dirStack.Push(root);

            while(dirStack.Count > 0)
            {
                var currDir = dirStack.Peek();
                string[] subDirs = Directory.GetDirectories(currDir);
                string[] files = Directory.GetFiles(currDir);

                if(subDirs.Length == 1 && skipped.Contains(subDirs[0]))
                {
                    skipped.Add(currDir);
                    dirStack.Pop();
                    continue;
                }

                if (skipped.Contains(currDir))
                {
                    dirStack.Pop();
                    continue;
                }

                if(subDirs.Length > 0)
                {
                    foreach(string subDir in subDirs)
                    {
                        string[] subDirFiles = Directory.GetFiles(subDir);
                        if (subDirFiles.Length > 0)
                        {
                            skipped.Add(subDir);
                            skipped.Add(currDir);
                        }
                        else if(!skipped.Contains(subDir))
                        {
                            dirStack.Push(subDir);
                        }
                        else
                        {
                            skipped.Add(currDir);
                        }
                    }
                    continue;
                }
                
                if(files.Length > 0)
                {
                    skipped.Add(currDir);
                    dirStack.Pop();
                    continue;
                }

                Directory.Delete(currDir);
                dirStack.Pop();
            }
        }
                
        private static bool IsEmpty(DirectoryInfo dir)
        {
            return dir.GetDirectories().Length == 0 && dir.GetFiles().Length == 0;
        }

        public static bool DeleteFiles(string source, bool recursive, BackgroundWorker bgw)
        {
            int progress = 0;
            bool errors = false;

            GetFiles(source, recursive, _sourceFiles);
            
            foreach(var file in _sourceFiles)
            {
                try
                {
                    File.Delete(file.FullName);
                    RecordHelper.LogResult(ActionTypes.DELETE, ActionTypes.SUCCESS, file.FullName, "NULL", "NULL");
                    progress++;
                    bgw.ReportProgress(progress);
                }
                catch (Exception ex)
                {
                    errors = true;
                    RecordHelper.LogResult(ActionTypes.DELETE, ActionTypes.ERROR, file.FullName, "NULL", ex.Message);
                }
            }

            return errors;
        }

        /// <summary>
        /// Check if path is URL or file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsURL(string path)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(path, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }
    }
}
