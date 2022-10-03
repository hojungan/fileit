using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileIT.Helpers;

namespace FileIT
{
    public partial class CompareControl : UserControl
    {
        private HashSet<string> _fromCSV = new();
        private List<FileInfo> _fromDir = new();
        private bool pathError;

        public CompareControl()
        {
            InitializeComponent();
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            labelCSV.ForeColor = Color.Black;
            labelCSV.Text = FileItHelpers.OpenCSVFile();
            pathError = false;

            if(Path.GetExtension(labelCSV.Text).ToLower() != ".csv")
            {
                MessageBox.Show("This file is not CSV File", "File Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelCSV.ForeColor = Color.Red;
                pathError = true;
            }
        }

        private void buttonCompareDir_Click(object sender, EventArgs e)
        {
            labelCompareDir.Text = FileItHelpers.OpenFolderDialog();
            pathError = false;

            if (string.IsNullOrEmpty(labelCompareDir.Text)) pathError = true;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (pathError)
            {
                MessageBox.Show("Missing CSV or Server Root", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _fromCSV.Clear();
            _fromDir.Clear();
            dataGridViewResult.Rows.Clear();

            bgwCompare.RunWorkerAsync();
        }

        private void bgwCompare_DoWork(object sender, DoWorkEventArgs e)
        {
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = "Reading CSV...";
            });

            // Read from CSV file and save it to _fromCSV List
            using(var reader = new StreamReader(labelCSV.Text))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string pathFromCSV = line;

                    if (FileItHelpers.IsURL(line))
                    {
                        pathFromCSV = new Uri(line).LocalPath;
                    }

                    string filename = Path.GetFileName(pathFromCSV);
                    string fileExt = Path.GetExtension(pathFromCSV);

                    if (!string.IsNullOrEmpty(fileExt))
                    {
                        _fromCSV.Add(filename);
                    }
                }
            }

            // Get files from Server
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = "Getting files...";
            });
            FileItHelpers.GetFiles(labelCompareDir.Text, checkBoxRecursive.Checked, _fromDir);

            // Compare based on checkbox condition
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = "Comparing files...";
            });


            if (radioButtonDiff.Checked)
            {
                foreach (var file in _fromDir)
                {
                    if (!_fromCSV.Contains(file.Name))
                    {
                        dataGridViewResult.Invoke(() =>
                        {
                            dataGridViewResult.Rows.Add(file.FullName);
                        });
                    }
                }
            }
            else if (radioButtonCommon.Checked)
            {
                foreach (var file in _fromDir)
                {
                    if (_fromCSV.Contains(file.Name))
                    {
                        dataGridViewResult.Invoke(() =>
                        {
                            dataGridViewResult.Rows.Add(file.FullName);
                        });
                    }
                }
            }
        }

        private void bgwCompare_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int resultCount = dataGridViewResult.Rows.Count;
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = $"Completed!! {resultCount} File(s) Found";
            });
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string csvName = "CSVFileComparisonResult.csv";

            bgwExport.RunWorkerAsync(Path.Combine(desktop, csvName));
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {

            string filename = e.Argument.ToString();

            // Prepare CSV file
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = "Preparing CSV";
            });

            // Create CSV file
            string[] output = new string[dataGridViewResult.Rows.Count + 1];
            for (int i = 0; i < dataGridViewResult.Rows.Count; i++)
            {
                output[i] = dataGridViewResult.Rows[i].Cells[0].Value.ToString();
            }
            System.IO.File.WriteAllLines(filename, output, Encoding.UTF8);
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelStatus.Invoke(() =>
            {
                labelStatus.Text = "CSV File Ready!!";
            });
        }
    }
}
