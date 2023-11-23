namespace Spicetify_app
{
    partial class Spicetify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spicetify));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstallBTN = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.UninstallBTN = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.siticoneGradientCircleButton1 = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InstallBTN
            // 
            this.InstallBTN.BackColor = System.Drawing.Color.Transparent;
            this.InstallBTN.BorderRadius = 5;
            this.InstallBTN.CheckedState.Parent = this.InstallBTN;
            this.InstallBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallBTN.CustomImages.Parent = this.InstallBTN;
            this.InstallBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(40)))));
            this.InstallBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.InstallBTN.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.InstallBTN.HoveredState.Parent = this.InstallBTN;
            this.InstallBTN.Location = new System.Drawing.Point(20, 129);
            this.InstallBTN.Name = "InstallBTN";
            this.InstallBTN.ShadowDecoration.Parent = this.InstallBTN;
            this.InstallBTN.Size = new System.Drawing.Size(195, 40);
            this.InstallBTN.TabIndex = 1;
            this.InstallBTN.Text = "INSTALL";
            this.InstallBTN.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.InstallBTN.UseTransparentBackground = true;
            this.InstallBTN.Click += new System.EventHandler(this.InstallBTN_Click);
            // 
            // UninstallBTN
            // 
            this.UninstallBTN.BackColor = System.Drawing.Color.Transparent;
            this.UninstallBTN.BorderRadius = 5;
            this.UninstallBTN.CheckedState.Parent = this.UninstallBTN;
            this.UninstallBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UninstallBTN.CustomImages.Parent = this.UninstallBTN;
            this.UninstallBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(40)))));
            this.UninstallBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.UninstallBTN.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UninstallBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.UninstallBTN.HoveredState.Parent = this.UninstallBTN;
            this.UninstallBTN.Location = new System.Drawing.Point(20, 180);
            this.UninstallBTN.Name = "UninstallBTN";
            this.UninstallBTN.ShadowDecoration.Parent = this.UninstallBTN;
            this.UninstallBTN.Size = new System.Drawing.Size(195, 40);
            this.UninstallBTN.TabIndex = 2;
            this.UninstallBTN.Text = "UNINSTALL";
            this.UninstallBTN.TextTransform = Siticone.UI.WinForms.Enums.TextTransform.UpperCase;
            this.UninstallBTN.UseTransparentBackground = true;
            this.UninstallBTN.Click += new System.EventHandler(this.UninstallBTN_Click);
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 10;
            this.siticoneElipse1.TargetControl = this;
            // 
            // siticoneGradientCircleButton1
            // 
            this.siticoneGradientCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientCircleButton1.CheckedState.Parent = this.siticoneGradientCircleButton1;
            this.siticoneGradientCircleButton1.CustomImages.Parent = this.siticoneGradientCircleButton1;
            this.siticoneGradientCircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientCircleButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientCircleButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(40)))));
            this.siticoneGradientCircleButton1.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(61)))));
            this.siticoneGradientCircleButton1.HoveredState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.siticoneGradientCircleButton1.HoveredState.Parent = this.siticoneGradientCircleButton1;
            this.siticoneGradientCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneGradientCircleButton1.Image")));
            this.siticoneGradientCircleButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.siticoneGradientCircleButton1.Location = new System.Drawing.Point(200, 5);
            this.siticoneGradientCircleButton1.Name = "siticoneGradientCircleButton1";
            this.siticoneGradientCircleButton1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneGradientCircleButton1.ShadowDecoration.Parent = this.siticoneGradientCircleButton1;
            this.siticoneGradientCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.siticoneGradientCircleButton1.TabIndex = 9;
            this.siticoneGradientCircleButton1.Tile = false;
            this.siticoneGradientCircleButton1.UseTransparentBackground = true;
            this.siticoneGradientCircleButton1.Click += new System.EventHandler(this.siticoneGradientCircleButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.Location = new System.Drawing.Point(12, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Docs";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel2.Location = new System.Drawing.Point(57, 236);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 17);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel3.Location = new System.Drawing.Point(112, 236);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(56, 17);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Discord";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkLabel4.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel4.Location = new System.Drawing.Point(173, 236);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(49, 17);
            this.linkLabel4.TabIndex = 13;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Reddit";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.pictureBox1;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this;
            // 
            // Spicetify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(235, 262);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.siticoneGradientCircleButton1);
            this.Controls.Add(this.UninstallBTN);
            this.Controls.Add(this.InstallBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spicetify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spicetify";
            this.Load += new System.EventHandler(this.Spicetify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneGradientButton InstallBTN;
        private Siticone.UI.WinForms.SiticoneGradientButton UninstallBTN;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton siticoneGradientCircleButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
    }
}

