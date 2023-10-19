using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Linq;
using System.Net.Http;
using System.IO.Compression;
using Spicetify_Installer;

namespace Spicetify_app
{
    public partial class Spicetify : Form
    {
        public Spicetify()
        {
            InitializeComponent();
            CheckSpicetifyInstallation();
        }

        private void CheckSpicetifyInstallation()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            bool isInstalled = Directory.Exists(Path.Combine(appDataPath, "spicetify")) &&
                              Directory.Exists(Path.Combine(localAppDataPath, "spicetify"));

            InstallBTN.Enabled = true;
            UninstallBTN.Enabled = isInstalled;
            InstallBTN.Text = isInstalled ? "Repair" : "Install";
            UninstallBTN.Text = isInstalled ? "Uninstall" : "Uninstalled";
        }

        public async void InstallBTN_Click(object sender, EventArgs e)
        {
            InstallBTN.Enabled = false;
            InstallationForm installationForm = new InstallationForm();
            installationForm.Show();
            this.Hide();

            await Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();

                process.StandardInput.WriteLine("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex");
                process.StandardInput.WriteLine("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex");

                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            });

            installationForm.LoadingTimer.Enabled = false;
            installationForm.SetInstallationStatus("Success");
            installationForm.EnableOkButton();

            installationForm.StopTimer();

            installationForm.InstallationComplete += (s, args) => {
                installationForm.Close();
                CheckSpicetifyInstallation();
                this.Show();
                InstallBTN.Enabled = true;
            };
        }

        public async void UninstallBTN_Click(object sender, EventArgs e)
        {
            UninstallBTN.Enabled = false;
            UninstallationForm uninstallationForm = new UninstallationForm();
            uninstallationForm.Show();
            this.Hide();

            await Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = psi
                };

                process.Start();

                process.StandardInput.WriteLine("spicetify restore");
                process.StandardInput.WriteLine("Remove-Item -Path $env:APPDATA\\spicetify -Recurse -Force");
                process.StandardInput.WriteLine("Remove-Item -Path $env:LOCALAPPDATA\\spicetify -Recurse -Force");

                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            });

            uninstallationForm.LoadingTimer.Enabled = false;
            uninstallationForm.SetInstallationStatus("Success");
            uninstallationForm.EnableOkButton();

            uninstallationForm.StopTimer();

            uninstallationForm.UninstallationComplete += (s, args) => {
                uninstallationForm.Close();
                CheckSpicetifyInstallation();
                this.Show();
                UninstallBTN.Enabled = true;
            };
        }

        private void siticoneGradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://spicetify.app/docs/getting-started");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/spicetify");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/VnevqPp2Rr");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/spicetify");
        }

        private void Spicetify_Load(object sender, EventArgs e)
        {
            CheckSpicetifyInstallation();
        }
    }
}