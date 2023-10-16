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

            // Check if Spicetify installation directories exist in AppData and LocalAppData
            bool isInstalled = Directory.Exists(Path.Combine(appDataPath, "spicetify")) &&
                              Directory.Exists(Path.Combine(localAppDataPath, "spicetify"));

            // Enable or disable buttons and update their text based on installation status
            InstallBTN.Enabled = true;
            UninstallBTN.Enabled = isInstalled;
            InstallBTN.Text = isInstalled ? "Repair" : "Install";
            UninstallBTN.Text = isInstalled ? "Uninstall" : "Uninstalled";
        }

        private async void InstallBTN_Click(object sender, EventArgs e)
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

            // Ensure "Success" is set after the installation process is complete
            installationForm.LoadingTimer.Enabled = false;
            installationForm.SetInstallationStatus("Success");
            installationForm.EnableOkButton();

            // Stop the timer
            installationForm.StopTimer();

            // Re-enable the Install button and handle the InstallationComplete event
            installationForm.InstallationComplete += (s, args) => {
                installationForm.Close();
                CheckSpicetifyInstallation();
                this.Show();
                InstallBTN.Enabled = true;
            };
        }

        private async void UninstallBTN_Click(object sender, EventArgs e)
        {
            UninstallBTN.Enabled = false;
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

                process.StandardInput.WriteLine("spicetify restore");
                process.StandardInput.WriteLine("Remove-Item -Path $env:APPDATA\\spicetify -Recurse -Force");
                process.StandardInput.WriteLine("Remove-Item -Path $env:LOCALAPPDATA\\spicetify -Recurse -Force");

                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            });

            // Ensure "Success" is set after the uninstallation process is complete
            installationForm.LoadingTimer.Enabled = false;
            installationForm.SetInstallationStatus("Success");
            installationForm.EnableOkButton();

            // Stop the timer
            installationForm.StopTimer();

            // Re-enable the Uninstall button and handle the InstallationComplete event
            installationForm.InstallationComplete += (s, args) => {
                installationForm.Close();
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