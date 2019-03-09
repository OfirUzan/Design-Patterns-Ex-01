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
            this.m_Panel_TabProfile = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_TabProfile_birth = new System.Windows.Forms.Label();
            this.m_Label_TabProfile_Birth = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Email = new System.Windows.Forms.Label();
            this.Label_TabProfile_Email = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Lives = new System.Windows.Forms.Label();
            this.Label_TabProfile_LiveinL = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Relationship = new System.Windows.Forms.Label();
            this.Label_TabProfile_RelationL = new System.Windows.Forms.Label();
            this.m_Label_TabProfile_About = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_UserProfilePic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.m_TabHome.SuspendLayout();
            this.m_TabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_CoverPhoto)).BeginInit();
            this.m_TabMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxCurrentPic)).BeginInit();
            this.m_Panel_TabProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(951, 602);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.m_TabProfile.Controls.Add(this.m_Panel_TabProfile);
            this.m_TabProfile.Controls.Add(this.m_LinkLabel_TabProfile_FullName);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_ProfilePic);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_CoverPhoto);
            this.m_TabProfile.Location = new System.Drawing.Point(4, 22);
            this.m_TabProfile.Name = "m_TabProfile";
            this.m_TabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabProfile.Size = new System.Drawing.Size(943, 576);
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
            this.m_PB_TabProfile_ProfilePic.Location = new System.Drawing.Point(31, 63);
            this.m_PB_TabProfile_ProfilePic.Name = "m_PB_TabProfile_ProfilePic";
            this.m_PB_TabProfile_ProfilePic.Size = new System.Drawing.Size(126, 116);
            this.m_PB_TabProfile_ProfilePic.TabIndex = 1;
            this.m_PB_TabProfile_ProfilePic.TabStop = false;
            // 
            // m_PB_TabProfile_CoverPhoto
            // 
            this.m_PB_TabProfile_CoverPhoto.Location = new System.Drawing.Point(3, 7);
            this.m_PB_TabProfile_CoverPhoto.Name = "m_PB_TabProfile_CoverPhoto";
            this.m_PB_TabProfile_CoverPhoto.Size = new System.Drawing.Size(934, 214);
            this.m_PB_TabProfile_CoverPhoto.TabIndex = 0;
            this.m_PB_TabProfile_CoverPhoto.TabStop = false;
            // 
            // m_TabMyAlbums
            // 
            this.m_TabMyAlbums.Controls.Add(this.m_buttonUpload);
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
            // m_Panel_TabProfile
            // 
            this.m_Panel_TabProfile.Controls.Add(this.m_Label_TabProfile_About);
            this.m_Panel_TabProfile.Controls.Add(this.panel5);
            this.m_Panel_TabProfile.Controls.Add(this.panel4);
            this.m_Panel_TabProfile.Controls.Add(this.panel3);
            this.m_Panel_TabProfile.Controls.Add(this.panel2);
            this.m_Panel_TabProfile.Location = new System.Drawing.Point(8, 249);
            this.m_Panel_TabProfile.Name = "m_Panel_TabProfile";
            this.m_Panel_TabProfile.Size = new System.Drawing.Size(202, 290);
            this.m_Panel_TabProfile.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_Label_TabProfile_Birth);
            this.panel2.Controls.Add(this.Label_TabProfile_birth);
            this.panel2.Location = new System.Drawing.Point(3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 34);
            this.panel2.TabIndex = 0;
            // 
            // Label_TabProfile_birth
            // 
            this.Label_TabProfile_birth.AutoSize = true;
            this.Label_TabProfile_birth.Location = new System.Drawing.Point(4, 14);
            this.Label_TabProfile_birth.Name = "Label_TabProfile_birth";
            this.Label_TabProfile_birth.Size = new System.Drawing.Size(45, 13);
            this.Label_TabProfile_birth.TabIndex = 0;
            this.Label_TabProfile_birth.Text = "Birthday";
            // 
            // m_Label_TabProfile_Birth
            // 
            this.m_Label_TabProfile_Birth.AutoSize = true;
            this.m_Label_TabProfile_Birth.Location = new System.Drawing.Point(94, 14);
            this.m_Label_TabProfile_Birth.Name = "m_Label_TabProfile_Birth";
            this.m_Label_TabProfile_Birth.Size = new System.Drawing.Size(55, 13);
            this.m_Label_TabProfile_Birth.TabIndex = 1;
            this.m_Label_TabProfile_Birth.Text = "dd/mm/yy";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_Label_TabProfile_Email);
            this.panel3.Controls.Add(this.Label_TabProfile_Email);
            this.panel3.Location = new System.Drawing.Point(3, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 34);
            this.panel3.TabIndex = 2;
            // 
            // m_Label_TabProfile_Email
            // 
            this.m_Label_TabProfile_Email.AutoSize = true;
            this.m_Label_TabProfile_Email.Location = new System.Drawing.Point(94, 14);
            this.m_Label_TabProfile_Email.Name = "m_Label_TabProfile_Email";
            this.m_Label_TabProfile_Email.Size = new System.Drawing.Size(67, 13);
            this.m_Label_TabProfile_Email.TabIndex = 1;
            this.m_Label_TabProfile_Email.Text = "0527212121";
            // 
            // Label_TabProfile_Email
            // 
            this.Label_TabProfile_Email.AutoSize = true;
            this.Label_TabProfile_Email.Location = new System.Drawing.Point(4, 14);
            this.Label_TabProfile_Email.Name = "Label_TabProfile_Email";
            this.Label_TabProfile_Email.Size = new System.Drawing.Size(32, 13);
            this.Label_TabProfile_Email.TabIndex = 0;
            this.Label_TabProfile_Email.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_Label_TabProfile_Lives);
            this.panel4.Controls.Add(this.Label_TabProfile_LiveinL);
            this.panel4.Location = new System.Drawing.Point(3, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 34);
            this.panel4.TabIndex = 3;
            // 
            // m_Label_TabProfile_Lives
            // 
            this.m_Label_TabProfile_Lives.AutoSize = true;
            this.m_Label_TabProfile_Lives.Location = new System.Drawing.Point(94, 14);
            this.m_Label_TabProfile_Lives.Name = "m_Label_TabProfile_Lives";
            this.m_Label_TabProfile_Lives.Size = new System.Drawing.Size(77, 13);
            this.m_Label_TabProfile_Lives.TabIndex = 1;
            this.m_Label_TabProfile_Lives.Text = "Tel Aviv, Israel";
            // 
            // Label_TabProfile_LiveinL
            // 
            this.Label_TabProfile_LiveinL.AutoSize = true;
            this.Label_TabProfile_LiveinL.Location = new System.Drawing.Point(4, 14);
            this.Label_TabProfile_LiveinL.Name = "Label_TabProfile_LiveinL";
            this.Label_TabProfile_LiveinL.Size = new System.Drawing.Size(44, 13);
            this.Label_TabProfile_LiveinL.TabIndex = 0;
            this.Label_TabProfile_LiveinL.Text = "Lives In";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_Label_TabProfile_Relationship);
            this.panel5.Controls.Add(this.Label_TabProfile_RelationL);
            this.panel5.Location = new System.Drawing.Point(3, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 34);
            this.panel5.TabIndex = 4;
            // 
            // m_Label_TabProfile_Relationship
            // 
            this.m_Label_TabProfile_Relationship.AutoSize = true;
            this.m_Label_TabProfile_Relationship.Location = new System.Drawing.Point(94, 14);
            this.m_Label_TabProfile_Relationship.Name = "m_Label_TabProfile_Relationship";
            this.m_Label_TabProfile_Relationship.Size = new System.Drawing.Size(36, 13);
            this.m_Label_TabProfile_Relationship.TabIndex = 1;
            this.m_Label_TabProfile_Relationship.Text = "Single";
            // 
            // Label_TabProfile_RelationL
            // 
            this.Label_TabProfile_RelationL.AutoSize = true;
            this.Label_TabProfile_RelationL.Location = new System.Drawing.Point(4, 14);
            this.Label_TabProfile_RelationL.Name = "Label_TabProfile_RelationL";
            this.Label_TabProfile_RelationL.Size = new System.Drawing.Size(86, 13);
            this.Label_TabProfile_RelationL.TabIndex = 0;
            this.Label_TabProfile_RelationL.Text = "RELATIONSHIP";
            // 
            // m_Label_TabProfile_About
            // 
            this.m_Label_TabProfile_About.AutoSize = true;
            this.m_Label_TabProfile_About.Location = new System.Drawing.Point(3, 4);
            this.m_Label_TabProfile_About.Name = "m_Label_TabProfile_About";
            this.m_Label_TabProfile_About.Size = new System.Drawing.Size(38, 13);
            this.m_Label_TabProfile_About.TabIndex = 5;
            this.m_Label_TabProfile_About.Text = "About:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 640);
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
            this.m_Panel_TabProfile.ResumeLayout(false);
            this.m_Panel_TabProfile.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel m_Panel_TabProfile;
        private System.Windows.Forms.Label m_Label_TabProfile_About;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label m_Label_TabProfile_Relationship;
        private System.Windows.Forms.Label Label_TabProfile_RelationL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label m_Label_TabProfile_Lives;
        private System.Windows.Forms.Label Label_TabProfile_LiveinL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_Label_TabProfile_Email;
        private System.Windows.Forms.Label Label_TabProfile_Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_Label_TabProfile_Birth;
        private System.Windows.Forms.Label Label_TabProfile_birth;
    }
}