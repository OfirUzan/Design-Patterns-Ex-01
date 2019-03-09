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
            this.m_PB_UserProfilePic.Location = new System.Drawing.Point(6, 40);
            this.m_PB_UserProfilePic.Name = "m_PB_UserProfilePic";
            this.m_PB_UserProfilePic.Size = new System.Drawing.Size(164, 181);
            this.m_PB_UserProfilePic.TabIndex = 0;
            this.m_PB_UserProfilePic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_TabHome);
            this.tabControl1.Controls.Add(this.m_TabProfile);
            this.tabControl1.Controls.Add(this.m_TabMyAlbums);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 404);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Click += new System.EventHandler(this.tabProfile_Click);
            // 
            // m_TabHome
            // 
            this.m_TabHome.Controls.Add(this.m_PB_UserProfilePic);
            this.m_TabHome.Controls.Add(this.label2);
            this.m_TabHome.Controls.Add(this.button1);
            this.m_TabHome.Controls.Add(this.label1);
            this.m_TabHome.Location = new System.Drawing.Point(4, 22);
            this.m_TabHome.Name = "m_TabHome";
            this.m_TabHome.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabHome.Size = new System.Drawing.Size(789, 378);
            this.m_TabHome.TabIndex = 0;
            this.m_TabHome.Text = "Home";
            this.m_TabHome.UseVisualStyleBackColor = true;
            // 
            // m_TabProfile
            // 
            this.m_TabProfile.Controls.Add(this.m_LinkLabel_TabProfile_FullName);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_ProfilePic);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_CoverPhoto);
            this.m_TabProfile.Location = new System.Drawing.Point(4, 22);
            this.m_TabProfile.Name = "m_TabProfile";
            this.m_TabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabProfile.Size = new System.Drawing.Size(789, 378);
            this.m_TabProfile.TabIndex = 1;
            this.m_TabProfile.Text = "Profile";
            this.m_TabProfile.UseVisualStyleBackColor = true;
            // 
            // m_LinkLabel_TabProfile_FullName
            // 
            this.m_LinkLabel_TabProfile_FullName.AutoSize = true;
            this.m_LinkLabel_TabProfile_FullName.Location = new System.Drawing.Point(28, 37);
            this.m_LinkLabel_TabProfile_FullName.Name = "m_LinkLabel_TabProfile_FullName";
            this.m_LinkLabel_TabProfile_FullName.Size = new System.Drawing.Size(54, 13);
            this.m_LinkLabel_TabProfile_FullName.TabIndex = 2;
            this.m_LinkLabel_TabProfile_FullName.TabStop = true;
            this.m_LinkLabel_TabProfile_FullName.Text = "Full Name";
            // 
            // m_PB_TabProfile_ProfilePic
            // 
            this.m_PB_TabProfile_ProfilePic.Location = new System.Drawing.Point(31, 53);
            this.m_PB_TabProfile_ProfilePic.Name = "m_PB_TabProfile_ProfilePic";
            this.m_PB_TabProfile_ProfilePic.Size = new System.Drawing.Size(126, 116);
            this.m_PB_TabProfile_ProfilePic.TabIndex = 1;
            this.m_PB_TabProfile_ProfilePic.TabStop = false;
            // 
            // m_PB_TabProfile_CoverPhoto
            // 
            this.m_PB_TabProfile_CoverPhoto.Location = new System.Drawing.Point(3, 7);
            this.m_PB_TabProfile_CoverPhoto.Name = "m_PB_TabProfile_CoverPhoto";
            this.m_PB_TabProfile_CoverPhoto.Size = new System.Drawing.Size(780, 187);
            this.m_PB_TabProfile_CoverPhoto.TabIndex = 0;
            this.m_PB_TabProfile_CoverPhoto.TabStop = false;
            // 
            // m_TabMyAlbums
            // 
            this.m_TabMyAlbums.Controls.Add(this.m_buttonPrevoiusPic);
            this.m_TabMyAlbums.Controls.Add(this.m_buttonNextPic);
            this.m_TabMyAlbums.Controls.Add(this.m_pictureBoxCurrentPic);
            this.m_TabMyAlbums.Controls.Add(this.m_comboBoxAlbums);
            this.m_TabMyAlbums.Location = new System.Drawing.Point(4, 22);
            this.m_TabMyAlbums.Name = "m_TabMyAlbums";
            this.m_TabMyAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabMyAlbums.Size = new System.Drawing.Size(789, 378);
            this.m_TabMyAlbums.TabIndex = 2;
            this.m_TabMyAlbums.Text = "My Albums";
            this.m_TabMyAlbums.UseVisualStyleBackColor = true;
            // 
            // m_buttonPrevoiusPic
            // 
            this.m_buttonPrevoiusPic.Location = new System.Drawing.Point(211, 309);
            this.m_buttonPrevoiusPic.Margin = new System.Windows.Forms.Padding(2);
            this.m_buttonPrevoiusPic.Name = "m_buttonPrevoiusPic";
            this.m_buttonPrevoiusPic.Size = new System.Drawing.Size(60, 37);
            this.m_buttonPrevoiusPic.TabIndex = 3;
            this.m_buttonPrevoiusPic.Text = "Previous";
            this.m_buttonPrevoiusPic.UseVisualStyleBackColor = true;
            this.m_buttonPrevoiusPic.Click += new System.EventHandler(this.m_buttonPrevoiusPic_Click);
            // 
            // m_buttonNextPic
            // 
            this.m_buttonNextPic.Location = new System.Drawing.Point(404, 309);
            this.m_buttonNextPic.Margin = new System.Windows.Forms.Padding(2);
            this.m_buttonNextPic.Name = "m_buttonNextPic";
            this.m_buttonNextPic.Size = new System.Drawing.Size(60, 37);
            this.m_buttonNextPic.TabIndex = 2;
            this.m_buttonNextPic.Text = "Next";
            this.m_buttonNextPic.UseVisualStyleBackColor = true;
            this.m_buttonNextPic.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // m_pictureBoxCurrentPic
            // 
            this.m_pictureBoxCurrentPic.Location = new System.Drawing.Point(211, 109);
            this.m_pictureBoxCurrentPic.Margin = new System.Windows.Forms.Padding(2);
            this.m_pictureBoxCurrentPic.Name = "m_pictureBoxCurrentPic";
            this.m_pictureBoxCurrentPic.Size = new System.Drawing.Size(253, 187);
            this.m_pictureBoxCurrentPic.TabIndex = 1;
            this.m_pictureBoxCurrentPic.TabStop = false;
            // 
            // m_comboBoxAlbums
            // 
            this.m_comboBoxAlbums.FormattingEnabled = true;
            this.m_comboBoxAlbums.Location = new System.Drawing.Point(14, 33);
            this.m_comboBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.m_comboBoxAlbums.Name = "m_comboBoxAlbums";
            this.m_comboBoxAlbums.Size = new System.Drawing.Size(197, 21);
            this.m_comboBoxAlbums.TabIndex = 0;
            this.m_comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxAlbums_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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