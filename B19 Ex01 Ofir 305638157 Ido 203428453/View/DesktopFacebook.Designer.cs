namespace View
{
    partial class DesktopFacebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopFacebook));
            this.m_tabsControl = new System.Windows.Forms.TabControl();
            this.m_TabProfile = new System.Windows.Forms.TabPage();
            this.m_Panel_TabProfile = new System.Windows.Forms.Panel();
            this.m_buttonLogout = new System.Windows.Forms.Button();
            this.m_Label_TabProfile_About = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Gender = new System.Windows.Forms.Label();
            this.Label_TabProfile_Gender = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Lives = new System.Windows.Forms.Label();
            this.Label_TabProfile_LiveinL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Email = new System.Windows.Forms.Label();
            this.Label_TabProfile_Email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_Label_TabProfile_Birth = new System.Windows.Forms.Label();
            this.Label_TabProfile_birth = new System.Windows.Forms.Label();
            this.m_LinkLabel_TabProfile_FullName = new System.Windows.Forms.LinkLabel();
            this.m_PB_TabProfile_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.m_TabMyAlbums = new System.Windows.Forms.TabPage();
            this.m_labelPicNumber = new System.Windows.Forms.Label();
            this.m_buttonUpload = new System.Windows.Forms.Button();
            this.m_buttonPrevoiusPic = new System.Windows.Forms.Button();
            this.m_buttonNextPic = new System.Windows.Forms.Button();
            this.m_pictureBoxCurrentPic = new System.Windows.Forms.PictureBox();
            this.m_comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.m_TabMyProfile = new System.Windows.Forms.TabPage();
            this.m_userProfileComponent = new View.UserProfileComponent();
            this.m_TabFriendsProfile = new System.Windows.Forms.TabPage();
            this.m_buttonSearchAFriend = new System.Windows.Forms.Button();
            this.m_textBoxFriendName = new System.Windows.Forms.TextBox();
            this.m_friendProfileComponent = new View.UserProfileComponent();
            this.panel_Navigate = new System.Windows.Forms.Panel();
            this.m_PB_TabProfile_ProfilePic = new System.Windows.Forms.PictureBox();
            this.m_Panel_Wall = new System.Windows.Forms.Panel();
            this.m_Label_Wall_Date = new System.Windows.Forms.Label();
            this.m_PB_Wall = new System.Windows.Forms.PictureBox();
            this.m_Label_Wall_Name = new System.Windows.Forms.Label();
            this.m_RTB_Wall_Description = new System.Windows.Forms.RichTextBox();
            this.m_RTB_Wall_Comment = new System.Windows.Forms.RichTextBox();
            this.label_comments = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m_tabsControl.SuspendLayout();
            this.m_TabProfile.SuspendLayout();
            this.m_Panel_TabProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_CoverPhoto)).BeginInit();
            this.m_TabMyAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxCurrentPic)).BeginInit();
            this.m_TabMyProfile.SuspendLayout();
            this.m_TabFriendsProfile.SuspendLayout();
            this.panel_Navigate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_ProfilePic)).BeginInit();
            this.m_Panel_Wall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_Wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tabsControl
            // 
            this.m_tabsControl.Controls.Add(this.m_TabProfile);
            this.m_tabsControl.Controls.Add(this.m_TabMyAlbums);
            this.m_tabsControl.Controls.Add(this.m_TabMyProfile);
            this.m_tabsControl.Controls.Add(this.m_TabFriendsProfile);
            this.m_tabsControl.Location = new System.Drawing.Point(0, 18);
            this.m_tabsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_tabsControl.Name = "m_tabsControl";
            this.m_tabsControl.SelectedIndex = 0;
            this.m_tabsControl.Size = new System.Drawing.Size(1413, 1028);
            this.m_tabsControl.TabIndex = 4;
            // 
            // m_TabProfile
            // 
            this.m_TabProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.m_TabProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_TabProfile.Controls.Add(this.m_Panel_Wall);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_ProfilePic);
            this.m_TabProfile.Controls.Add(this.panel_Navigate);
            this.m_TabProfile.Controls.Add(this.m_Panel_TabProfile);
            this.m_TabProfile.Controls.Add(this.m_LinkLabel_TabProfile_FullName);
            this.m_TabProfile.Controls.Add(this.m_PB_TabProfile_CoverPhoto);
            this.m_TabProfile.Location = new System.Drawing.Point(4, 29);
            this.m_TabProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabProfile.Name = "m_TabProfile";
            this.m_TabProfile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabProfile.Size = new System.Drawing.Size(1405, 995);
            this.m_TabProfile.TabIndex = 1;
            this.m_TabProfile.Text = "Profile";
            // 
            // m_Panel_TabProfile
            // 
            this.m_Panel_TabProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_Panel_TabProfile.Controls.Add(this.pictureBox3);
            this.m_Panel_TabProfile.Controls.Add(this.m_Label_TabProfile_About);
            this.m_Panel_TabProfile.Controls.Add(this.panel5);
            this.m_Panel_TabProfile.Controls.Add(this.panel4);
            this.m_Panel_TabProfile.Controls.Add(this.panel3);
            this.m_Panel_TabProfile.Controls.Add(this.panel2);
            this.m_Panel_TabProfile.Location = new System.Drawing.Point(39, 396);
            this.m_Panel_TabProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_Panel_TabProfile.Name = "m_Panel_TabProfile";
            this.m_Panel_TabProfile.Size = new System.Drawing.Size(304, 439);
            this.m_Panel_TabProfile.TabIndex = 3;
            // 
            // m_buttonLogout
            // 
            this.m_buttonLogout.Location = new System.Drawing.Point(1196, 6);
            this.m_buttonLogout.Name = "m_buttonLogout";
            this.m_buttonLogout.Size = new System.Drawing.Size(182, 39);
            this.m_buttonLogout.TabIndex = 4;
            this.m_buttonLogout.Text = "Logout";
            this.m_buttonLogout.UseVisualStyleBackColor = true;
            this.m_buttonLogout.Click += new System.EventHandler(this.m_buttonLogout_Click);
            // 
            // m_Label_TabProfile_About
            // 
            this.m_Label_TabProfile_About.AutoSize = true;
            this.m_Label_TabProfile_About.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Label_TabProfile_About.Location = new System.Drawing.Point(88, 19);
            this.m_Label_TabProfile_About.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_TabProfile_About.Name = "m_Label_TabProfile_About";
            this.m_Label_TabProfile_About.Size = new System.Drawing.Size(77, 33);
            this.m_Label_TabProfile_About.TabIndex = 5;
            this.m_Label_TabProfile_About.Text = "Intro";
            this.m_Label_TabProfile_About.Click += new System.EventHandler(this.m_Label_TabProfile_About_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_Label_TabProfile_Gender);
            this.panel5.Controls.Add(this.Label_TabProfile_Gender);
            this.panel5.Location = new System.Drawing.Point(15, 266);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 52);
            this.panel5.TabIndex = 4;
            // 
            // m_Label_TabProfile_Gender
            // 
            this.m_Label_TabProfile_Gender.AutoSize = true;
            this.m_Label_TabProfile_Gender.Location = new System.Drawing.Point(141, 22);
            this.m_Label_TabProfile_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_TabProfile_Gender.Name = "m_Label_TabProfile_Gender";
            this.m_Label_TabProfile_Gender.Size = new System.Drawing.Size(43, 20);
            this.m_Label_TabProfile_Gender.TabIndex = 1;
            this.m_Label_TabProfile_Gender.Text = "male";
            // 
            // Label_TabProfile_Gender
            // 
            this.Label_TabProfile_Gender.AutoSize = true;
            this.Label_TabProfile_Gender.Location = new System.Drawing.Point(6, 22);
            this.Label_TabProfile_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TabProfile_Gender.Name = "Label_TabProfile_Gender";
            this.Label_TabProfile_Gender.Size = new System.Drawing.Size(63, 20);
            this.Label_TabProfile_Gender.TabIndex = 0;
            this.Label_TabProfile_Gender.Text = "Gender";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_Label_TabProfile_Lives);
            this.panel4.Controls.Add(this.Label_TabProfile_LiveinL);
            this.panel4.Location = new System.Drawing.Point(15, 204);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 52);
            this.panel4.TabIndex = 3;
            // 
            // m_Label_TabProfile_Lives
            // 
            this.m_Label_TabProfile_Lives.AutoSize = true;
            this.m_Label_TabProfile_Lives.Location = new System.Drawing.Point(141, 22);
            this.m_Label_TabProfile_Lives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_TabProfile_Lives.Name = "m_Label_TabProfile_Lives";
            this.m_Label_TabProfile_Lives.Size = new System.Drawing.Size(109, 20);
            this.m_Label_TabProfile_Lives.TabIndex = 1;
            this.m_Label_TabProfile_Lives.Text = "Tel Aviv, Israel";
            // 
            // Label_TabProfile_LiveinL
            // 
            this.Label_TabProfile_LiveinL.AutoSize = true;
            this.Label_TabProfile_LiveinL.Location = new System.Drawing.Point(6, 22);
            this.Label_TabProfile_LiveinL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TabProfile_LiveinL.Name = "Label_TabProfile_LiveinL";
            this.Label_TabProfile_LiveinL.Size = new System.Drawing.Size(63, 20);
            this.Label_TabProfile_LiveinL.TabIndex = 0;
            this.Label_TabProfile_LiveinL.Text = "Lives In";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_Label_TabProfile_Email);
            this.panel3.Controls.Add(this.Label_TabProfile_Email);
            this.panel3.Location = new System.Drawing.Point(15, 143);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 52);
            this.panel3.TabIndex = 2;
            // 
            // m_Label_TabProfile_Email
            // 
            this.m_Label_TabProfile_Email.AutoSize = true;
            this.m_Label_TabProfile_Email.Location = new System.Drawing.Point(141, 22);
            this.m_Label_TabProfile_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_TabProfile_Email.Name = "m_Label_TabProfile_Email";
            this.m_Label_TabProfile_Email.Size = new System.Drawing.Size(99, 20);
            this.m_Label_TabProfile_Email.TabIndex = 1;
            this.m_Label_TabProfile_Email.Text = "0527212121";
            // 
            // Label_TabProfile_Email
            // 
            this.Label_TabProfile_Email.AutoSize = true;
            this.Label_TabProfile_Email.Location = new System.Drawing.Point(6, 22);
            this.Label_TabProfile_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TabProfile_Email.Name = "Label_TabProfile_Email";
            this.Label_TabProfile_Email.Size = new System.Drawing.Size(48, 20);
            this.Label_TabProfile_Email.TabIndex = 0;
            this.Label_TabProfile_Email.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_Label_TabProfile_Birth);
            this.panel2.Controls.Add(this.Label_TabProfile_birth);
            this.panel2.Location = new System.Drawing.Point(15, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 52);
            this.panel2.TabIndex = 0;
            // 
            // m_Label_TabProfile_Birth
            // 
            this.m_Label_TabProfile_Birth.AutoSize = true;
            this.m_Label_TabProfile_Birth.Location = new System.Drawing.Point(141, 22);
            this.m_Label_TabProfile_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_TabProfile_Birth.Name = "m_Label_TabProfile_Birth";
            this.m_Label_TabProfile_Birth.Size = new System.Drawing.Size(75, 20);
            this.m_Label_TabProfile_Birth.TabIndex = 1;
            this.m_Label_TabProfile_Birth.Text = "dd/mm/yy";
            // 
            // Label_TabProfile_birth
            // 
            this.Label_TabProfile_birth.AutoSize = true;
            this.Label_TabProfile_birth.Location = new System.Drawing.Point(6, 22);
            this.Label_TabProfile_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TabProfile_birth.Name = "Label_TabProfile_birth";
            this.Label_TabProfile_birth.Size = new System.Drawing.Size(67, 20);
            this.Label_TabProfile_birth.TabIndex = 0;
            this.Label_TabProfile_birth.Text = "Birthday";
            // 
            // m_LinkLabel_TabProfile_FullName
            // 
            this.m_LinkLabel_TabProfile_FullName.AutoSize = true;
            this.m_LinkLabel_TabProfile_FullName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_TabProfile_FullName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LinkLabel_TabProfile_FullName.LinkColor = System.Drawing.Color.White;
            this.m_LinkLabel_TabProfile_FullName.Location = new System.Drawing.Point(299, 295);
            this.m_LinkLabel_TabProfile_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LinkLabel_TabProfile_FullName.Name = "m_LinkLabel_TabProfile_FullName";
            this.m_LinkLabel_TabProfile_FullName.Size = new System.Drawing.Size(151, 33);
            this.m_LinkLabel_TabProfile_FullName.TabIndex = 2;
            this.m_LinkLabel_TabProfile_FullName.TabStop = true;
            this.m_LinkLabel_TabProfile_FullName.Text = "Full Name";
            // 
            // m_PB_TabProfile_CoverPhoto
            // 
            this.m_PB_TabProfile_CoverPhoto.Location = new System.Drawing.Point(4, 11);
            this.m_PB_TabProfile_CoverPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PB_TabProfile_CoverPhoto.Name = "m_PB_TabProfile_CoverPhoto";
            this.m_PB_TabProfile_CoverPhoto.Size = new System.Drawing.Size(1381, 332);
            this.m_PB_TabProfile_CoverPhoto.TabIndex = 0;
            this.m_PB_TabProfile_CoverPhoto.TabStop = false;
            // 
            // m_TabMyAlbums
            // 
            this.m_TabMyAlbums.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_TabMyAlbums.BackgroundImage")));
            this.m_TabMyAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_TabMyAlbums.Controls.Add(this.m_labelPicNumber);
            this.m_TabMyAlbums.Controls.Add(this.m_buttonUpload);
            this.m_TabMyAlbums.Controls.Add(this.m_buttonPrevoiusPic);
            this.m_TabMyAlbums.Controls.Add(this.m_buttonNextPic);
            this.m_TabMyAlbums.Controls.Add(this.m_pictureBoxCurrentPic);
            this.m_TabMyAlbums.Controls.Add(this.m_comboBoxAlbums);
            this.m_TabMyAlbums.Location = new System.Drawing.Point(4, 29);
            this.m_TabMyAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabMyAlbums.Name = "m_TabMyAlbums";
            this.m_TabMyAlbums.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabMyAlbums.Size = new System.Drawing.Size(1418, 893);
            this.m_TabMyAlbums.TabIndex = 2;
            this.m_TabMyAlbums.Text = "My Albums";
            this.m_TabMyAlbums.UseVisualStyleBackColor = true;
            // 
            // m_labelPicNumber
            // 
            this.m_labelPicNumber.AutoSize = true;
            this.m_labelPicNumber.Location = new System.Drawing.Point(472, 494);
            this.m_labelPicNumber.Name = "m_labelPicNumber";
            this.m_labelPicNumber.Size = new System.Drawing.Size(0, 20);
            this.m_labelPicNumber.TabIndex = 4;
            // 
            // m_buttonUpload
            // 
            this.m_buttonUpload.Location = new System.Drawing.Point(0, 0);
            this.m_buttonUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_buttonUpload.Name = "m_buttonUpload";
            this.m_buttonUpload.Size = new System.Drawing.Size(112, 35);
            this.m_buttonUpload.TabIndex = 0;
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
            // m_TabMyProfile
            // 
            this.m_TabMyProfile.Controls.Add(this.m_userProfileComponent);
            this.m_TabMyProfile.Location = new System.Drawing.Point(4, 29);
            this.m_TabMyProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabMyProfile.Name = "m_TabMyProfile";
            this.m_TabMyProfile.Size = new System.Drawing.Size(1418, 893);
            this.m_TabMyProfile.TabIndex = 3;
            this.m_TabMyProfile.Text = "My Profile";
            this.m_TabMyProfile.UseVisualStyleBackColor = true;
            // 
            // m_userProfileComponent
            // 
            this.m_userProfileComponent.Location = new System.Drawing.Point(0, 3);
            this.m_userProfileComponent.Name = "m_userProfileComponent";
            this.m_userProfileComponent.Size = new System.Drawing.Size(1408, 883);
            this.m_userProfileComponent.TabIndex = 0;
            // 
            // m_TabFriendsProfile
            // 
            this.m_TabFriendsProfile.Controls.Add(this.m_buttonSearchAFriend);
            this.m_TabFriendsProfile.Controls.Add(this.m_textBoxFriendName);
            this.m_TabFriendsProfile.Controls.Add(this.m_friendProfileComponent);
            this.m_TabFriendsProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.m_TabFriendsProfile.Location = new System.Drawing.Point(4, 29);
            this.m_TabFriendsProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TabFriendsProfile.Name = "m_TabFriendsProfile";
            this.m_TabFriendsProfile.Size = new System.Drawing.Size(1418, 893);
            this.m_TabFriendsProfile.TabIndex = 4;
            this.m_TabFriendsProfile.Text = "Friend\'s Profile";
            this.m_TabFriendsProfile.UseVisualStyleBackColor = true;
            // 
            // m_buttonSearchAFriend
            // 
            this.m_buttonSearchAFriend.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_buttonSearchAFriend.ForeColor = System.Drawing.SystemColors.Window;
            this.m_buttonSearchAFriend.Location = new System.Drawing.Point(298, 9);
            this.m_buttonSearchAFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_buttonSearchAFriend.Name = "m_buttonSearchAFriend";
            this.m_buttonSearchAFriend.Size = new System.Drawing.Size(112, 35);
            this.m_buttonSearchAFriend.TabIndex = 2;
            this.m_buttonSearchAFriend.Text = "Search";
            this.m_buttonSearchAFriend.UseVisualStyleBackColor = false;
            this.m_buttonSearchAFriend.Click += new System.EventHandler(this.m_buttonSearchAFriend_Click);
            // 
            // m_textBoxFriendName
            // 
            this.m_textBoxFriendName.Location = new System.Drawing.Point(6, 9);
            this.m_textBoxFriendName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_textBoxFriendName.Name = "m_textBoxFriendName";
            this.m_textBoxFriendName.Size = new System.Drawing.Size(282, 26);
            this.m_textBoxFriendName.TabIndex = 1;
            this.m_textBoxFriendName.Text = "What\'s your friend\'s name?";
            this.m_textBoxFriendName.Click += new System.EventHandler(this.m_textBoxFriendName_Click);
            // 
            // m_friendProfileComponent
            // 
            this.m_friendProfileComponent.Location = new System.Drawing.Point(0, 48);
            this.m_friendProfileComponent.Name = "m_friendProfileComponent";
            this.m_friendProfileComponent.Size = new System.Drawing.Size(1398, 883);
            this.m_friendProfileComponent.TabIndex = 0;
            // 
            // panel_Navigate
            // 
            this.panel_Navigate.BackColor = System.Drawing.Color.White;
            this.panel_Navigate.Controls.Add(this.button5);
            this.panel_Navigate.Controls.Add(this.button4);
            this.panel_Navigate.Controls.Add(this.button3);
            this.panel_Navigate.Controls.Add(this.m_buttonLogout);
            this.panel_Navigate.Location = new System.Drawing.Point(4, 331);
            this.panel_Navigate.Name = "panel_Navigate";
            this.panel_Navigate.Size = new System.Drawing.Size(1381, 59);
            this.panel_Navigate.TabIndex = 4;
            // 
            // m_PB_TabProfile_ProfilePic
            // 
            this.m_PB_TabProfile_ProfilePic.Location = new System.Drawing.Point(39, 143);
            this.m_PB_TabProfile_ProfilePic.Name = "m_PB_TabProfile_ProfilePic";
            this.m_PB_TabProfile_ProfilePic.Size = new System.Drawing.Size(253, 224);
            this.m_PB_TabProfile_ProfilePic.TabIndex = 5;
            this.m_PB_TabProfile_ProfilePic.TabStop = false;
            // 
            // m_Panel_Wall
            // 
            this.m_Panel_Wall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_Panel_Wall.Controls.Add(this.button2);
            this.m_Panel_Wall.Controls.Add(this.button1);
            this.m_Panel_Wall.Controls.Add(this.label_comments);
            this.m_Panel_Wall.Controls.Add(this.m_RTB_Wall_Comment);
            this.m_Panel_Wall.Controls.Add(this.m_RTB_Wall_Description);
            this.m_Panel_Wall.Controls.Add(this.m_Label_Wall_Name);
            this.m_Panel_Wall.Controls.Add(this.m_PB_Wall);
            this.m_Panel_Wall.Controls.Add(this.m_Label_Wall_Date);
            this.m_Panel_Wall.Location = new System.Drawing.Point(366, 396);
            this.m_Panel_Wall.Name = "m_Panel_Wall";
            this.m_Panel_Wall.Size = new System.Drawing.Size(1019, 591);
            this.m_Panel_Wall.TabIndex = 6;
            // 
            // m_Label_Wall_Date
            // 
            this.m_Label_Wall_Date.AutoSize = true;
            this.m_Label_Wall_Date.BackColor = System.Drawing.Color.SkyBlue;
            this.m_Label_Wall_Date.Location = new System.Drawing.Point(33, 32);
            this.m_Label_Wall_Date.Name = "m_Label_Wall_Date";
            this.m_Label_Wall_Date.Size = new System.Drawing.Size(71, 20);
            this.m_Label_Wall_Date.TabIndex = 0;
            this.m_Label_Wall_Date.Text = "00/00/00";
            // 
            // m_PB_Wall
            // 
            this.m_PB_Wall.Location = new System.Drawing.Point(37, 55);
            this.m_PB_Wall.Name = "m_PB_Wall";
            this.m_PB_Wall.Size = new System.Drawing.Size(420, 361);
            this.m_PB_Wall.TabIndex = 1;
            this.m_PB_Wall.TabStop = false;
            // 
            // m_Label_Wall_Name
            // 
            this.m_Label_Wall_Name.AutoSize = true;
            this.m_Label_Wall_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.m_Label_Wall_Name.Location = new System.Drawing.Point(463, 32);
            this.m_Label_Wall_Name.Name = "m_Label_Wall_Name";
            this.m_Label_Wall_Name.Size = new System.Drawing.Size(38, 20);
            this.m_Label_Wall_Name.TabIndex = 2;
            this.m_Label_Wall_Name.Text = "Title";
            // 
            // m_RTB_Wall_Description
            // 
            this.m_RTB_Wall_Description.Location = new System.Drawing.Point(463, 55);
            this.m_RTB_Wall_Description.Name = "m_RTB_Wall_Description";
            this.m_RTB_Wall_Description.Size = new System.Drawing.Size(536, 517);
            this.m_RTB_Wall_Description.TabIndex = 3;
            this.m_RTB_Wall_Description.Text = "";
            // 
            // m_RTB_Wall_Comment
            // 
            this.m_RTB_Wall_Comment.Location = new System.Drawing.Point(37, 442);
            this.m_RTB_Wall_Comment.Name = "m_RTB_Wall_Comment";
            this.m_RTB_Wall_Comment.Size = new System.Drawing.Size(420, 70);
            this.m_RTB_Wall_Comment.TabIndex = 4;
            this.m_RTB_Wall_Comment.Text = "";
            // 
            // label_comments
            // 
            this.label_comments.AutoSize = true;
            this.label_comments.Location = new System.Drawing.Point(33, 419);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(90, 20);
            this.label_comments.TabIndex = 5;
            this.label_comments.Text = "Comments:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(325, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Friends";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button4.Location = new System.Drawing.Point(583, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Album";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button5.Location = new System.Drawing.Point(849, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 42);
            this.button5.TabIndex = 7;
            this.button5.Text = "Photos";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(15, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 58);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // DesktopFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1415, 1046);
            this.Controls.Add(this.m_tabsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DesktopFacebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook For Desktop!";
            this.m_tabsControl.ResumeLayout(false);
            this.m_TabProfile.ResumeLayout(false);
            this.m_TabProfile.PerformLayout();
            this.m_Panel_TabProfile.ResumeLayout(false);
            this.m_Panel_TabProfile.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_CoverPhoto)).EndInit();
            this.m_TabMyAlbums.ResumeLayout(false);
            this.m_TabMyAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxCurrentPic)).EndInit();
            this.m_TabMyProfile.ResumeLayout(false);
            this.m_TabFriendsProfile.ResumeLayout(false);
            this.m_TabFriendsProfile.PerformLayout();
            this.panel_Navigate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabProfile_ProfilePic)).EndInit();
            this.m_Panel_Wall.ResumeLayout(false);
            this.m_Panel_Wall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_Wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button m_buttonUpload;
        private System.Windows.Forms.TabControl m_tabsControl;
        private System.Windows.Forms.TabPage m_TabProfile;
        private System.Windows.Forms.TabPage m_TabMyAlbums;
        private System.Windows.Forms.Button m_buttonNextPic;
        private System.Windows.Forms.PictureBox m_pictureBoxCurrentPic;
        private System.Windows.Forms.ComboBox m_comboBoxAlbums;
        private System.Windows.Forms.Button m_buttonPrevoiusPic;
        private System.Windows.Forms.LinkLabel m_LinkLabel_TabProfile_FullName;
        private System.Windows.Forms.PictureBox m_PB_TabProfile_CoverPhoto;
        private System.Windows.Forms.Panel m_Panel_TabProfile;
        private System.Windows.Forms.Label m_Label_TabProfile_About;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label m_Label_TabProfile_Gender;
        private System.Windows.Forms.Label Label_TabProfile_Gender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label m_Label_TabProfile_Lives;
        private System.Windows.Forms.Label Label_TabProfile_LiveinL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_Label_TabProfile_Email;
        private System.Windows.Forms.Label Label_TabProfile_Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_Label_TabProfile_Birth;
        private System.Windows.Forms.Label Label_TabProfile_birth;
        private System.Windows.Forms.Label m_labelPicNumber;
        private System.Windows.Forms.Button m_buttonLogout;
        private System.Windows.Forms.TabPage m_TabMyProfile;
        private UserProfileComponent m_userProfileComponent;
        private System.Windows.Forms.TabPage m_TabFriendsProfile;
        private System.Windows.Forms.Button m_buttonSearchAFriend;
        private System.Windows.Forms.TextBox m_textBoxFriendName;
        private UserProfileComponent m_friendProfileComponent;
        private System.Windows.Forms.Panel m_Panel_Wall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.RichTextBox m_RTB_Wall_Comment;
        private System.Windows.Forms.RichTextBox m_RTB_Wall_Description;
        private System.Windows.Forms.Label m_Label_Wall_Name;
        private System.Windows.Forms.PictureBox m_PB_Wall;
        private System.Windows.Forms.Label m_Label_Wall_Date;
        private System.Windows.Forms.PictureBox m_PB_TabProfile_ProfilePic;
        private System.Windows.Forms.Panel panel_Navigate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}