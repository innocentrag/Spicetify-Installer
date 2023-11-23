using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicetify_Installer
{
    public partial class UninstallationForm : Form
    {
        public event EventHandler UninstallationComplete;
        public Timer LoadingTimer => loadingTimer;

        private Timer loadingTimer;
        private int dotCount = 0;
        public UninstallationForm()
        {
            InitializeComponent();
            loadingTimer = new Timer();
            loadingTimer.Interval = 500;
            loadingTimer.Tick += timer1_Tick;
        }

        public void StopTimer()
        {
            loadingTimer.Stop();
        }

        public void SetInstallationStatus(string status)
        {
            if (status == "Success")
            {
                loadingTimer.Enabled = false;
            }
            statusLabel.Text = status;
        }

        public void ShowOkButton()
        {
            okButton.Enabled = false;
        }

        public void EnableOkButton()
        {
            okButton.Enabled = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UninstallationComplete?.Invoke(this, EventArgs.Empty);
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % 5;
            string dots = new string('.', dotCount);
            statusLabel.Text = "Uninstalling" + dots;
        }

        private void UninstallationForm_Load(object sender, EventArgs e)
        {
            loadingTimer.Enabled = true;
            okButton.Enabled = false;
        }
    }
}
