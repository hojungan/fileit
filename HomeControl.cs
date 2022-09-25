using System;
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
    public partial class HomeControl : UserControl
    {
        private int _totalFileCount = 0;
        public HomeControl()
        {
            InitializeComponent();
            comboBoxActionType.SelectedIndex = 0;
        }

        private void ToggleButton(Button btn, bool enabled)
        {
            btn.Enabled = enabled;
        }
        private void ToggleButton(ComboBox cb, bool enabled)
        {
            cb.Enabled = enabled;
        }
        private void ToggleButton(CheckBox cb, bool enabled)
        {
            cb.Enabled = enabled;
        }

        private void WriteToRTB(RichTextBox rtb, string message)
        {
            rtb.Invoke(() =>
            {
                rtb.AppendText($"{message}{Environment.NewLine}");
            });
        }

        private void checkBoxFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrom.Checked)
            {
                dateTimePickerFrom.Enabled = true;
                return;
            }
            dateTimePickerFrom.Enabled = false;
            FileItHelpers.GetFiles(labelSource.Text, checkBoxRecursive.Checked, FileItHelpers._sourceFiles);
            _totalFileCount = FileItHelpers.FilterFilesByDate(null, dateTimePickerTo.Value);
            labelProgressOf.Text = $"0/{_totalFileCount}";
        }

        private void checkBoxTo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTo.Checked)
            {
                dateTimePickerTo.Enabled = true;
                return;
            }
            dateTimePickerTo.Enabled = false;
            FileItHelpers.GetFiles(labelSource.Text, checkBoxRecursive.Checked, FileItHelpers._sourceFiles);
            _totalFileCount = FileItHelpers.FilterFilesByDate(dateTimePickerFrom.Value, null);
            labelProgressOf.Text = $"0/{_totalFileCount}";
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            ToggleButton(buttonExecute, false);
            labelSource.Text = FileItHelpers.OpenFolderDialog();
            _totalFileCount = FileItHelpers.GetFiles(labelSource.Text, checkBoxRecursive.Checked, FileItHelpers._sourceFiles).Count;
            labelProgressOf.Text = $"0/{_totalFileCount}";
            ToggleButton(buttonExecute, true);
        }
        
        private void buttonDestination_Click(object sender, EventArgs e)
        {
            labelDestination.Text = FileItHelpers.OpenFolderDialog();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(labelSource.Text))
            {
                MessageBox.Show("Source path is missing", "Missing Source Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(buttonDestination.Enabled && string.IsNullOrEmpty(labelDestination.Text))
            {
                MessageBox.Show("Destination path is missing", "Missing Destination Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Disable controls to prevent interruptions
            ToggleButton(comboBoxActionType, false);
            ToggleButton(checkBoxFrom, false);
            ToggleButton(checkBoxTo, false);
            ToggleButton(checkBoxRecursive, false);

            WriteToRTB(richTextBox, "Initializing");
            string source = labelSource.Text;
            string destination = labelDestination.Text;
            DateTime? from = checkBoxFrom.Checked ? dateTimePickerFrom.Value : null;
            DateTime? to = checkBoxTo.Checked ? dateTimePickerTo.Value : null;
            bool recursive = checkBoxRecursive.Checked;

            progressBar.Maximum = _totalFileCount;
            progressBar.Minimum = 0;

            Dictionary<string, object> options = new Dictionary<string, object>();
            if (from != null) options.Add("from", from);
            if (to != null) options.Add("to", to);
            options.Add("source", source);
            options.Add("destination", destination);
            options.Add("recursive", recursive);
            options.Add("actionType", comboBoxActionType.Text);

            backgroundWorker.RunWorkerAsync(options);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // stops background worker if there was any error
            if (backgroundWorker.CancellationPending)
            {
                WriteToRTB(richTextBox, "Aborted");
                e.Cancel = true;
                return;
            }

            var options = e.Argument as Dictionary<string, object>;
            string source = (string)options["source"];
            string destination = (string)options["destination"];
            bool recursive = (bool)options["recursive"];
            DateTime? from = options.ContainsKey("from") ? (DateTime)options["from"] : null;
            DateTime? to = options.ContainsKey("to") ? (DateTime)options["to"] : null;
            string actionType = (string)options["actionType"];

            bool errors = false;

            switch (actionType)
            {
                case "Copy":
                    WriteToRTB(richTextBox, "Copying files...");
                    errors = FileItHelpers.CopyFiles(source, destination, recursive, from, to, backgroundWorker);
                    break;
                case "Move":
                    WriteToRTB(richTextBox, "Moving files...");
                    errors = FileItHelpers.MoveFiles(source, destination, recursive, from, to, backgroundWorker);
                    WriteToRTB(richTextBox, "Finalizing...");
                    FileItHelpers.DeleteEmptyDirectories(source);
                    break;
                case "Delete":
                    WriteToRTB(richTextBox, "Deleting files...");
                    errors = FileItHelpers.DeleteFiles(source, recursive, backgroundWorker);
                    break;
            }

            if (errors)
            {
                WriteToRTB(richTextBox, "There were some errors during the operation. View the log file for more details");
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                WriteToRTB(richTextBox, "Task Aborted!!");
            }
            else
            {
                WriteToRTB(richTextBox, "Task Completed!!");
            }

            // Enable buttons for next
            ToggleButton(comboBoxActionType, true);
            ToggleButton(checkBoxFrom, true);
            ToggleButton(checkBoxTo, true);
            ToggleButton(checkBoxRecursive, true);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressOf.Text = $"{e.ProgressPercentage}/{_totalFileCount}";
            progressBar.Value = e.ProgressPercentage;
        }

        private async void checkBoxRecursive_CheckedChanged(object sender, EventArgs e)
        {
            WriteToRTB(richTextBox, "Fetching files from sub-folders. This may take few minutes.");
            ToggleButton(buttonExecute, false);

            await Task.Run(() =>
            {
                _totalFileCount = FileItHelpers.GetFiles(labelSource.Text, checkBoxRecursive.Checked, FileItHelpers._sourceFiles).Count;
            });
            labelProgressOf.Text = $"0/{_totalFileCount}";
            WriteToRTB(richTextBox, "All files are fetched");
            ToggleButton(buttonExecute, true);
        }

        private void dateTimePickerTo_CloseUp(object sender, EventArgs e)
        {
            DateTime? to = dateTimePickerTo.Value;
            _totalFileCount = FileItHelpers.FilterFilesByDate(dateTimePickerFrom.Value, to);
            labelProgressOf.Text = $"0/{_totalFileCount}";
        }

        private void dateTimePickerFrom_CloseUp(object sender, EventArgs e)
        {
            FileItHelpers.GetFiles(labelSource.Text, checkBoxRecursive.Checked, FileItHelpers._sourceFiles);
            DateTime? from = dateTimePickerFrom.Value;
            _totalFileCount = FileItHelpers.FilterFilesByDate(from, dateTimePickerTo.Value);
            labelProgressOf.Text = $"0/{_totalFileCount}";
        }

        private void comboBoxActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxActionType.Text == "Delete")
            {
                buttonDestination.Enabled = false;
                checkBoxFrom.Enabled = false;
                checkBoxTo.Enabled = false;
                return;
            }
            buttonDestination.Enabled = true;
            checkBoxFrom.Enabled = true;
            checkBoxTo.Enabled = true;
        }
    }
}
