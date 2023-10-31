namespace Spicetify_app
{
    partial class InstallationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallationForm));
            this.statusLabel = new System.Windows.Forms.Label();
            this.okButton = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.progressBar1 = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.LightGray;
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(127, 33);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Installing";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderRadius = 5;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.Enabled = false;
            this.okButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(40)))));
            this.okButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.okButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.okButton.HoveredState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(12, 82);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(240, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.okButton.UseTransparentBackground = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 10;
            this.siticoneElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.statusLabel;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderRadius = 1;
            this.progressBar1.FillColor = System.Drawing.Color.LightGray;
            this.progressBar1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar1.Location = new System.Drawing.Point(12, 49);
            this.progressBar1.Maximum = 8;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(40)))));
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.progressBar1.ShadowDecoration.Parent = this.progressBar1;
            this.progressBar1.ShowPercentage = true;
            this.progressBar1.Size = new System.Drawing.Size(240, 26);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar1.UseTransparentBackground = true;
            // 
            // InstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(264, 125);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installing Spicetify";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InstallationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private Siticone.UI.WinForms.SiticoneGradientButton okButton;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneProgressBar progressBar1;
    }
}