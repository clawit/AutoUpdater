using System.ComponentModel;
using System.Text.Json.Nodes;

namespace AutoUpdater
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void lnkDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkDetail.Text == "Detail...")
            {
                lnkDetail.Text = "Hide";
                this.Height = 300;
            }
            else
            {
                lnkDetail.Text = "Detail...";
                this.Height = 113;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var jsonString = File.ReadAllText("config.json");
            var json = JsonNode.Parse(jsonString);
            var updateUrl = json?["updateUrl"]?.ToString();
            if (string.IsNullOrWhiteSpace(updateUrl))
            {
                MessageBox.Show("Config error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync(updateUrl);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgsBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgsBar.Value = 100;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker.ReportProgress(1);

                var http = new HttpClient();
                var response = http.GetStringAsync(e.Argument.ToString()).Result;
                var json = JsonNode.Parse(response);

                backgroundWorker.ReportProgress(99);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update error:{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

    }
}