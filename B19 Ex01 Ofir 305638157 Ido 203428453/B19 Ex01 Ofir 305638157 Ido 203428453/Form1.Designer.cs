namespace B19_Ex01_Ofir_305638157_Ido_203428453
{
    partial class Form1
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
            this.m_PB_UserProfilePic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_TabHome = new System.Windows.Forms.TabPage();
            this.m_TabProfile = new System.Windows.Forms.TabPage();
            this.m_LinkLabel_TabProfile_FullName = new System.Windows.Forms.LinkLabel();
            this.m_PB_TabProfile_ProfilePic = new System.Windows.Forms.PictureBox();
            this.m_PB_TabProfile_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.m_TabMyAlbums = new System.Windows.Forms.TabPage();
            this.m_buttonPrevoiusPic = new System.Windows.Forms.Button();
            this.m_buttonNextPic = new System.Windows.Forms.Button();
            this.m_pictureBoxCurrentPic = new System.Windows.Forms.PictureBox();
            this.m_comboBoxAlbums = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_UserProfilePic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.m_TabHome.SuspendLayout();
            this.m_TabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_CoverPhoto)).BeginInit();
            this.m_TabMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxCurrentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PB_UserProfilePic
            // 
            this.m_PB_UserProfilePic.Location = new System.Drawing.Point(9, 62);
            this.m_PB_UserProfilePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PB_UserProfilePic.Name = "m_PB_UserProfilePic";
            this.m_PB_UserProfilePic.Size = new System.Drawing.Size(246, 278);
            this.m_PB_UserProfilePic.TabIndex = 0;
            this.m_PB_UserProfilePic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_TabHome);
            this.tabControl1.Controls.Add(this.m_TabProfile);
            this.tabControl1.Controls.Add(this.m_TabMyAlbums);
            this.tabControl1.Location = new System.Drawing.Point(0, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 622);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // m_TabHome
            // 
            this.m_TabHome.Controls.Add(this.m_PB_UserProfilePic);
            this.m_TabHome.Controls.Add(this.label2);
            this.m_TabHome.Controls.Add(this.button1);
            this.m_TabHome.Controls.Add(this.label1);
            this.m_TabHome.Location = new System.Drawing.Point(4, 29);
            this.m_TabHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabHome.Name = "m_TabHome";
            this.m_TabHome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabHome.Size = new System.Drawing.Size(1188, 589);
            this.m_TabHome.TabIndex = 0;
            this.m_TabHome.Text = "Home";
            this.m_TabHome.UseVisualStyleBackColor = true;
            // 
            // m_TabProfile
            // 
            this.m_TabProfile.Controls.Add(this.m_LinkLabel_TabProfile_FullName);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_ProfilePic);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_CoverPhoto);
            this.m_TabProfile.Location = new System.Drawing.Point(4, 29);
            this.m_TabProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabProfile.Name = "m_TabProfile";
            this.m_TabProfile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabProfile.Size = new System.Drawing.Size(1188, 589);
            this.m_TabProfile.TabIndex = 1;
            this.m_TabProfile.Text = "Profile";
            this.m_TabProfile.UseVisualStyleBackColor = true;
            // 
            // m_LinkLabel_TabProfile_FullName
            // 
            this.m_LinkLabel_TabProfile_FullName.AutoSize = true;
            this.m_LinkLabel_TabProfile_FullName.Location = new System.Drawing.Point(42, 57);
            this.m_LinkLabel_TabProfile_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LinkLabel_TabProfile_FullName.Name = "m_LinkLabel_TabProfile_FullName";
            this.m_LinkLabel_TabProfile_FullName.Size = new System.Drawing.Size(80, 20);
            this.m_LinkLabel_TabProfile_FullName.TabIndex = 2;
            this.m_LinkLabel_TabProfile_FullName.TabStop = true;
            this.m_LinkLabel_TabProfile_FullName.Text = "Full Name";
            // 
            // m_PB_TabProfile_ProfilePic
            // 
            this.m_PB_TabProfile_ProfilePic.Location = new System.Drawing.Point(46, 82);
            this.m_PB_TabProfile_ProfilePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PB_TabProfile_ProfilePic.Name = "m_PB_TabProfile_ProfilePic";
            this.m_PB_TabProfile_ProfilePic.Size = new System.Drawing.Size(189, 178);
            this.m_PB_TabProfile_ProfilePic.TabIndex = 1;
            this.m_PB_TabProfile_ProfilePic.TabStop = false;
            // 
            // m_PB_TabProfile_CoverPhoto
            // 
            this.m_PB_TabProfile_CoverPhoto.Location = new System.Drawing.Point(4, 11);
            this.m_PB_TabProfile_CoverPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PB_TabProfile_CoverPhoto.Name = "m_PB_TabProfile_CoverPhoto";
            this.m_PB_TabProfile_CoverPhoto.Size = new System.Drawing.Size(1170, 288);
            this.m_PB_TabProfile_CoverPhoto.TabIndex = 0;
            this.m_PB_TabProfile_CoverPhoto.TabStop = false;
            // 
            // m_TabMyAlbums
            // 
            this.m_TabMyAlbums.Controls.Add(this.m_buttonPrevoiusPic);
            this.m_TabMyAlbums.Controls.Add(this.m_buttonNextPic);
            this.m_TabMyAlbums.Controls.Add(this.m_pictureBoxCurrentPic);
            this.m_TabMyAlbums.Controls.Add(this.m_comboBoxAlbums);
            this.m_TabMyAlbums.Location = new System.Drawing.Point(4, 29);
            this.m_TabMyAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabMyAlbums.Name = "m_TabMyAlbums";
            this.m_TabMyAlbums.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabMyAlbums.Size = new System.Drawing.Size(1188, 589);
            this.m_TabMyAlbums.TabIndex = 2;
            this.m_TabMyAlbums.Text = "My Albums";
            this.m_TabMyAlbums.UseVisualStyleBackColor = true;
            // 
            // m_buttonPrevoiusPic
            // 
            this.m_buttonPrevoiusPic.Location = new System.Drawing.Point(316, 475);
            this.m_buttonPrevoiusPic.Name = "m_buttonPrevoiusPic";
            this.m_buttonPrevoiusPic.Size = new System.Drawing.Size(90, 57);
            this.m_buttonPrevoiusPic.TabIndex = 3;
            this.m_buttonPrevoiusPic.Text = "Previous";
            this.m_buttonPrevoiusPic.UseVisualStyleBackColor = true;
            this.m_buttonPrevoiusPic.Click += new System.EventHandler(this.m_buttonPrevoiusPic_Click);
            // 
            // m_buttonNextPic
            // 
            this.m_buttonNextPic.Location = new System.Drawing.Point(606, 475);
            this.m_buttonNextPic.Name = "m_buttonNextPic";
            this.m_buttonNextPic.Size = new System.Drawing.Size(90, 57);
            this.m_buttonNextPic.TabIndex = 2;
            this.m_buttonNextPic.Text = "Next";
            this.m_buttonNextPic.UseVisualStyleBackColor = true;
            this.m_buttonNextPic.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // m_pictureBoxCurrentPic
            // 
            this.m_pictureBoxCurrentPic.Location = new System.Drawing.Point(316, 168);
            this.m_pictureBoxCurrentPic.Name = "m_pictureBoxCurrentPic";
            this.m_pictureBoxCurrentPic.Size = new System.Drawing.Size(380, 288);
            this.m_pictureBoxCurrentPic.TabIndex = 1;
            this.m_pictureBoxCurrentPic.TabStop = false;
            // 
            // m_comboBoxAlbums
            // 
            this.m_comboBoxAlbums.FormattingEnabled = true;
            this.m_comboBoxAlbums.Location = new System.Drawing.Point(21, 51);
            this.m_comboBoxAlbums.Name = "m_comboBoxAlbums";
            this.m_comboBoxAlbums.Size = new System.Drawing.Size(294, 28);
            this.m_comboBoxAlbums.TabIndex = 0;
            this.m_comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxAlbums_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_UserProfilePic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.m_TabHome.ResumeLayout(false);
            this.m_TabHome.PerformLayout();
            this.m_TabProfile.ResumeLayout(false);
            this.m_TabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_CoverPhoto)).EndInit();
            this.m_TabMyAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxCurrentPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PB_UserProfilePic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_TabHome;
        private System.Windows.Forms.TabPage m_TabProfile;
        private System.Windows.Forms.TabPage m_TabMyAlbums;
        private System.Windows.Forms.Button m_buttonNextPic;
        private System.Windows.Forms.PictureBox m_pictureBoxCurrentPic;
        private System.Windows.Forms.ComboBox m_comboBoxAlbums;
        private System.Windows.Forms.Button m_buttonPrevoiusPic;
        private System.Windows.Forms.LinkLabel m_LinkLabel_TabProfile_FullName;
        private System.Windows.Forms.PictureBox m_PB_TabProfile_ProfilePic;
        private System.Windows.Forms.PictureBox m_PB_TabProfile_CoverPhoto;
    }
}