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
            this.m_TabFeed = new System.Windows.Forms.TabPage();
            this.m_Panel_Wall = new System.Windows.Forms.Panel();
            this.linkLabel_Wall_PostLink = new System.Windows.Forms.LinkLabel();
            this.m_Button_Wall_NextComment = new System.Windows.Forms.Button();
            this.m_Button_Wall_NextPost = new System.Windows.Forms.Button();
            this.label_comments = new System.Windows.Forms.Label();
            this.m_RTB_Wall_Comment = new System.Windows.Forms.RichTextBox();
            this.m_RTB_Wall_Description = new System.Windows.Forms.RichTextBox();
            this.m_Label_Wall_Name = new System.Windows.Forms.Label();
            this.m_PB_Wall = new System.Windows.Forms.PictureBox();
            this.m_Label_Wall_Date = new System.Windows.Forms.Label();
            this.m_PB_TabMain_ProfilePic = new System.Windows.Forms.PictureBox();
            this.panel_Navigate = new System.Windows.Forms.Panel();
            this.button_TabMain_Profile = new System.Windows.Forms.Button();
            this.button_TabMain_Albums = new System.Windows.Forms.Button();
            this.button_TabMain_Friends = new System.Windows.Forms.Button();
            this.m_buttonLogout = new System.Windows.Forms.Button();
            this.m_Panel_TabProfile = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m_Label_TabProfile_About = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_Label_TabMain_Gender = new System.Windows.Forms.Label();
            this.Label_TabMain_Gender = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_Label_TabMain_Lives = new System.Windows.Forms.Label();
            this.Label_TabMain_LiveinL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_Label_TabMain_Email = new System.Windows.Forms.Label();
            this.Label_TabMain_Email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_Label_TabMain_Birth = new System.Windows.Forms.Label();
            this.Label_TabMain_birth = new System.Windows.Forms.Label();
            this.m_LinkLabel_TabMain_FullName = new System.Windows.Forms.LinkLabel();
            this.m_PB_TabMain_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.m_TabAlbums = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_buttonNextPic = new System.Windows.Forms.Button();
            this.m_buttonPrevoiusPic = new System.Windows.Forms.Button();
            this.m_comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.m_TabProfile = new System.Windows.Forms.TabPage();
            this.m_TabFriends = new System.Windows.Forms.TabPage();
            this.m_buttonSearchAFriend = new System.Windows.Forms.Button();
            this.m_textBoxFriendName = new System.Windows.Forms.TextBox();
            this.m_userAlbumPicturesComponent = new View.UserAlbumPicturesComponent();
            this.m_friendProfileComponent = new View.UserProfileComponent();
            this.m_Label_Wall_Comment_Date = new System.Windows.Forms.Label();
            this.m_LinkLabel_Wall_CommentInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_userProfileComponent = new View.UserProfileComponent();
            this.m_tabsControl.SuspendLayout();
            this.m_TabFeed.SuspendLayout();
            this.m_Panel_Wall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_Wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabMain_ProfilePic)).BeginInit();
            this.panel_Navigate.SuspendLayout();
            this.m_Panel_TabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabMain_CoverPhoto)).BeginInit();
            this.m_TabAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_TabProfile.SuspendLayout();
            this.m_TabFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tabsControl
            // 
            this.m_tabsControl.Controls.Add(this.m_TabFeed);
            this.m_tabsControl.Controls.Add(this.m_TabAlbums);
            this.m_tabsControl.Controls.Add(this.m_TabProfile);
            this.m_tabsControl.Controls.Add(this.m_TabFriends);
            this.m_tabsControl.Location = new System.Drawing.Point(2, 12);
            this.m_tabsControl.Name = "m_tabsControl";
            this.m_tabsControl.SelectedIndex = 0;
            this.m_tabsControl.Size = new System.Drawing.Size(1008, 729);
            this.m_tabsControl.TabIndex = 4;
            // 
            // m_TabFeed
            // 
            this.m_TabFeed.AutoScroll = true;
            this.m_TabFeed.BackColor = System.Drawing.Color.Gainsboro;
            this.m_TabFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_TabFeed.Controls.Add(this.m_Panel_Wall);
            this.m_TabFeed.Controls.Add(this.m_PB_TabMain_ProfilePic);
            this.m_TabFeed.Controls.Add(this.panel_Navigate);
            this.m_TabFeed.Controls.Add(this.m_Panel_TabProfile);
            this.m_TabFeed.Controls.Add(this.m_LinkLabel_TabMain_FullName);
            this.m_TabFeed.Controls.Add(this.m_PB_TabMain_CoverPhoto);
            this.m_TabFeed.Location = new System.Drawing.Point(4, 22);
            this.m_TabFeed.Name = "m_TabFeed";
            this.m_TabFeed.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.m_TabFeed.Size = new System.Drawing.Size(1000, 703);
            this.m_TabFeed.TabIndex = 1;
            this.m_TabFeed.Text = "Feed";
            // 
            // m_Panel_Wall
            // 
            this.m_Panel_Wall.AutoSize = true;
            this.m_Panel_Wall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_Panel_Wall.Controls.Add(this.linkLabel_Wall_PostLink);
            this.m_Panel_Wall.Controls.Add(this.m_LinkLabel_Wall_CommentInfo);
            this.m_Panel_Wall.Controls.Add(this.m_Label_Wall_Comment_Date);
            this.m_Panel_Wall.Controls.Add(this.m_Button_Wall_NextComment);
            this.m_Panel_Wall.Controls.Add(this.m_Button_Wall_NextPost);
            this.m_Panel_Wall.Controls.Add(this.label_comments);
            this.m_Panel_Wall.Controls.Add(this.m_RTB_Wall_Comment);
            this.m_Panel_Wall.Controls.Add(this.m_RTB_Wall_Description);
            this.m_Panel_Wall.Controls.Add(this.m_Label_Wall_Name);
            this.m_Panel_Wall.Controls.Add(this.m_PB_Wall);
            this.m_Panel_Wall.Controls.Add(this.m_Label_Wall_Date);
            this.m_Panel_Wall.Location = new System.Drawing.Point(251, 286);
            this.m_Panel_Wall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_Panel_Wall.Name = "m_Panel_Wall";
            this.m_Panel_Wall.Size = new System.Drawing.Size(724, 310);
            this.m_Panel_Wall.TabIndex = 6;
            // 
            // linkLabel_Wall_PostLink
            // 
            this.linkLabel_Wall_PostLink.AutoSize = true;
            this.linkLabel_Wall_PostLink.Location = new System.Drawing.Point(208, 208);
            this.linkLabel_Wall_PostLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Wall_PostLink.Name = "linkLabel_Wall_PostLink";
            this.linkLabel_Wall_PostLink.Size = new System.Drawing.Size(110, 13);
            this.linkLabel_Wall_PostLink.TabIndex = 10;
            this.linkLabel_Wall_PostLink.TabStop = true;
            this.linkLabel_Wall_PostLink.Text = "Open Post In Browser";
            this.linkLabel_Wall_PostLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Wall_PostLink_LinkClicked);
            // 
            // m_Button_Wall_NextComment
            // 
            this.m_Button_Wall_NextComment.Location = new System.Drawing.Point(447, 269);
            this.m_Button_Wall_NextComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_Button_Wall_NextComment.Name = "m_Button_Wall_NextComment";
            this.m_Button_Wall_NextComment.Size = new System.Drawing.Size(186, 25);
            this.m_Button_Wall_NextComment.TabIndex = 7;
            this.m_Button_Wall_NextComment.Text = "Next Comment";
            this.m_Button_Wall_NextComment.UseVisualStyleBackColor = true;
            this.m_Button_Wall_NextComment.Click += new System.EventHandler(this.button_Wall_NextComment_Click);
            // 
            // m_Button_Wall_NextPost
            // 
            this.m_Button_Wall_NextPost.Location = new System.Drawing.Point(82, 223);
            this.m_Button_Wall_NextPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_Button_Wall_NextPost.Name = "m_Button_Wall_NextPost";
            this.m_Button_Wall_NextPost.Size = new System.Drawing.Size(186, 25);
            this.m_Button_Wall_NextPost.TabIndex = 6;
            this.m_Button_Wall_NextPost.Text = "Next Post";
            this.m_Button_Wall_NextPost.UseVisualStyleBackColor = true;
            this.m_Button_Wall_NextPost.Click += new System.EventHandler(this.button_Wall_NextPost_Click);
            // 
            // label_comments
            // 
            this.label_comments.AutoSize = true;
            this.label_comments.Location = new System.Drawing.Point(361, 194);
            this.label_comments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(59, 13);
            this.label_comments.TabIndex = 5;
            this.label_comments.Text = "Comments:";
            // 
            // m_RTB_Wall_Comment
            // 
            this.m_RTB_Wall_Comment.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_RTB_Wall_Comment.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.m_RTB_Wall_Comment.Location = new System.Drawing.Point(364, 209);
            this.m_RTB_Wall_Comment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_RTB_Wall_Comment.Name = "m_RTB_Wall_Comment";
            this.m_RTB_Wall_Comment.Size = new System.Drawing.Size(351, 56);
            this.m_RTB_Wall_Comment.TabIndex = 4;
            this.m_RTB_Wall_Comment.Text = "";
            // 
            // m_RTB_Wall_Description
            // 
            this.m_RTB_Wall_Description.Location = new System.Drawing.Point(364, 26);
            this.m_RTB_Wall_Description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_RTB_Wall_Description.Name = "m_RTB_Wall_Description";
            this.m_RTB_Wall_Description.Size = new System.Drawing.Size(351, 159);
            this.m_RTB_Wall_Description.TabIndex = 3;
            this.m_RTB_Wall_Description.Text = "";
            // 
            // m_Label_Wall_Name
            // 
            this.m_Label_Wall_Name.AutoSize = true;
            this.m_Label_Wall_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.m_Label_Wall_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Wall_Name.Location = new System.Drawing.Point(360, 5);
            this.m_Label_Wall_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_Label_Wall_Name.Name = "m_Label_Wall_Name";
            this.m_Label_Wall_Name.Size = new System.Drawing.Size(41, 19);
            this.m_Label_Wall_Name.TabIndex = 2;
            this.m_Label_Wall_Name.Text = "Title";
            // 
            // m_PB_Wall
            // 
            this.m_PB_Wall.Location = new System.Drawing.Point(34, 25);
            this.m_PB_Wall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_PB_Wall.Name = "m_PB_Wall";
            this.m_PB_Wall.Size = new System.Drawing.Size(284, 177);
            this.m_PB_Wall.TabIndex = 1;
            this.m_PB_Wall.TabStop = false;
            // 
            // m_Label_Wall_Date
            // 
            this.m_Label_Wall_Date.AutoSize = true;
            this.m_Label_Wall_Date.BackColor = System.Drawing.Color.SkyBlue;
            this.m_Label_Wall_Date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_Wall_Date.Location = new System.Drawing.Point(31, 5);
            this.m_Label_Wall_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_Label_Wall_Date.Name = "m_Label_Wall_Date";
            this.m_Label_Wall_Date.Size = new System.Drawing.Size(70, 18);
            this.m_Label_Wall_Date.TabIndex = 0;
            this.m_Label_Wall_Date.Text = "00/00/00";
            // 
            // m_PB_TabMain_ProfilePic
            // 
            this.m_PB_TabMain_ProfilePic.Location = new System.Drawing.Point(19, 72);
            this.m_PB_TabMain_ProfilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_PB_TabMain_ProfilePic.Name = "m_PB_TabMain_ProfilePic";
            this.m_PB_TabMain_ProfilePic.Size = new System.Drawing.Size(209, 204);
            this.m_PB_TabMain_ProfilePic.TabIndex = 5;
            this.m_PB_TabMain_ProfilePic.TabStop = false;
            // 
            // panel_Navigate
            // 
            this.panel_Navigate.BackColor = System.Drawing.Color.White;
            this.panel_Navigate.Controls.Add(this.button_TabMain_Profile);
            this.panel_Navigate.Controls.Add(this.button_TabMain_Albums);
            this.panel_Navigate.Controls.Add(this.button_TabMain_Friends);
            this.panel_Navigate.Controls.Add(this.m_buttonLogout);
            this.panel_Navigate.Location = new System.Drawing.Point(5, 246);
            this.panel_Navigate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Navigate.Name = "panel_Navigate";
            this.panel_Navigate.Size = new System.Drawing.Size(970, 35);
            this.panel_Navigate.TabIndex = 4;
            // 
            // button_TabMain_Profile
            // 
            this.button_TabMain_Profile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabMain_Profile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabMain_Profile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabMain_Profile.Location = new System.Drawing.Point(568, 5);
            this.button_TabMain_Profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabMain_Profile.Name = "button_TabMain_Profile";
            this.button_TabMain_Profile.Size = new System.Drawing.Size(158, 30);
            this.button_TabMain_Profile.TabIndex = 7;
            this.button_TabMain_Profile.Text = "Profile ";
            this.button_TabMain_Profile.UseVisualStyleBackColor = false;
            this.button_TabMain_Profile.Click += new System.EventHandler(this.button_TabMain_Profile_Click);
            // 
            // button_TabMain_Albums
            // 
            this.button_TabMain_Albums.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabMain_Albums.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabMain_Albums.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabMain_Albums.Location = new System.Drawing.Point(406, 5);
            this.button_TabMain_Albums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabMain_Albums.Name = "button_TabMain_Albums";
            this.button_TabMain_Albums.Size = new System.Drawing.Size(158, 30);
            this.button_TabMain_Albums.TabIndex = 6;
            this.button_TabMain_Albums.Text = "Albums";
            this.button_TabMain_Albums.UseVisualStyleBackColor = false;
            this.button_TabMain_Albums.Click += new System.EventHandler(this.button_TabMain_Albums_Click);
            // 
            // button_TabMain_Friends
            // 
            this.button_TabMain_Friends.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabMain_Friends.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabMain_Friends.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabMain_Friends.Location = new System.Drawing.Point(246, 5);
            this.button_TabMain_Friends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabMain_Friends.Name = "button_TabMain_Friends";
            this.button_TabMain_Friends.Size = new System.Drawing.Size(158, 30);
            this.button_TabMain_Friends.TabIndex = 5;
            this.button_TabMain_Friends.Text = "Friends";
            this.button_TabMain_Friends.UseVisualStyleBackColor = false;
            this.button_TabMain_Friends.Click += new System.EventHandler(this.button_TabMain_Friends_Click);
            // 
            // m_buttonLogout
            // 
            this.m_buttonLogout.Location = new System.Drawing.Point(846, 5);
            this.m_buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_buttonLogout.Name = "m_buttonLogout";
            this.m_buttonLogout.Size = new System.Drawing.Size(122, 25);
            this.m_buttonLogout.TabIndex = 4;
            this.m_buttonLogout.Text = "Logout";
            this.m_buttonLogout.UseVisualStyleBackColor = true;
            this.m_buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            this.m_Panel_TabProfile.Location = new System.Drawing.Point(6, 286);
            this.m_Panel_TabProfile.Name = "m_Panel_TabProfile";
            this.m_Panel_TabProfile.Size = new System.Drawing.Size(240, 231);
            this.m_Panel_TabProfile.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(10, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // m_Label_TabProfile_About
            // 
            this.m_Label_TabProfile_About.AutoSize = true;
            this.m_Label_TabProfile_About.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Label_TabProfile_About.Location = new System.Drawing.Point(58, 12);
            this.m_Label_TabProfile_About.Name = "m_Label_TabProfile_About";
            this.m_Label_TabProfile_About.Size = new System.Drawing.Size(53, 22);
            this.m_Label_TabProfile_About.TabIndex = 5;
            this.m_Label_TabProfile_About.Text = "Intro";
            this.m_Label_TabProfile_About.Click += new System.EventHandler(this.label_TabProfile_About_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_Label_TabMain_Gender);
            this.panel5.Controls.Add(this.Label_TabMain_Gender);
            this.panel5.Location = new System.Drawing.Point(10, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 34);
            this.panel5.TabIndex = 4;
            // 
            // m_Label_TabMain_Gender
            // 
            this.m_Label_TabMain_Gender.AutoSize = true;
            this.m_Label_TabMain_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_TabMain_Gender.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.m_Label_TabMain_Gender.Location = new System.Drawing.Point(76, 14);
            this.m_Label_TabMain_Gender.Name = "m_Label_TabMain_Gender";
            this.m_Label_TabMain_Gender.Size = new System.Drawing.Size(35, 15);
            this.m_Label_TabMain_Gender.TabIndex = 1;
            this.m_Label_TabMain_Gender.Text = "male";
            // 
            // Label_TabMain_Gender
            // 
            this.Label_TabMain_Gender.AutoSize = true;
            this.Label_TabMain_Gender.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TabMain_Gender.Location = new System.Drawing.Point(3, 11);
            this.Label_TabMain_Gender.Name = "Label_TabMain_Gender";
            this.Label_TabMain_Gender.Size = new System.Drawing.Size(61, 16);
            this.Label_TabMain_Gender.TabIndex = 0;
            this.Label_TabMain_Gender.Text = "Gender";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_Label_TabMain_Lives);
            this.panel4.Controls.Add(this.Label_TabMain_LiveinL);
            this.panel4.Location = new System.Drawing.Point(10, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 34);
            this.panel4.TabIndex = 3;
            // 
            // m_Label_TabMain_Lives
            // 
            this.m_Label_TabMain_Lives.AutoSize = true;
            this.m_Label_TabMain_Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_TabMain_Lives.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.m_Label_TabMain_Lives.Location = new System.Drawing.Point(76, 15);
            this.m_Label_TabMain_Lives.Name = "m_Label_TabMain_Lives";
            this.m_Label_TabMain_Lives.Size = new System.Drawing.Size(83, 15);
            this.m_Label_TabMain_Lives.TabIndex = 1;
            this.m_Label_TabMain_Lives.Text = "Tel Aviv, Israel";
            // 
            // Label_TabMain_LiveinL
            // 
            this.Label_TabMain_LiveinL.AutoSize = true;
            this.Label_TabMain_LiveinL.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_TabMain_LiveinL.Location = new System.Drawing.Point(3, 14);
            this.Label_TabMain_LiveinL.Name = "Label_TabMain_LiveinL";
            this.Label_TabMain_LiveinL.Size = new System.Drawing.Size(63, 16);
            this.Label_TabMain_LiveinL.TabIndex = 0;
            this.Label_TabMain_LiveinL.Text = "Lives In";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_Label_TabMain_Email);
            this.panel3.Controls.Add(this.Label_TabMain_Email);
            this.panel3.Location = new System.Drawing.Point(10, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 34);
            this.panel3.TabIndex = 2;
            // 
            // m_Label_TabMain_Email
            // 
            this.m_Label_TabMain_Email.AutoSize = true;
            this.m_Label_TabMain_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_TabMain_Email.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.m_Label_TabMain_Email.Location = new System.Drawing.Point(76, 13);
            this.m_Label_TabMain_Email.Name = "m_Label_TabMain_Email";
            this.m_Label_TabMain_Email.Size = new System.Drawing.Size(77, 15);
            this.m_Label_TabMain_Email.TabIndex = 1;
            this.m_Label_TabMain_Email.Text = "0527212121";
            // 
            // Label_TabMain_Email
            // 
            this.Label_TabMain_Email.AutoSize = true;
            this.Label_TabMain_Email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TabMain_Email.Location = new System.Drawing.Point(2, 11);
            this.Label_TabMain_Email.Name = "Label_TabMain_Email";
            this.Label_TabMain_Email.Size = new System.Drawing.Size(45, 16);
            this.Label_TabMain_Email.TabIndex = 0;
            this.Label_TabMain_Email.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_Label_TabMain_Birth);
            this.panel2.Controls.Add(this.Label_TabMain_birth);
            this.panel2.Location = new System.Drawing.Point(10, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 34);
            this.panel2.TabIndex = 0;
            // 
            // m_Label_TabMain_Birth
            // 
            this.m_Label_TabMain_Birth.AutoSize = true;
            this.m_Label_TabMain_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Label_TabMain_Birth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.m_Label_TabMain_Birth.Location = new System.Drawing.Point(76, 14);
            this.m_Label_TabMain_Birth.Name = "m_Label_TabMain_Birth";
            this.m_Label_TabMain_Birth.Size = new System.Drawing.Size(59, 15);
            this.m_Label_TabMain_Birth.TabIndex = 1;
            this.m_Label_TabMain_Birth.Text = "dd/mm/yy";
            // 
            // Label_TabMain_birth
            // 
            this.Label_TabMain_birth.AutoSize = true;
            this.Label_TabMain_birth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TabMain_birth.Location = new System.Drawing.Point(3, 11);
            this.Label_TabMain_birth.Name = "Label_TabMain_birth";
            this.Label_TabMain_birth.Size = new System.Drawing.Size(66, 16);
            this.Label_TabMain_birth.TabIndex = 0;
            this.Label_TabMain_birth.Text = "Birthday";
            // 
            // m_LinkLabel_TabMain_FullName
            // 
            this.m_LinkLabel_TabMain_FullName.AutoSize = true;
            this.m_LinkLabel_TabMain_FullName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LinkLabel_TabMain_FullName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.m_LinkLabel_TabMain_FullName.LinkColor = System.Drawing.Color.White;
            this.m_LinkLabel_TabMain_FullName.Location = new System.Drawing.Point(243, 191);
            this.m_LinkLabel_TabMain_FullName.Name = "m_LinkLabel_TabMain_FullName";
            this.m_LinkLabel_TabMain_FullName.Size = new System.Drawing.Size(128, 29);
            this.m_LinkLabel_TabMain_FullName.TabIndex = 2;
            this.m_LinkLabel_TabMain_FullName.TabStop = true;
            this.m_LinkLabel_TabMain_FullName.Text = "Full Name";
            this.m_LinkLabel_TabMain_FullName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TabMain_FullName_LinkClicked);
            // 
            // m_PB_TabMain_CoverPhoto
            // 
            this.m_PB_TabMain_CoverPhoto.Location = new System.Drawing.Point(-4, 6);
            this.m_PB_TabMain_CoverPhoto.Name = "m_PB_TabMain_CoverPhoto";
            this.m_PB_TabMain_CoverPhoto.Size = new System.Drawing.Size(979, 236);
            this.m_PB_TabMain_CoverPhoto.TabIndex = 0;
            this.m_PB_TabMain_CoverPhoto.TabStop = false;
            // 
            // m_TabAlbums
            // 
            this.m_TabAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.m_TabAlbums.Controls.Add(this.pictureBox2);
            this.m_TabAlbums.Controls.Add(this.pictureBox1);
            this.m_TabAlbums.Controls.Add(this.m_buttonNextPic);
            this.m_TabAlbums.Controls.Add(this.m_buttonPrevoiusPic);
            this.m_TabAlbums.Controls.Add(this.m_comboBoxAlbums);
            this.m_TabAlbums.Controls.Add(this.m_userAlbumPicturesComponent);
            this.m_TabAlbums.Location = new System.Drawing.Point(4, 22);
            this.m_TabAlbums.Name = "m_TabAlbums";
            this.m_TabAlbums.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.m_TabAlbums.Size = new System.Drawing.Size(1000, 703);
            this.m_TabAlbums.TabIndex = 2;
            this.m_TabAlbums.Text = "Albums";
            this.m_TabAlbums.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // m_buttonNextPic
            // 
            this.m_buttonNextPic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_buttonNextPic.Enabled = false;
            this.m_buttonNextPic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_buttonNextPic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.m_buttonNextPic.Location = new System.Drawing.Point(563, 513);
            this.m_buttonNextPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_buttonNextPic.Name = "m_buttonNextPic";
            this.m_buttonNextPic.Size = new System.Drawing.Size(158, 41);
            this.m_buttonNextPic.TabIndex = 7;
            this.m_buttonNextPic.Text = "Next";
            this.m_buttonNextPic.UseVisualStyleBackColor = false;
            this.m_buttonNextPic.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // m_buttonPrevoiusPic
            // 
            this.m_buttonPrevoiusPic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_buttonPrevoiusPic.Enabled = false;
            this.m_buttonPrevoiusPic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_buttonPrevoiusPic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.m_buttonPrevoiusPic.Location = new System.Drawing.Point(283, 513);
            this.m_buttonPrevoiusPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_buttonPrevoiusPic.Name = "m_buttonPrevoiusPic";
            this.m_buttonPrevoiusPic.Size = new System.Drawing.Size(158, 41);
            this.m_buttonPrevoiusPic.TabIndex = 6;
            this.m_buttonPrevoiusPic.Text = "Previous";
            this.m_buttonPrevoiusPic.UseVisualStyleBackColor = false;
            this.m_buttonPrevoiusPic.Click += new System.EventHandler(this.m_buttonPrevoiusPic_Click);
            // 
            // m_comboBoxAlbums
            // 
            this.m_comboBoxAlbums.FormattingEnabled = true;
            this.m_comboBoxAlbums.Location = new System.Drawing.Point(394, 110);
            this.m_comboBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_comboBoxAlbums.Name = "m_comboBoxAlbums";
            this.m_comboBoxAlbums.Size = new System.Drawing.Size(198, 21);
            this.m_comboBoxAlbums.TabIndex = 0;
            this.m_comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxAlbums_SelectedIndexChanged);
            // 
            // m_TabProfile
            // 
            this.m_TabProfile.Controls.Add(this.m_userProfileComponent);
            this.m_TabProfile.Location = new System.Drawing.Point(4, 22);
            this.m_TabProfile.Name = "m_TabProfile";
            this.m_TabProfile.Size = new System.Drawing.Size(1000, 703);
            this.m_TabProfile.TabIndex = 3;
            this.m_TabProfile.Text = "Profile";
            this.m_TabProfile.UseVisualStyleBackColor = true;
            // 
            // m_TabFriends
            // 
            this.m_TabFriends.Controls.Add(this.m_buttonSearchAFriend);
            this.m_TabFriends.Controls.Add(this.m_textBoxFriendName);
            this.m_TabFriends.Controls.Add(this.m_friendProfileComponent);
            this.m_TabFriends.ForeColor = System.Drawing.SystemColors.ControlText;
            this.m_TabFriends.Location = new System.Drawing.Point(4, 22);
            this.m_TabFriends.Name = "m_TabFriends";
            this.m_TabFriends.Size = new System.Drawing.Size(1000, 703);
            this.m_TabFriends.TabIndex = 4;
            this.m_TabFriends.Text = "Friends";
            this.m_TabFriends.UseVisualStyleBackColor = true;
            // 
            // m_buttonSearchAFriend
            // 
            this.m_buttonSearchAFriend.BackColor = System.Drawing.Color.DodgerBlue;
            this.m_buttonSearchAFriend.ForeColor = System.Drawing.SystemColors.Window;
            this.m_buttonSearchAFriend.Location = new System.Drawing.Point(199, 6);
            this.m_buttonSearchAFriend.Name = "m_buttonSearchAFriend";
            this.m_buttonSearchAFriend.Size = new System.Drawing.Size(75, 23);
            this.m_buttonSearchAFriend.TabIndex = 2;
            this.m_buttonSearchAFriend.Text = "Search";
            this.m_buttonSearchAFriend.UseVisualStyleBackColor = false;
            this.m_buttonSearchAFriend.Click += new System.EventHandler(this.button_SearchAFriend_Click);
            // 
            // m_textBoxFriendName
            // 
            this.m_textBoxFriendName.Location = new System.Drawing.Point(4, 6);
            this.m_textBoxFriendName.Name = "m_textBoxFriendName";
            this.m_textBoxFriendName.Size = new System.Drawing.Size(189, 20);
            this.m_textBoxFriendName.TabIndex = 1;
            this.m_textBoxFriendName.Text = "What\'s your friend\'s name?";
            this.m_textBoxFriendName.Click += new System.EventHandler(this.textBoxFriendName_Click);
            // 
            // m_userAlbumPicturesComponent
            // 
            this.m_userAlbumPicturesComponent.Location = new System.Drawing.Point(97, 154);
            this.m_userAlbumPicturesComponent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_userAlbumPicturesComponent.Name = "m_userAlbumPicturesComponent";
            this.m_userAlbumPicturesComponent.Size = new System.Drawing.Size(822, 355);
            this.m_userAlbumPicturesComponent.TabIndex = 4;
            // 
            // m_friendProfileComponent
            // 
            this.m_friendProfileComponent.Location = new System.Drawing.Point(0, 31);
            this.m_friendProfileComponent.Margin = new System.Windows.Forms.Padding(2);
            this.m_friendProfileComponent.Name = "m_friendProfileComponent";
            this.m_friendProfileComponent.Size = new System.Drawing.Size(978, 566);
            this.m_friendProfileComponent.TabIndex = 0;
            // 
            // m_Label_Wall_Comment_Date
            // 
            this.m_Label_Wall_Comment_Date.AutoSize = true;
            this.m_Label_Wall_Comment_Date.Location = new System.Drawing.Point(607, 194);
            this.m_Label_Wall_Comment_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_Label_Wall_Comment_Date.Name = "m_Label_Wall_Comment_Date";
            this.m_Label_Wall_Comment_Date.Size = new System.Drawing.Size(59, 13);
            this.m_Label_Wall_Comment_Date.TabIndex = 8;
            this.m_Label_Wall_Comment_Date.Text = "Comments:";
            // 
            // m_LinkLabel_Wall_CommentInfo
            // 
            this.m_LinkLabel_Wall_CommentInfo.AutoSize = true;
            this.m_LinkLabel_Wall_CommentInfo.Location = new System.Drawing.Point(31, 266);
            this.m_LinkLabel_Wall_CommentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LinkLabel_Wall_CommentInfo.Name = "m_LinkLabel_Wall_CommentInfo";
            this.m_LinkLabel_Wall_CommentInfo.Size = new System.Drawing.Size(133, 13);
            this.m_LinkLabel_Wall_CommentInfo.TabIndex = 9;
            this.m_LinkLabel_Wall_CommentInfo.TabStop = true;
            this.m_LinkLabel_Wall_CommentInfo.Text = "Show More info in Browser";
            this.m_LinkLabel_Wall_CommentInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Wall_CommentInfo_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // m_userProfileComponent
            // 
            this.m_userProfileComponent.Location = new System.Drawing.Point(0, 2);
            this.m_userProfileComponent.Margin = new System.Windows.Forms.Padding(2);
            this.m_userProfileComponent.Name = "m_userProfileComponent";
            this.m_userProfileComponent.Size = new System.Drawing.Size(978, 566);
            this.m_userProfileComponent.TabIndex = 0;
            // 
            // DesktopFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 632);
            this.Controls.Add(this.m_tabsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesktopFacebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook For Desktop!";
            this.m_tabsControl.ResumeLayout(false);
            this.m_TabFeed.ResumeLayout(false);
            this.m_TabFeed.PerformLayout();
            this.m_Panel_Wall.ResumeLayout(false);
            this.m_Panel_Wall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_Wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabMain_ProfilePic)).EndInit();
            this.panel_Navigate.ResumeLayout(false);
            this.m_Panel_TabProfile.ResumeLayout(false);
            this.m_Panel_TabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PB_TabMain_CoverPhoto)).EndInit();
            this.m_TabAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_TabProfile.ResumeLayout(false);
            this.m_TabFriends.ResumeLayout(false);
            this.m_TabFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl m_tabsControl;
        private System.Windows.Forms.TabPage m_TabFeed;
        private System.Windows.Forms.TabPage m_TabAlbums;
        private System.Windows.Forms.ComboBox m_comboBoxAlbums;
        private System.Windows.Forms.LinkLabel m_LinkLabel_TabMain_FullName;
        private System.Windows.Forms.PictureBox m_PB_TabMain_CoverPhoto;
        private System.Windows.Forms.Panel m_Panel_TabProfile;
        private System.Windows.Forms.Label m_Label_TabProfile_About;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label m_Label_TabMain_Gender;
        private System.Windows.Forms.Label Label_TabMain_Gender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label m_Label_TabMain_Lives;
        private System.Windows.Forms.Label Label_TabMain_LiveinL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_Label_TabMain_Email;
        private System.Windows.Forms.Label Label_TabMain_Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_Label_TabMain_Birth;
        private System.Windows.Forms.Label Label_TabMain_birth;
        private System.Windows.Forms.Button m_buttonLogout;
        private System.Windows.Forms.TabPage m_TabProfile;
        private System.Windows.Forms.TabPage m_TabFriends;
        private System.Windows.Forms.Button m_buttonSearchAFriend;
        private System.Windows.Forms.TextBox m_textBoxFriendName;
        private UserProfileComponent m_friendProfileComponent;
        private System.Windows.Forms.Panel m_Panel_Wall;
        private System.Windows.Forms.Button m_Button_Wall_NextComment;
        private System.Windows.Forms.Button m_Button_Wall_NextPost;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.RichTextBox m_RTB_Wall_Comment;
        private System.Windows.Forms.RichTextBox m_RTB_Wall_Description;
        private System.Windows.Forms.Label m_Label_Wall_Name;
        private System.Windows.Forms.PictureBox m_PB_Wall;
        private System.Windows.Forms.Label m_Label_Wall_Date;
        private System.Windows.Forms.PictureBox m_PB_TabMain_ProfilePic;
        private System.Windows.Forms.Panel panel_Navigate;
        private System.Windows.Forms.Button button_TabMain_Profile;
        private System.Windows.Forms.Button button_TabMain_Albums;
        private System.Windows.Forms.Button button_TabMain_Friends;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel_Wall_PostLink;
        private UserAlbumPicturesComponent m_userAlbumPicturesComponent;
        private System.Windows.Forms.Button m_buttonNextPic;
        private System.Windows.Forms.Button m_buttonPrevoiusPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label m_Label_Wall_Comment_Date;
        private System.Windows.Forms.LinkLabel m_LinkLabel_Wall_CommentInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UserProfileComponent m_userProfileComponent;
    }
}