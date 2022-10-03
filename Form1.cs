namespace FileIT
{
    public partial class FileIT : Form
    {
        public FileIT()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeControl.Show();
            searchControl.Hide();
            logControl.Hide();
            compareControl.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchControl.Show();
            homeControl.Hide();
            logControl.Hide();
            compareControl.Hide();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logControl.Show();
            homeControl.Hide();
            searchControl.Hide();
            compareControl.Hide();
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compareControl.Show();
            homeControl.Hide();
            searchControl.Hide();
            logControl.Hide();
        }

    }
}