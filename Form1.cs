using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spicetify_app
{
    public partial class Spicetify : Form
    {
        public Spicetify()
        {
            InitializeComponent();
        }

        private async void InstallBTN_Click(object sender, EventArgs e)
        {
            InstallBTN.Enabled = false;
            InstallBTN.Text = "INSTALLING";

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

            InstallBTN.Enabled = true;
            InstallBTN.Text = "INSTALL";
            MessageBox.Show("Successfully installed.");
        }

        private async void UninstallBTN_Click(object sender, EventArgs e)
        {
            UninstallBTN.Enabled = false;
            UninstallBTN.Text = "UNINSTALLING";

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

            UninstallBTN.Enabled = true;
            UninstallBTN.Text = "UNINSTALL";
            MessageBox.Show("Successfully uninstalled.");
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
        }
    }
}