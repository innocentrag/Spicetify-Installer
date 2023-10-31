using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicetify_app
{
    public partial class InstallationForm : Form
    {
        public event EventHandler InstallationComplete;
        public Timer LoadingTimer => loadingTimer;

        private Timer loadingTimer;
        private int dotCount = 0;

        private int totalSteps = 8;

        public InstallationForm()
        {
            InitializeComponent();
            loadingTimer = new Timer();
            loadingTimer.Interval = 500;
            loadingTimer.Tick += timer1_Tick;
        }

        private void UpdateProgressBar(string output)
        {
            if (output.Contains("spicetify-cli was installed successfully") || output.Contains("Setting up") || output.Contains("Removing and creating Marketplace folders") || output.Contains("Downloading Marketplace") || output.Contains("Unzipping and installing") || output.Contains("Downloading placeholder theme") || output.Contains("Applying") || output.Contains("Done"))
            {
                progressBar1.Value++;
                if (progressBar1.Value >= totalSteps)
                {
                    SetInstallationStatus("Success");
                    EnableOkButton();
                }
            }
        }

        public void UpdateInstallationProgress(string output)
        {
            UpdateProgressBar(output);
        }

        public void StopTimer()
        {
            loadingTimer.Stop();
        }

        public void SetInstallationStatus(string status)
        {
            statusLabel.Text = status;
            if (status == "Success")
            {
                loadingTimer.Enabled = false;
            }
        }

        public void ShowOkButton()
        {
            okButton.Enabled = false;
        }

        public void EnableOkButton()
        {
            okButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % 5;
            string dots = new string('.', dotCount);
            statusLabel.Text = "Installing" + dots;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            InstallationComplete?.Invoke(this, EventArgs.Empty);
            Application.Restart();
        }

        private void InstallationForm_Load(object sender, EventArgs e)
        {
            loadingTimer.Enabled = true;
            okButton.Enabled = false;
        }
    }
}
