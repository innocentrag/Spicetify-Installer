﻿using System;
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

        public InstallationForm()
        {
            InitializeComponent();
            loadingTimer = new Timer();
            loadingTimer.Interval = 500; // Change the interval as needed
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
                loadingTimer.Enabled = false; // Disable the timer when status is "Success"
            }
            statusLabel.Text = status;
        }

        public void ShowOkButton()
        {
            // Show the OK button
            okButton.Enabled = false;
        }

        public void EnableOkButton()
        {
            // Enable the OK button
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