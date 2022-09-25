using FileIT.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIT
{
    public partial class LogControl : UserControl
    {
        private List<string> _logs = new();
        private DataTable _dt = new();

        public LogControl()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void GetLogFiles()
        {
            string logDirectory = RecordHelper.LogDirectory();
            _logs = Directory.GetFiles(logDirectory).ToList();
        }

        private void InitializeDataTable()
        {
            _dt.Columns.Add("Action");
            _dt.Columns.Add("Result");
            _dt.Columns.Add("TimeStamp");
            _dt.Columns.Add("Source");
            _dt.Columns.Add("Destination");
            _dt.Columns.Add("Message");
        }

        private void dateTimePicker_CloseUp(object sender, EventArgs e)
        {
            GetLogFiles();

            string logName = $"{dateTimePicker.Value.ToString("yyyy-MM-dd")}.log";
            string log = _logs.Where(log => Path.GetFileName(log) == logName).FirstOrDefault();

            if(File.Exists(log))
            {
                // display log details
                // read the log
                var logContents = File.ReadAllLines(log);
                logContents = logContents.Skip(1).ToArray();
                DataRow row;
                foreach (var line in logContents)
                {
                    var content = line.Split('^');
                    row = _dt.NewRow();
                    row[0] = content[0];
                    row[1] = content[1];
                    row[2] = content[2];
                    row[3] = content[3];
                    row[4] = content[4];
                    row[5] = content[5];
                    _dt.Rows.Add(row);
                }

                dataGridView.DataSource = _dt;
            }
            else
            {
                MessageBox.Show("Log Not Found!!", "Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
