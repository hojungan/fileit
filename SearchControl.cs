using FileIT.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIT
{
    public partial class SearchControl : UserControl
    {
        private List<string> _sourceFiles = new();
        private string _fileType = "";

        public SearchControl()
        {
            InitializeComponent();
            comboBoxFileType.SelectedIndex = 0;
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            labelSource.Text = FileItHelpers.OpenFolderDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelSource.Text))
            {
                MessageBox.Show("Missing directory path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewFileList.Rows.Clear();
            searchBgw.RunWorkerAsync();
        }

        private void comboBoxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch (comboBoxFileType.Text)
            {
                case "All":
                    _fileType = ".*";
                    break;
                case "Word":
                    _fileType = "doc.";
                    break;
                case "PDF":
                    _fileType = "pdf";
                    break;
                case "Image":
                    _fileType = "jpe?g|png|gif|bmp|svg";
                    break;
                case "Text":
                    _fileType = "txt";
                    break;
                default:
                    _fileType = ".*";
                    break;
            }
        }

        private void searchBgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = string.IsNullOrEmpty(textBoxFileName.Text) ? "" : textBoxFileName.Text;
            _sourceFiles = FileItHelpers.SearchFiles(labelSource.Text, fileName, _fileType);
            foreach (var file in _sourceFiles)
            {
                dataGridViewFileList.Invoke(() =>
                {                    
                    dataGridViewFileList.Rows.Add(file);
                });
            }
        }

        private void dataGridViewFileList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                string filePath = dataGridViewFileList.Rows[e.RowIndex].Cells[0].Value.ToString();
                string directory = Path.GetDirectoryName(filePath);

                if (Directory.Exists(directory))
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        Arguments = directory,
                        FileName = "explorer.exe"
                    };

                    Process.Start(psi);
                }
                else
                {
                    MessageBox.Show($"{directory} was not found");
                }
            }
        }
    }
}
