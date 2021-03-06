﻿using System.Windows.Forms;
using View.AssistiveComponents;

namespace View
{
    public partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPage_Feed = new System.Windows.Forms.TabPage();
            this.panel_TabFeed_Posts = new System.Windows.Forms.Panel();
            this.linkLabel_TabFeed_OpenPostInBrowser = new System.Windows.Forms.LinkLabel();
            this.linkLabel_TabFeed_PostInfo = new System.Windows.Forms.LinkLabel();
            this.label_TabFeed_CommentDate = new System.Windows.Forms.Label();
            this.button_TabFeed_NextComment = new System.Windows.Forms.Button();
            this.button_TabFeed_NextPost = new System.Windows.Forms.Button();
            this.label_TabFeed_Comments = new System.Windows.Forms.Label();
            this.richTextBox_TabFeed_CommentText = new System.Windows.Forms.RichTextBox();
            this.richTextBox_TabFeed_PostDescription = new System.Windows.Forms.RichTextBox();
            this.label_TabFeed_PostName = new System.Windows.Forms.Label();
            this.pictureBox_TabFeed_PostPic = new System.Windows.Forms.PictureBox();
            this.label_TabFeed_PostDate = new System.Windows.Forms.Label();
            this.pictureBox_TabFeed_ProfilePic = new System.Windows.Forms.PictureBox();
            this.panel_TabFeed_Navigate = new System.Windows.Forms.Panel();
            this.button_TabFeed_Feature2 = new System.Windows.Forms.Button();
            this.button_TabFeed_FaceRide = new System.Windows.Forms.Button();
            this.button_TabFeed_Profile = new System.Windows.Forms.Button();
            this.button_TabFeed_Albums = new System.Windows.Forms.Button();
            this.button_TabFeed_Friends = new System.Windows.Forms.Button();
            this.button_TabFeed_Logout = new System.Windows.Forms.Button();
            this.panel_TabFeed_Intro = new System.Windows.Forms.Panel();
            this.pictureBox_TabFeed_IntroPic = new System.Windows.Forms.PictureBox();
            this.label_TabFeed_Intro = new System.Windows.Forms.Label();
            this.panel_TabFeed_Gender = new System.Windows.Forms.Panel();
            this.label_TabMain_Gender = new System.Windows.Forms.Label();
            this.label_TabFeed_Gender2 = new System.Windows.Forms.Label();
            this.panel_TabFeed_LivesIn = new System.Windows.Forms.Panel();
            this.label_TabFeed_LivesIn = new System.Windows.Forms.Label();
            this.label_TabFeed_LivesIn2 = new System.Windows.Forms.Label();
            this.panel_TabFeed_Email = new System.Windows.Forms.Panel();
            this.label_TabFeed_Email = new System.Windows.Forms.Label();
            this.label_TabFeed_Email2 = new System.Windows.Forms.Label();
            this.panel_TabFeed_Birthday = new System.Windows.Forms.Panel();
            this.label_TabFeed_Birthday = new System.Windows.Forms.Label();
            this.label_TabFeed_Birthday2 = new System.Windows.Forms.Label();
            this.linkLabel_TabFeed_FullName = new System.Windows.Forms.LinkLabel();
            this.pictureBox_TabFeed_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.tabPage_Albums = new System.Windows.Forms.TabPage();
            this.comboBox_TabAlbums_AlbumsList = new System.Windows.Forms.ComboBox();
            this.AlbumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox_TabAlbums_FacebookLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox_TabAlbums_ChooseYourAlbum = new System.Windows.Forms.PictureBox();
            this.button_TabAlbums_Next = new System.Windows.Forms.Button();
            this.button_TabAlbums_Prevoius = new System.Windows.Forms.Button();
            this.tabPage_Profile = new System.Windows.Forms.TabPage();
            this.tabPage_Friends = new System.Windows.Forms.TabPage();
            this.textBox_TabFriends_FriendName = new System.Windows.Forms.TextBox();
            this.button_TabFriends_Search = new System.Windows.Forms.Button();
            this.tabPage_FaceRide = new System.Windows.Forms.TabPage();
            this.linkLabel_TabFaceRide_GetFromEvent = new System.Windows.Forms.LinkLabel();
            this.textBox_TabFaceRide_Km = new System.Windows.Forms.TextBox();
            this.pictureBox_TabFaceRide_Location = new System.Windows.Forms.PictureBox();
            this.linkLabel_TabFaceRide_ShowOnMap = new System.Windows.Forms.LinkLabel();
            this.comboBox_TabFaceRide_Radius = new System.Windows.Forms.ComboBox();
            this.checkBox_TabFaceRide_Female = new System.Windows.Forms.CheckBox();
            this.linkLabel_TabFaceRide_CurrentLocation = new System.Windows.Forms.LinkLabel();
            this.richTextBox_TabFaceRide_WhereFrom = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_TabFaceRide_Male = new System.Windows.Forms.CheckBox();
            this.pictureBox_TabFaceRide_Location2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_TabFaceRide_Radius = new System.Windows.Forms.PictureBox();
            this.pictureBox_TabFaceRide_Destination = new System.Windows.Forms.PictureBox();
            this.button_TabFaceRide_LetsRide = new System.Windows.Forms.Button();
            this.richTextBox_TabFaceRide_WhereTo = new System.Windows.Forms.RichTextBox();
            this.pictureBox_TabFaceRide_subTitle = new System.Windows.Forms.PictureBox();
            this.pictureBox_TabFaceRide_Title = new System.Windows.Forms.PictureBox();
            this.pictureBox_TabFaceRide_FacebookLogo = new System.Windows.Forms.PictureBox();
            this.tabPage_Contacts = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_TabContacts = new System.Windows.Forms.Panel();
            this.button_TabContacts_Save = new System.Windows.Forms.Button();
            this.button_TabContacts_DisplayContacts = new System.Windows.Forms.Button();
            this.webBrowser_TabContacts = new System.Windows.Forms.WebBrowser();
            this.dataGridView_TabContacts = new System.Windows.Forms.DataGridView();
            this.buttonSlideShow = new System.Windows.Forms.Button();
            this.tabsControl.SuspendLayout();
            this.tabPage_Feed.SuspendLayout();
            this.panel_TabFeed_Posts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_PostPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_ProfilePic)).BeginInit();
            this.panel_TabFeed_Navigate.SuspendLayout();
            this.panel_TabFeed_Intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_IntroPic)).BeginInit();
            this.panel_TabFeed_Gender.SuspendLayout();
            this.panel_TabFeed_LivesIn.SuspendLayout();
            this.panel_TabFeed_Email.SuspendLayout();
            this.panel_TabFeed_Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_CoverPhoto)).BeginInit();
            this.tabPage_Albums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabAlbums_FacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabAlbums_ChooseYourAlbum)).BeginInit();
            this.tabPage_Friends.SuspendLayout();
            this.tabPage_FaceRide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Location2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Destination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_subTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_FacebookLogo)).BeginInit();
            this.tabPage_Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_TabContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabsControl.Controls.Add(this.tabPage_Feed);
            this.tabsControl.Controls.Add(this.tabPage_Albums);
            this.tabsControl.Controls.Add(this.tabPage_Profile);
            this.tabsControl.Controls.Add(this.tabPage_Friends);
            this.tabsControl.Controls.Add(this.tabPage_FaceRide);
            this.tabsControl.Controls.Add(this.tabPage_Contacts);
            this.tabsControl.Location = new System.Drawing.Point(10, 10);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(784, 687);
            this.tabsControl.TabIndex = 4;
            // 
            // tabPage_Feed
            // 
            this.tabPage_Feed.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_Feed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Feed.Controls.Add(this.panel_TabFeed_Posts);
            this.tabPage_Feed.Controls.Add(this.pictureBox_TabFeed_ProfilePic);
            this.tabPage_Feed.Controls.Add(this.panel_TabFeed_Navigate);
            this.tabPage_Feed.Controls.Add(this.panel_TabFeed_Intro);
            this.tabPage_Feed.Controls.Add(this.linkLabel_TabFeed_FullName);
            this.tabPage_Feed.Controls.Add(this.pictureBox_TabFeed_CoverPhoto);
            this.tabPage_Feed.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Feed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Feed.Name = "tabPage_Feed";
            this.tabPage_Feed.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Feed.Size = new System.Drawing.Size(776, 661);
            this.tabPage_Feed.TabIndex = 1;
            this.tabPage_Feed.Text = "Feed";
            // 
            // panel_TabFeed_Posts
            // 
            this.panel_TabFeed_Posts.AutoSize = true;
            this.panel_TabFeed_Posts.BackColor = System.Drawing.Color.White;
            this.panel_TabFeed_Posts.Controls.Add(this.linkLabel_TabFeed_OpenPostInBrowser);
            this.panel_TabFeed_Posts.Controls.Add(this.linkLabel_TabFeed_PostInfo);
            this.panel_TabFeed_Posts.Controls.Add(this.label_TabFeed_CommentDate);
            this.panel_TabFeed_Posts.Controls.Add(this.button_TabFeed_NextComment);
            this.panel_TabFeed_Posts.Controls.Add(this.button_TabFeed_NextPost);
            this.panel_TabFeed_Posts.Controls.Add(this.label_TabFeed_Comments);
            this.panel_TabFeed_Posts.Controls.Add(this.richTextBox_TabFeed_CommentText);
            this.panel_TabFeed_Posts.Controls.Add(this.richTextBox_TabFeed_PostDescription);
            this.panel_TabFeed_Posts.Controls.Add(this.label_TabFeed_PostName);
            this.panel_TabFeed_Posts.Controls.Add(this.pictureBox_TabFeed_PostPic);
            this.panel_TabFeed_Posts.Controls.Add(this.label_TabFeed_PostDate);
            this.panel_TabFeed_Posts.Location = new System.Drawing.Point(199, 334);
            this.panel_TabFeed_Posts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_TabFeed_Posts.Name = "panel_TabFeed_Posts";
            this.panel_TabFeed_Posts.Size = new System.Drawing.Size(574, 330);
            this.panel_TabFeed_Posts.TabIndex = 6;
            // 
            // linkLabel_TabFeed_OpenPostInBrowser
            // 
            this.linkLabel_TabFeed_OpenPostInBrowser.AutoSize = true;
            this.linkLabel_TabFeed_OpenPostInBrowser.Location = new System.Drawing.Point(224, 218);
            this.linkLabel_TabFeed_OpenPostInBrowser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFeed_OpenPostInBrowser.Name = "linkLabel_TabFeed_OpenPostInBrowser";
            this.linkLabel_TabFeed_OpenPostInBrowser.Size = new System.Drawing.Size(110, 13);
            this.linkLabel_TabFeed_OpenPostInBrowser.TabIndex = 10;
            this.linkLabel_TabFeed_OpenPostInBrowser.TabStop = true;
            this.linkLabel_TabFeed_OpenPostInBrowser.Text = "Open Post In Browser";
            this.linkLabel_TabFeed_OpenPostInBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFeed_linkLabelPostLink_Click);
            // 
            // linkLabel_TabFeed_PostInfo
            // 
            this.linkLabel_TabFeed_PostInfo.AutoSize = true;
            this.linkLabel_TabFeed_PostInfo.Location = new System.Drawing.Point(4, 307);
            this.linkLabel_TabFeed_PostInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFeed_PostInfo.Name = "linkLabel_TabFeed_PostInfo";
            this.linkLabel_TabFeed_PostInfo.Size = new System.Drawing.Size(133, 13);
            this.linkLabel_TabFeed_PostInfo.TabIndex = 9;
            this.linkLabel_TabFeed_PostInfo.TabStop = true;
            this.linkLabel_TabFeed_PostInfo.Text = "Show More info in Browser";
            this.linkLabel_TabFeed_PostInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFeed_linkLabelCommentInfo_Click);
            // 
            // label_TabFeed_CommentDate
            // 
            this.label_TabFeed_CommentDate.AutoSize = true;
            this.label_TabFeed_CommentDate.Location = new System.Drawing.Point(98, 214);
            this.label_TabFeed_CommentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_CommentDate.Name = "label_TabFeed_CommentDate";
            this.label_TabFeed_CommentDate.Size = new System.Drawing.Size(59, 13);
            this.label_TabFeed_CommentDate.TabIndex = 8;
            this.label_TabFeed_CommentDate.Text = "Comments:";
            // 
            // button_TabFeed_NextComment
            // 
            this.button_TabFeed_NextComment.Location = new System.Drawing.Point(2, 273);
            this.button_TabFeed_NextComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_NextComment.Name = "button_TabFeed_NextComment";
            this.button_TabFeed_NextComment.Size = new System.Drawing.Size(213, 26);
            this.button_TabFeed_NextComment.TabIndex = 7;
            this.button_TabFeed_NextComment.Text = "Next Comment";
            this.button_TabFeed_NextComment.UseVisualStyleBackColor = true;
            this.button_TabFeed_NextComment.Click += new System.EventHandler(this.tabFeed_NextComment_Click);
            // 
            // button_TabFeed_NextPost
            // 
            this.button_TabFeed_NextPost.Location = new System.Drawing.Point(219, 273);
            this.button_TabFeed_NextPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_NextPost.Name = "button_TabFeed_NextPost";
            this.button_TabFeed_NextPost.Size = new System.Drawing.Size(308, 26);
            this.button_TabFeed_NextPost.TabIndex = 6;
            this.button_TabFeed_NextPost.Text = "Next Post";
            this.button_TabFeed_NextPost.UseVisualStyleBackColor = true;
            this.button_TabFeed_NextPost.Click += new System.EventHandler(this.tabFeed_NextPost_Click);
            // 
            // label_TabFeed_Comments
            // 
            this.label_TabFeed_Comments.AutoSize = true;
            this.label_TabFeed_Comments.Location = new System.Drawing.Point(4, 214);
            this.label_TabFeed_Comments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Comments.Name = "label_TabFeed_Comments";
            this.label_TabFeed_Comments.Size = new System.Drawing.Size(59, 13);
            this.label_TabFeed_Comments.TabIndex = 5;
            this.label_TabFeed_Comments.Text = "Comments:";
            // 
            // richTextBox_TabFeed_CommentText
            // 
            this.richTextBox_TabFeed_CommentText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_TabFeed_CommentText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox_TabFeed_CommentText.Location = new System.Drawing.Point(2, 229);
            this.richTextBox_TabFeed_CommentText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_TabFeed_CommentText.Name = "richTextBox_TabFeed_CommentText";
            this.richTextBox_TabFeed_CommentText.Size = new System.Drawing.Size(214, 42);
            this.richTextBox_TabFeed_CommentText.TabIndex = 4;
            this.richTextBox_TabFeed_CommentText.Text = string.Empty;
            // 
            // richTextBox_TabFeed_PostDescription
            // 
            this.richTextBox_TabFeed_PostDescription.Location = new System.Drawing.Point(226, 22);
            this.richTextBox_TabFeed_PostDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_TabFeed_PostDescription.Name = "richTextBox_TabFeed_PostDescription";
            this.richTextBox_TabFeed_PostDescription.Size = new System.Drawing.Size(310, 194);
            this.richTextBox_TabFeed_PostDescription.TabIndex = 3;
            this.richTextBox_TabFeed_PostDescription.Text = string.Empty;
            // 
            // label_TabFeed_PostName
            // 
            this.label_TabFeed_PostName.AutoSize = true;
            this.label_TabFeed_PostName.BackColor = System.Drawing.Color.SkyBlue;
            this.label_TabFeed_PostName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label_TabFeed_PostName.Location = new System.Drawing.Point(223, 4);
            this.label_TabFeed_PostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_PostName.Name = "label_TabFeed_PostName";
            this.label_TabFeed_PostName.Size = new System.Drawing.Size(38, 16);
            this.label_TabFeed_PostName.TabIndex = 2;
            this.label_TabFeed_PostName.Text = "Title";
            // 
            // pictureBox_TabFeed_PostPic
            // 
            this.pictureBox_TabFeed_PostPic.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_TabFeed_PostPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFeed_PostPic.Name = "pictureBox_TabFeed_PostPic";
            this.pictureBox_TabFeed_PostPic.Size = new System.Drawing.Size(213, 190);
            this.pictureBox_TabFeed_PostPic.TabIndex = 1;
            this.pictureBox_TabFeed_PostPic.TabStop = false;
            // 
            // label_TabFeed_PostDate
            // 
            this.label_TabFeed_PostDate.AutoSize = true;
            this.label_TabFeed_PostDate.BackColor = System.Drawing.Color.SkyBlue;
            this.label_TabFeed_PostDate.Font = new System.Drawing.Font("Arial", 10F);
            this.label_TabFeed_PostDate.Location = new System.Drawing.Point(10, 5);
            this.label_TabFeed_PostDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_PostDate.Name = "label_TabFeed_PostDate";
            this.label_TabFeed_PostDate.Size = new System.Drawing.Size(64, 16);
            this.label_TabFeed_PostDate.TabIndex = 0;
            this.label_TabFeed_PostDate.Text = "00/00/00";
            // 
            // pictureBox_TabFeed_ProfilePic
            // 
            this.pictureBox_TabFeed_ProfilePic.Location = new System.Drawing.Point(4, 166);
            this.pictureBox_TabFeed_ProfilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFeed_ProfilePic.Name = "pictureBox_TabFeed_ProfilePic";
            this.pictureBox_TabFeed_ProfilePic.Size = new System.Drawing.Size(143, 143);
            this.pictureBox_TabFeed_ProfilePic.TabIndex = 5;
            this.pictureBox_TabFeed_ProfilePic.TabStop = false;
            // 
            // panel_TabFeed_Navigate
            // 
            this.panel_TabFeed_Navigate.BackColor = System.Drawing.Color.White;
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_Feature2);
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_FaceRide);
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_Profile);
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_Albums);
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_Friends);
            this.panel_TabFeed_Navigate.Controls.Add(this.button_TabFeed_Logout);
            this.panel_TabFeed_Navigate.Location = new System.Drawing.Point(5, 283);
            this.panel_TabFeed_Navigate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_TabFeed_Navigate.Name = "panel_TabFeed_Navigate";
            this.panel_TabFeed_Navigate.Size = new System.Drawing.Size(768, 46);
            this.panel_TabFeed_Navigate.TabIndex = 4;
            // 
            // button_TabFeed_Feature2
            // 
            this.button_TabFeed_Feature2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabFeed_Feature2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabFeed_Feature2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabFeed_Feature2.Location = new System.Drawing.Point(576, 4);
            this.button_TabFeed_Feature2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_Feature2.Name = "button_TabFeed_Feature2";
            this.button_TabFeed_Feature2.Size = new System.Drawing.Size(108, 30);
            this.button_TabFeed_Feature2.TabIndex = 9;
            this.button_TabFeed_Feature2.Text = "Contacts";
            this.button_TabFeed_Feature2.UseVisualStyleBackColor = false;
            this.button_TabFeed_Feature2.Click += new System.EventHandler(this.tabFeed_ContactsButton_Click);
            // 
            // button_TabFeed_FaceRide
            // 
            this.button_TabFeed_FaceRide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabFeed_FaceRide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabFeed_FaceRide.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabFeed_FaceRide.Location = new System.Drawing.Point(467, 4);
            this.button_TabFeed_FaceRide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_FaceRide.Name = "button_TabFeed_FaceRide";
            this.button_TabFeed_FaceRide.Size = new System.Drawing.Size(108, 30);
            this.button_TabFeed_FaceRide.TabIndex = 8;
            this.button_TabFeed_FaceRide.Text = "FaceRide!";
            this.button_TabFeed_FaceRide.UseVisualStyleBackColor = false;
            this.button_TabFeed_FaceRide.Click += new System.EventHandler(this.tabFeed_FaceRideButton_Click);
            // 
            // button_TabFeed_Profile
            // 
            this.button_TabFeed_Profile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabFeed_Profile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabFeed_Profile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabFeed_Profile.Location = new System.Drawing.Point(255, 4);
            this.button_TabFeed_Profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_Profile.Name = "button_TabFeed_Profile";
            this.button_TabFeed_Profile.Size = new System.Drawing.Size(108, 30);
            this.button_TabFeed_Profile.TabIndex = 7;
            this.button_TabFeed_Profile.Text = "Profile ";
            this.button_TabFeed_Profile.UseVisualStyleBackColor = false;
            this.button_TabFeed_Profile.Click += new System.EventHandler(this.tabFeed_ProfileButton_Click);
            // 
            // button_TabFeed_Albums
            // 
            this.button_TabFeed_Albums.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabFeed_Albums.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabFeed_Albums.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabFeed_Albums.Location = new System.Drawing.Point(147, 4);
            this.button_TabFeed_Albums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_Albums.Name = "button_TabFeed_Albums";
            this.button_TabFeed_Albums.Size = new System.Drawing.Size(108, 30);
            this.button_TabFeed_Albums.TabIndex = 6;
            this.button_TabFeed_Albums.Text = "Albums";
            this.button_TabFeed_Albums.UseVisualStyleBackColor = false;
            this.button_TabFeed_Albums.Click += new System.EventHandler(this.tabFeed_AlbumsButton_Click);
            // 
            // button_TabFeed_Friends
            // 
            this.button_TabFeed_Friends.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabFeed_Friends.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabFeed_Friends.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabFeed_Friends.Location = new System.Drawing.Point(361, 4);
            this.button_TabFeed_Friends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_Friends.Name = "button_TabFeed_Friends";
            this.button_TabFeed_Friends.Size = new System.Drawing.Size(108, 30);
            this.button_TabFeed_Friends.TabIndex = 5;
            this.button_TabFeed_Friends.Text = "Friends";
            this.button_TabFeed_Friends.UseVisualStyleBackColor = false;
            this.button_TabFeed_Friends.Click += new System.EventHandler(this.tabFeed_FriendsButton_Click);
            // 
            // button_TabFeed_Logout
            // 
            this.button_TabFeed_Logout.BackColor = System.Drawing.Color.White;
            this.button_TabFeed_Logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button_TabFeed_Logout.ForeColor = System.Drawing.Color.SlateGray;
            this.button_TabFeed_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TabFeed_Logout.Location = new System.Drawing.Point(685, 4);
            this.button_TabFeed_Logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFeed_Logout.Name = "button_TabFeed_Logout";
            this.button_TabFeed_Logout.Size = new System.Drawing.Size(82, 30);
            this.button_TabFeed_Logout.TabIndex = 4;
            this.button_TabFeed_Logout.Text = "Logout";
            this.button_TabFeed_Logout.UseVisualStyleBackColor = false;
            this.button_TabFeed_Logout.Click += new System.EventHandler(this.tabFeed_Logout_Click);
            // 
            // panel_TabFeed_Intro
            // 
            this.panel_TabFeed_Intro.BackColor = System.Drawing.Color.White;
            this.panel_TabFeed_Intro.Controls.Add(this.pictureBox_TabFeed_IntroPic);
            this.panel_TabFeed_Intro.Controls.Add(this.label_TabFeed_Intro);
            this.panel_TabFeed_Intro.Controls.Add(this.panel_TabFeed_Gender);
            this.panel_TabFeed_Intro.Controls.Add(this.panel_TabFeed_LivesIn);
            this.panel_TabFeed_Intro.Controls.Add(this.panel_TabFeed_Email);
            this.panel_TabFeed_Intro.Controls.Add(this.panel_TabFeed_Birthday);
            this.panel_TabFeed_Intro.Location = new System.Drawing.Point(5, 334);
            this.panel_TabFeed_Intro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabFeed_Intro.Name = "panel_TabFeed_Intro";
            this.panel_TabFeed_Intro.Size = new System.Drawing.Size(190, 330);
            this.panel_TabFeed_Intro.TabIndex = 3;
            // 
            // pictureBox_TabFeed_IntroPic
            // 
            this.pictureBox_TabFeed_IntroPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFeed_IntroPic.BackgroundImage")));
            this.pictureBox_TabFeed_IntroPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_TabFeed_IntroPic.Location = new System.Drawing.Point(10, 6);
            this.pictureBox_TabFeed_IntroPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFeed_IntroPic.Name = "pictureBox_TabFeed_IntroPic";
            this.pictureBox_TabFeed_IntroPic.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_TabFeed_IntroPic.TabIndex = 6;
            this.pictureBox_TabFeed_IntroPic.TabStop = false;
            // 
            // label_TabFeed_Intro
            // 
            this.label_TabFeed_Intro.AutoSize = true;
            this.label_TabFeed_Intro.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TabFeed_Intro.Location = new System.Drawing.Point(58, 12);
            this.label_TabFeed_Intro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Intro.Name = "label_TabFeed_Intro";
            this.label_TabFeed_Intro.Size = new System.Drawing.Size(53, 22);
            this.label_TabFeed_Intro.TabIndex = 5;
            this.label_TabFeed_Intro.Text = "Intro";
            // 
            // panel_TabFeed_Gender
            // 
            this.panel_TabFeed_Gender.Controls.Add(this.label_TabMain_Gender);
            this.panel_TabFeed_Gender.Controls.Add(this.label_TabFeed_Gender2);
            this.panel_TabFeed_Gender.Location = new System.Drawing.Point(10, 178);
            this.panel_TabFeed_Gender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabFeed_Gender.Name = "panel_TabFeed_Gender";
            this.panel_TabFeed_Gender.Size = new System.Drawing.Size(174, 34);
            this.panel_TabFeed_Gender.TabIndex = 4;
            // 
            // label_TabMain_Gender
            // 
            this.label_TabMain_Gender.AutoSize = true;
            this.label_TabMain_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabMain_Gender.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_TabMain_Gender.Location = new System.Drawing.Point(69, 14);
            this.label_TabMain_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabMain_Gender.Name = "label_TabMain_Gender";
            this.label_TabMain_Gender.Size = new System.Drawing.Size(29, 13);
            this.label_TabMain_Gender.TabIndex = 1;
            this.label_TabMain_Gender.Text = "male";
            // 
            // label_TabFeed_Gender2
            // 
            this.label_TabFeed_Gender2.AutoSize = true;
            this.label_TabFeed_Gender2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_Gender2.Location = new System.Drawing.Point(2, 11);
            this.label_TabFeed_Gender2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Gender2.Name = "label_TabFeed_Gender2";
            this.label_TabFeed_Gender2.Size = new System.Drawing.Size(61, 16);
            this.label_TabFeed_Gender2.TabIndex = 0;
            this.label_TabFeed_Gender2.Text = "Gender";
            // 
            // panel_TabFeed_LivesIn
            // 
            this.panel_TabFeed_LivesIn.Controls.Add(this.label_TabFeed_LivesIn);
            this.panel_TabFeed_LivesIn.Controls.Add(this.label_TabFeed_LivesIn2);
            this.panel_TabFeed_LivesIn.Location = new System.Drawing.Point(10, 135);
            this.panel_TabFeed_LivesIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabFeed_LivesIn.Name = "panel_TabFeed_LivesIn";
            this.panel_TabFeed_LivesIn.Size = new System.Drawing.Size(174, 34);
            this.panel_TabFeed_LivesIn.TabIndex = 3;
            // 
            // label_TabFeed_LivesIn
            // 
            this.label_TabFeed_LivesIn.AutoSize = true;
            this.label_TabFeed_LivesIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_LivesIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_TabFeed_LivesIn.Location = new System.Drawing.Point(69, 15);
            this.label_TabFeed_LivesIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_LivesIn.Name = "label_TabFeed_LivesIn";
            this.label_TabFeed_LivesIn.Size = new System.Drawing.Size(77, 13);
            this.label_TabFeed_LivesIn.TabIndex = 1;
            this.label_TabFeed_LivesIn.Text = "Tel Aviv, Israel";
            // 
            // label_TabFeed_LivesIn2
            // 
            this.label_TabFeed_LivesIn2.AutoSize = true;
            this.label_TabFeed_LivesIn2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label_TabFeed_LivesIn2.Location = new System.Drawing.Point(2, 14);
            this.label_TabFeed_LivesIn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_LivesIn2.Name = "label_TabFeed_LivesIn2";
            this.label_TabFeed_LivesIn2.Size = new System.Drawing.Size(63, 16);
            this.label_TabFeed_LivesIn2.TabIndex = 0;
            this.label_TabFeed_LivesIn2.Text = "Lives In";
            // 
            // panel_TabFeed_Email
            // 
            this.panel_TabFeed_Email.Controls.Add(this.label_TabFeed_Email);
            this.panel_TabFeed_Email.Controls.Add(this.label_TabFeed_Email2);
            this.panel_TabFeed_Email.Location = new System.Drawing.Point(10, 95);
            this.panel_TabFeed_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabFeed_Email.Name = "panel_TabFeed_Email";
            this.panel_TabFeed_Email.Size = new System.Drawing.Size(174, 34);
            this.panel_TabFeed_Email.TabIndex = 2;
            // 
            // label_TabFeed_Email
            // 
            this.label_TabFeed_Email.AutoSize = true;
            this.label_TabFeed_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_Email.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_TabFeed_Email.Location = new System.Drawing.Point(69, 14);
            this.label_TabFeed_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Email.Name = "label_TabFeed_Email";
            this.label_TabFeed_Email.Size = new System.Drawing.Size(67, 13);
            this.label_TabFeed_Email.TabIndex = 1;
            this.label_TabFeed_Email.Text = "0527212121";
            // 
            // label_TabFeed_Email2
            // 
            this.label_TabFeed_Email2.AutoSize = true;
            this.label_TabFeed_Email2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_Email2.Location = new System.Drawing.Point(2, 11);
            this.label_TabFeed_Email2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Email2.Name = "label_TabFeed_Email2";
            this.label_TabFeed_Email2.Size = new System.Drawing.Size(45, 16);
            this.label_TabFeed_Email2.TabIndex = 0;
            this.label_TabFeed_Email2.Text = "Email";
            // 
            // panel_TabFeed_Birthday
            // 
            this.panel_TabFeed_Birthday.Controls.Add(this.label_TabFeed_Birthday);
            this.panel_TabFeed_Birthday.Controls.Add(this.label_TabFeed_Birthday2);
            this.panel_TabFeed_Birthday.Location = new System.Drawing.Point(10, 54);
            this.panel_TabFeed_Birthday.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabFeed_Birthday.Name = "panel_TabFeed_Birthday";
            this.panel_TabFeed_Birthday.Size = new System.Drawing.Size(174, 34);
            this.panel_TabFeed_Birthday.TabIndex = 0;
            // 
            // label_TabFeed_Birthday
            // 
            this.label_TabFeed_Birthday.AutoSize = true;
            this.label_TabFeed_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_Birthday.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_TabFeed_Birthday.Location = new System.Drawing.Point(69, 14);
            this.label_TabFeed_Birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Birthday.Name = "label_TabFeed_Birthday";
            this.label_TabFeed_Birthday.Size = new System.Drawing.Size(55, 13);
            this.label_TabFeed_Birthday.TabIndex = 1;
            this.label_TabFeed_Birthday.Text = "dd/mm/yy";
            // 
            // label_TabFeed_Birthday2
            // 
            this.label_TabFeed_Birthday2.AutoSize = true;
            this.label_TabFeed_Birthday2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabFeed_Birthday2.Location = new System.Drawing.Point(2, 11);
            this.label_TabFeed_Birthday2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TabFeed_Birthday2.Name = "label_TabFeed_Birthday2";
            this.label_TabFeed_Birthday2.Size = new System.Drawing.Size(66, 16);
            this.label_TabFeed_Birthday2.TabIndex = 0;
            this.label_TabFeed_Birthday2.Text = "Birthday";
            // 
            // linkLabel_TabFeed_FullName
            // 
            this.linkLabel_TabFeed_FullName.AutoSize = true;
            this.linkLabel_TabFeed_FullName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel_TabFeed_FullName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel_TabFeed_FullName.LinkColor = System.Drawing.Color.White;
            this.linkLabel_TabFeed_FullName.Location = new System.Drawing.Point(151, 250);
            this.linkLabel_TabFeed_FullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFeed_FullName.Name = "linkLabel_TabFeed_FullName";
            this.linkLabel_TabFeed_FullName.Size = new System.Drawing.Size(128, 29);
            this.linkLabel_TabFeed_FullName.TabIndex = 2;
            this.linkLabel_TabFeed_FullName.TabStop = true;
            this.linkLabel_TabFeed_FullName.Text = "Full Name";
            this.linkLabel_TabFeed_FullName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFeed_linkLabelFullName_Click);
            // 
            // pictureBox_TabFeed_CoverPhoto
            // 
            this.pictureBox_TabFeed_CoverPhoto.Location = new System.Drawing.Point(1, 3);
            this.pictureBox_TabFeed_CoverPhoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_TabFeed_CoverPhoto.Name = "pictureBox_TabFeed_CoverPhoto";
            this.pictureBox_TabFeed_CoverPhoto.Size = new System.Drawing.Size(770, 246);
            this.pictureBox_TabFeed_CoverPhoto.TabIndex = 0;
            this.pictureBox_TabFeed_CoverPhoto.TabStop = false;
            // 
            // tabPage_Albums
            // 
            this.tabPage_Albums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_Albums.Controls.Add(this.buttonSlideShow);
            this.tabPage_Albums.Controls.Add(this.comboBox_TabAlbums_AlbumsList);
            this.tabPage_Albums.Controls.Add(this.pictureBox_TabAlbums_FacebookLogo);
            this.tabPage_Albums.Controls.Add(this.pictureBox_TabAlbums_ChooseYourAlbum);
            this.tabPage_Albums.Controls.Add(this.button_TabAlbums_Next);
            this.tabPage_Albums.Controls.Add(this.button_TabAlbums_Prevoius);
            this.tabPage_Albums.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Albums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Albums.Name = "tabPage_Albums";
            this.tabPage_Albums.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Albums.Size = new System.Drawing.Size(776, 661);
            this.tabPage_Albums.TabIndex = 2;
            this.tabPage_Albums.Text = "Albums";
            this.tabPage_Albums.UseVisualStyleBackColor = true;
            // 
            // comboBox_TabAlbums_AlbumsList
            // 
            this.comboBox_TabAlbums_AlbumsList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AlbumsBindingSource, "Name", true));
            this.comboBox_TabAlbums_AlbumsList.DataSource = this.AlbumsBindingSource;
            this.comboBox_TabAlbums_AlbumsList.DisplayMember = "Name";
            this.comboBox_TabAlbums_AlbumsList.FormattingEnabled = true;
            this.comboBox_TabAlbums_AlbumsList.Location = new System.Drawing.Point(4, 81);
            this.comboBox_TabAlbums_AlbumsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_TabAlbums_AlbumsList.Name = "comboBox_TabAlbums_AlbumsList";
            this.comboBox_TabAlbums_AlbumsList.Size = new System.Drawing.Size(181, 21);
            this.comboBox_TabAlbums_AlbumsList.TabIndex = 21;
            // 
            // AlbumsBindingSource
            // 
            this.AlbumsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // pictureBox_TabAlbums_FacebookLogo
            // 
            this.pictureBox_TabAlbums_FacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabAlbums_FacebookLogo.Image")));
            this.pictureBox_TabAlbums_FacebookLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_TabAlbums_FacebookLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_TabAlbums_FacebookLogo.Name = "pictureBox_TabAlbums_FacebookLogo";
            this.pictureBox_TabAlbums_FacebookLogo.Size = new System.Drawing.Size(46, 44);
            this.pictureBox_TabAlbums_FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabAlbums_FacebookLogo.TabIndex = 20;
            this.pictureBox_TabAlbums_FacebookLogo.TabStop = false;
            // 
            // pictureBox_TabAlbums_ChooseYourAlbum
            // 
            this.pictureBox_TabAlbums_ChooseYourAlbum.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabAlbums_ChooseYourAlbum.Image")));
            this.pictureBox_TabAlbums_ChooseYourAlbum.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox_TabAlbums_ChooseYourAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabAlbums_ChooseYourAlbum.Name = "pictureBox_TabAlbums_ChooseYourAlbum";
            this.pictureBox_TabAlbums_ChooseYourAlbum.Size = new System.Drawing.Size(749, 77);
            this.pictureBox_TabAlbums_ChooseYourAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_TabAlbums_ChooseYourAlbum.TabIndex = 8;
            this.pictureBox_TabAlbums_ChooseYourAlbum.TabStop = false;
            // 
            // button_TabAlbums_Next
            // 
            this.button_TabAlbums_Next.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabAlbums_Next.Enabled = false;
            this.button_TabAlbums_Next.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabAlbums_Next.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabAlbums_Next.Location = new System.Drawing.Point(549, 427);
            this.button_TabAlbums_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabAlbums_Next.Name = "button_TabAlbums_Next";
            this.button_TabAlbums_Next.Size = new System.Drawing.Size(205, 42);
            this.button_TabAlbums_Next.TabIndex = 7;
            this.button_TabAlbums_Next.Text = "Next";
            this.button_TabAlbums_Next.UseVisualStyleBackColor = false;
            this.button_TabAlbums_Next.Click += new System.EventHandler(this.tabAlbum_Next_Click);
            // 
            // button_TabAlbums_Prevoius
            // 
            this.button_TabAlbums_Prevoius.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TabAlbums_Prevoius.Enabled = false;
            this.button_TabAlbums_Prevoius.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_TabAlbums_Prevoius.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_TabAlbums_Prevoius.Location = new System.Drawing.Point(2, 427);
            this.button_TabAlbums_Prevoius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabAlbums_Prevoius.Name = "button_TabAlbums_Prevoius";
            this.button_TabAlbums_Prevoius.Size = new System.Drawing.Size(197, 42);
            this.button_TabAlbums_Prevoius.TabIndex = 6;
            this.button_TabAlbums_Prevoius.Text = "Previous";
            this.button_TabAlbums_Prevoius.UseVisualStyleBackColor = false;
            this.button_TabAlbums_Prevoius.Click += new System.EventHandler(this.tabAlbum_Previous_Click);
            // 
            // tabPage_Profile
            // 
            this.tabPage_Profile.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Profile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Profile.Name = "tabPage_Profile";
            this.tabPage_Profile.Size = new System.Drawing.Size(776, 661);
            this.tabPage_Profile.TabIndex = 3;
            this.tabPage_Profile.Text = "Profile";
            this.tabPage_Profile.UseVisualStyleBackColor = true;
            // 
            // tabPage_Friends
            // 
            this.tabPage_Friends.Controls.Add(this.textBox_TabFriends_FriendName);
            this.tabPage_Friends.Controls.Add(this.button_TabFriends_Search);
            this.tabPage_Friends.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Friends.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Friends.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Friends.Name = "tabPage_Friends";
            this.tabPage_Friends.Size = new System.Drawing.Size(776, 661);
            this.tabPage_Friends.TabIndex = 4;
            this.tabPage_Friends.Text = "Friends";
            this.tabPage_Friends.UseVisualStyleBackColor = true;
            // 
            // textBox_TabFriends_FriendName
            // 
            this.textBox_TabFriends_FriendName.Location = new System.Drawing.Point(51, 3);
            this.textBox_TabFriends_FriendName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_TabFriends_FriendName.Name = "textBox_TabFriends_FriendName";
            this.textBox_TabFriends_FriendName.Size = new System.Drawing.Size(154, 20);
            this.textBox_TabFriends_FriendName.TabIndex = 10;
            this.textBox_TabFriends_FriendName.Text = "What\'s your friend\'s name?";
            // 
            // button_TabFriends_Search
            // 
            this.button_TabFriends_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_TabFriends_Search.ForeColor = System.Drawing.SystemColors.Window;
            this.button_TabFriends_Search.Location = new System.Drawing.Point(207, 3);
            this.button_TabFriends_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_TabFriends_Search.Name = "button_TabFriends_Search";
            this.button_TabFriends_Search.Size = new System.Drawing.Size(74, 21);
            this.button_TabFriends_Search.TabIndex = 9;
            this.button_TabFriends_Search.Text = "Search";
            this.button_TabFriends_Search.UseVisualStyleBackColor = false;
            // 
            // tabPage_FaceRide
            // 
            this.tabPage_FaceRide.Controls.Add(this.linkLabel_TabFaceRide_GetFromEvent);
            this.tabPage_FaceRide.Controls.Add(this.textBox_TabFaceRide_Km);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_Location);
            this.tabPage_FaceRide.Controls.Add(this.linkLabel_TabFaceRide_ShowOnMap);
            this.tabPage_FaceRide.Controls.Add(this.comboBox_TabFaceRide_Radius);
            this.tabPage_FaceRide.Controls.Add(this.checkBox_TabFaceRide_Female);
            this.tabPage_FaceRide.Controls.Add(this.linkLabel_TabFaceRide_CurrentLocation);
            this.tabPage_FaceRide.Controls.Add(this.richTextBox_TabFaceRide_WhereFrom);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox1);
            this.tabPage_FaceRide.Controls.Add(this.checkBox_TabFaceRide_Male);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_Location2);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_Radius);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_Destination);
            this.tabPage_FaceRide.Controls.Add(this.button_TabFaceRide_LetsRide);
            this.tabPage_FaceRide.Controls.Add(this.richTextBox_TabFaceRide_WhereTo);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_subTitle);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_Title);
            this.tabPage_FaceRide.Controls.Add(this.pictureBox_TabFaceRide_FacebookLogo);
            this.tabPage_FaceRide.Location = new System.Drawing.Point(4, 22);
            this.tabPage_FaceRide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_FaceRide.Name = "tabPage_FaceRide";
            this.tabPage_FaceRide.Size = new System.Drawing.Size(776, 661);
            this.tabPage_FaceRide.TabIndex = 5;
            this.tabPage_FaceRide.Text = "FaceRide!";
            this.tabPage_FaceRide.UseVisualStyleBackColor = true;
            // 
            // linkLabel_TabFaceRide_GetFromEvent
            // 
            this.linkLabel_TabFaceRide_GetFromEvent.AutoSize = true;
            this.linkLabel_TabFaceRide_GetFromEvent.Location = new System.Drawing.Point(228, 239);
            this.linkLabel_TabFaceRide_GetFromEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFaceRide_GetFromEvent.Name = "linkLabel_TabFaceRide_GetFromEvent";
            this.linkLabel_TabFaceRide_GetFromEvent.Size = new System.Drawing.Size(141, 13);
            this.linkLabel_TabFaceRide_GetFromEvent.TabIndex = 39;
            this.linkLabel_TabFaceRide_GetFromEvent.TabStop = true;
            this.linkLabel_TabFaceRide_GetFromEvent.Text = "Get Location From An Event";
            this.linkLabel_TabFaceRide_GetFromEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFaceRide_linkLabel_GetFromEvent_Click);
            // 
            // textBox_TabFaceRide_Km
            // 
            this.textBox_TabFaceRide_Km.Location = new System.Drawing.Point(275, 256);
            this.textBox_TabFaceRide_Km.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_TabFaceRide_Km.Name = "textBox_TabFaceRide_Km";
            this.textBox_TabFaceRide_Km.ReadOnly = true;
            this.textBox_TabFaceRide_Km.Size = new System.Drawing.Size(34, 20);
            this.textBox_TabFaceRide_Km.TabIndex = 38;
            this.textBox_TabFaceRide_Km.Text = "KM";
            this.textBox_TabFaceRide_Km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_TabFaceRide_Location
            // 
            this.pictureBox_TabFaceRide_Location.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_Location.Image")));
            this.pictureBox_TabFaceRide_Location.Location = new System.Drawing.Point(454, 138);
            this.pictureBox_TabFaceRide_Location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_Location.Name = "pictureBox_TabFaceRide_Location";
            this.pictureBox_TabFaceRide_Location.Size = new System.Drawing.Size(26, 37);
            this.pictureBox_TabFaceRide_Location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_Location.TabIndex = 37;
            this.pictureBox_TabFaceRide_Location.TabStop = false;
            // 
            // linkLabel_TabFaceRide_ShowOnMap
            // 
            this.linkLabel_TabFaceRide_ShowOnMap.AutoSize = true;
            this.linkLabel_TabFaceRide_ShowOnMap.Location = new System.Drawing.Point(313, 260);
            this.linkLabel_TabFaceRide_ShowOnMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFaceRide_ShowOnMap.Name = "linkLabel_TabFaceRide_ShowOnMap";
            this.linkLabel_TabFaceRide_ShowOnMap.Size = new System.Drawing.Size(58, 13);
            this.linkLabel_TabFaceRide_ShowOnMap.TabIndex = 36;
            this.linkLabel_TabFaceRide_ShowOnMap.TabStop = true;
            this.linkLabel_TabFaceRide_ShowOnMap.Text = "Show Map";
            this.linkLabel_TabFaceRide_ShowOnMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFaceRide_linkLabelShowMap_Click);
            // 
            // comboBox_TabFaceRide_Radius
            // 
            this.comboBox_TabFaceRide_Radius.FormattingEnabled = true;
            this.comboBox_TabFaceRide_Radius.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_TabFaceRide_Radius.Location = new System.Drawing.Point(230, 254);
            this.comboBox_TabFaceRide_Radius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_TabFaceRide_Radius.Name = "comboBox_TabFaceRide_Radius";
            this.comboBox_TabFaceRide_Radius.Size = new System.Drawing.Size(42, 21);
            this.comboBox_TabFaceRide_Radius.TabIndex = 35;
            // 
            // checkBox_TabFaceRide_Female
            // 
            this.checkBox_TabFaceRide_Female.AutoSize = true;
            this.checkBox_TabFaceRide_Female.Location = new System.Drawing.Point(230, 320);
            this.checkBox_TabFaceRide_Female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_TabFaceRide_Female.Name = "checkBox_TabFaceRide_Female";
            this.checkBox_TabFaceRide_Female.Size = new System.Drawing.Size(97, 17);
            this.checkBox_TabFaceRide_Female.TabIndex = 34;
            this.checkBox_TabFaceRide_Female.Text = "Female Friends";
            this.checkBox_TabFaceRide_Female.UseVisualStyleBackColor = true;
            // 
            // linkLabel_TabFaceRide_CurrentLocation
            // 
            this.linkLabel_TabFaceRide_CurrentLocation.AutoSize = true;
            this.linkLabel_TabFaceRide_CurrentLocation.Location = new System.Drawing.Point(228, 176);
            this.linkLabel_TabFaceRide_CurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_TabFaceRide_CurrentLocation.Name = "linkLabel_TabFaceRide_CurrentLocation";
            this.linkLabel_TabFaceRide_CurrentLocation.Size = new System.Drawing.Size(124, 13);
            this.linkLabel_TabFaceRide_CurrentLocation.TabIndex = 32;
            this.linkLabel_TabFaceRide_CurrentLocation.TabStop = true;
            this.linkLabel_TabFaceRide_CurrentLocation.Text = "Use My Current Location";
            this.linkLabel_TabFaceRide_CurrentLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tabFaceRide_linkLabelLocation_Click);
            // 
            // richTextBox_TabFaceRide_WhereFrom
            // 
            this.richTextBox_TabFaceRide_WhereFrom.Location = new System.Drawing.Point(228, 138);
            this.richTextBox_TabFaceRide_WhereFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_TabFaceRide_WhereFrom.Name = "richTextBox_TabFaceRide_WhereFrom";
            this.richTextBox_TabFaceRide_WhereFrom.Size = new System.Drawing.Size(222, 37);
            this.richTextBox_TabFaceRide_WhereFrom.TabIndex = 31;
            this.richTextBox_TabFaceRide_WhereFrom.Text = string.Empty;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_TabFaceRide_Male
            // 
            this.checkBox_TabFaceRide_Male.AutoSize = true;
            this.checkBox_TabFaceRide_Male.Location = new System.Drawing.Point(230, 300);
            this.checkBox_TabFaceRide_Male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_TabFaceRide_Male.Name = "checkBox_TabFaceRide_Male";
            this.checkBox_TabFaceRide_Male.Size = new System.Drawing.Size(86, 17);
            this.checkBox_TabFaceRide_Male.TabIndex = 29;
            this.checkBox_TabFaceRide_Male.Text = "Male Friends";
            this.checkBox_TabFaceRide_Male.UseVisualStyleBackColor = true;
            // 
            // pictureBox_TabFaceRide_Location2
            // 
            this.pictureBox_TabFaceRide_Location2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_Location2.Image")));
            this.pictureBox_TabFaceRide_Location2.Location = new System.Drawing.Point(454, 191);
            this.pictureBox_TabFaceRide_Location2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_Location2.Name = "pictureBox_TabFaceRide_Location2";
            this.pictureBox_TabFaceRide_Location2.Size = new System.Drawing.Size(26, 37);
            this.pictureBox_TabFaceRide_Location2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_Location2.TabIndex = 28;
            this.pictureBox_TabFaceRide_Location2.TabStop = false;
            // 
            // pictureBox_TabFaceRide_Radius
            // 
            this.pictureBox_TabFaceRide_Radius.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_Radius.Image")));
            this.pictureBox_TabFaceRide_Radius.Location = new System.Drawing.Point(49, 239);
            this.pictureBox_TabFaceRide_Radius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_Radius.Name = "pictureBox_TabFaceRide_Radius";
            this.pictureBox_TabFaceRide_Radius.Size = new System.Drawing.Size(152, 29);
            this.pictureBox_TabFaceRide_Radius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_Radius.TabIndex = 27;
            this.pictureBox_TabFaceRide_Radius.TabStop = false;
            // 
            // pictureBox_TabFaceRide_Destination
            // 
            this.pictureBox_TabFaceRide_Destination.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_Destination.Image")));
            this.pictureBox_TabFaceRide_Destination.Location = new System.Drawing.Point(46, 189);
            this.pictureBox_TabFaceRide_Destination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_Destination.Name = "pictureBox_TabFaceRide_Destination";
            this.pictureBox_TabFaceRide_Destination.Size = new System.Drawing.Size(178, 38);
            this.pictureBox_TabFaceRide_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_Destination.TabIndex = 26;
            this.pictureBox_TabFaceRide_Destination.TabStop = false;
            // 
            // button_TabFaceRide_LetsRide
            // 
            this.button_TabFaceRide_LetsRide.Location = new System.Drawing.Point(230, 340);
            this.button_TabFaceRide_LetsRide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TabFaceRide_LetsRide.Name = "button_TabFaceRide_LetsRide";
            this.button_TabFaceRide_LetsRide.Size = new System.Drawing.Size(100, 38);
            this.button_TabFaceRide_LetsRide.TabIndex = 25;
            this.button_TabFaceRide_LetsRide.Text = "Let\'s Ride!";
            this.button_TabFaceRide_LetsRide.UseVisualStyleBackColor = true;
            this.button_TabFaceRide_LetsRide.Click += new System.EventHandler(this.tabFaceRide_LetsRide_Click);
            // 
            // richTextBox_TabFaceRide_WhereTo
            // 
            this.richTextBox_TabFaceRide_WhereTo.Location = new System.Drawing.Point(228, 191);
            this.richTextBox_TabFaceRide_WhereTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_TabFaceRide_WhereTo.Name = "richTextBox_TabFaceRide_WhereTo";
            this.richTextBox_TabFaceRide_WhereTo.Size = new System.Drawing.Size(222, 37);
            this.richTextBox_TabFaceRide_WhereTo.TabIndex = 24;
            this.richTextBox_TabFaceRide_WhereTo.Text = string.Empty;
            // 
            // pictureBox_TabFaceRide_subTitle
            // 
            this.pictureBox_TabFaceRide_subTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_TabFaceRide_subTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_subTitle.Image")));
            this.pictureBox_TabFaceRide_subTitle.Location = new System.Drawing.Point(46, 86);
            this.pictureBox_TabFaceRide_subTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_subTitle.Name = "pictureBox_TabFaceRide_subTitle";
            this.pictureBox_TabFaceRide_subTitle.Size = new System.Drawing.Size(608, 42);
            this.pictureBox_TabFaceRide_subTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_subTitle.TabIndex = 23;
            this.pictureBox_TabFaceRide_subTitle.TabStop = false;
            // 
            // pictureBox_TabFaceRide_Title
            // 
            this.pictureBox_TabFaceRide_Title.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_Title.Image")));
            this.pictureBox_TabFaceRide_Title.Location = new System.Drawing.Point(46, 2);
            this.pictureBox_TabFaceRide_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_TabFaceRide_Title.Name = "pictureBox_TabFaceRide_Title";
            this.pictureBox_TabFaceRide_Title.Size = new System.Drawing.Size(623, 80);
            this.pictureBox_TabFaceRide_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_Title.TabIndex = 22;
            this.pictureBox_TabFaceRide_Title.TabStop = false;
            // 
            // pictureBox_TabFaceRide_FacebookLogo
            // 
            this.pictureBox_TabFaceRide_FacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TabFaceRide_FacebookLogo.Image")));
            this.pictureBox_TabFaceRide_FacebookLogo.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox_TabFaceRide_FacebookLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_TabFaceRide_FacebookLogo.Name = "pictureBox_TabFaceRide_FacebookLogo";
            this.pictureBox_TabFaceRide_FacebookLogo.Size = new System.Drawing.Size(46, 44);
            this.pictureBox_TabFaceRide_FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TabFaceRide_FacebookLogo.TabIndex = 21;
            this.pictureBox_TabFaceRide_FacebookLogo.TabStop = false;
            // 
            // tabPage_Contacts
            // 
            this.tabPage_Contacts.BackColor = System.Drawing.Color.White;
            this.tabPage_Contacts.Controls.Add(this.pictureBox2);
            this.tabPage_Contacts.Controls.Add(this.panel_TabContacts);
            this.tabPage_Contacts.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Contacts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Contacts.Name = "tabPage_Contacts";
            this.tabPage_Contacts.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Contacts.Size = new System.Drawing.Size(776, 661);
            this.tabPage_Contacts.TabIndex = 6;
            this.tabPage_Contacts.Text = "Contacts";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panel_TabContacts
            // 
            this.panel_TabContacts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_TabContacts.Controls.Add(this.button_TabContacts_Save);
            this.panel_TabContacts.Controls.Add(this.button_TabContacts_DisplayContacts);
            this.panel_TabContacts.Controls.Add(this.webBrowser_TabContacts);
            this.panel_TabContacts.Controls.Add(this.dataGridView_TabContacts);
            this.panel_TabContacts.Location = new System.Drawing.Point(0, 29);
            this.panel_TabContacts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_TabContacts.Name = "panel_TabContacts";
            this.panel_TabContacts.Size = new System.Drawing.Size(755, 748);
            this.panel_TabContacts.TabIndex = 0;
            // 
            // button_TabContacts_Save
            // 
            this.button_TabContacts_Save.BackColor = System.Drawing.Color.Lime;
            this.button_TabContacts_Save.Location = new System.Drawing.Point(2, 18);
            this.button_TabContacts_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_TabContacts_Save.Name = "button_TabContacts_Save";
            this.button_TabContacts_Save.Size = new System.Drawing.Size(103, 23);
            this.button_TabContacts_Save.TabIndex = 22;
            this.button_TabContacts_Save.Text = "Save Contacts.Csv";
            this.button_TabContacts_Save.UseVisualStyleBackColor = false;
            this.button_TabContacts_Save.Click += new System.EventHandler(this.tabContacts_Save_Click);
            // 
            // button_TabContacts_DisplayContacts
            // 
            this.button_TabContacts_DisplayContacts.Location = new System.Drawing.Point(574, 18);
            this.button_TabContacts_DisplayContacts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_TabContacts_DisplayContacts.Name = "button_TabContacts_DisplayContacts";
            this.button_TabContacts_DisplayContacts.Size = new System.Drawing.Size(182, 22);
            this.button_TabContacts_DisplayContacts.TabIndex = 1;
            this.button_TabContacts_DisplayContacts.Text = "Show Contacts to Edit";
            this.button_TabContacts_DisplayContacts.UseVisualStyleBackColor = true;
            this.button_TabContacts_DisplayContacts.Click += new System.EventHandler(this.tabContacts_DisplayContacts_Click);
            // 
            // webBrowser_TabContacts
            // 
            this.webBrowser_TabContacts.CausesValidation = false;
            this.webBrowser_TabContacts.Location = new System.Drawing.Point(0, 302);
            this.webBrowser_TabContacts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webBrowser_TabContacts.MinimumSize = new System.Drawing.Size(20, 21);
            this.webBrowser_TabContacts.Name = "webBrowser_TabContacts";
            this.webBrowser_TabContacts.Size = new System.Drawing.Size(755, 340);
            this.webBrowser_TabContacts.TabIndex = 2;
            // 
            // dataGridView_TabContacts
            // 
            this.dataGridView_TabContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TabContacts.Location = new System.Drawing.Point(2, 42);
            this.dataGridView_TabContacts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_TabContacts.Name = "dataGridView_TabContacts";
            this.dataGridView_TabContacts.Size = new System.Drawing.Size(753, 254);
            this.dataGridView_TabContacts.TabIndex = 0;
            // 
            // buttonSlideShow
            // 
            this.buttonSlideShow.Location = new System.Drawing.Point(280, 525);
            this.buttonSlideShow.Name = "buttonSlideShow";
            this.buttonSlideShow.Size = new System.Drawing.Size(185, 23);
            this.buttonSlideShow.TabIndex = 22;
            this.buttonSlideShow.Text = "Slide Show The Album";
            this.buttonSlideShow.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(794, 697);
            this.Controls.Add(this.tabsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook For Desktop!";
            this.tabsControl.ResumeLayout(false);
            this.tabPage_Feed.ResumeLayout(false);
            this.tabPage_Feed.PerformLayout();
            this.panel_TabFeed_Posts.ResumeLayout(false);
            this.panel_TabFeed_Posts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_PostPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_ProfilePic)).EndInit();
            this.panel_TabFeed_Navigate.ResumeLayout(false);
            this.panel_TabFeed_Intro.ResumeLayout(false);
            this.panel_TabFeed_Intro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_IntroPic)).EndInit();
            this.panel_TabFeed_Gender.ResumeLayout(false);
            this.panel_TabFeed_Gender.PerformLayout();
            this.panel_TabFeed_LivesIn.ResumeLayout(false);
            this.panel_TabFeed_LivesIn.PerformLayout();
            this.panel_TabFeed_Email.ResumeLayout(false);
            this.panel_TabFeed_Email.PerformLayout();
            this.panel_TabFeed_Birthday.ResumeLayout(false);
            this.panel_TabFeed_Birthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFeed_CoverPhoto)).EndInit();
            this.tabPage_Albums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabAlbums_FacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabAlbums_ChooseYourAlbum)).EndInit();
            this.tabPage_Friends.ResumeLayout(false);
            this.tabPage_Friends.PerformLayout();
            this.tabPage_FaceRide.ResumeLayout(false);
            this.tabPage_FaceRide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Location2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Destination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_subTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TabFaceRide_FacebookLogo)).EndInit();
            this.tabPage_Contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_TabContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TabContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabPage_Feed;
        private System.Windows.Forms.TabPage tabPage_Albums;
        private System.Windows.Forms.LinkLabel linkLabel_TabFeed_FullName;
        private System.Windows.Forms.PictureBox pictureBox_TabFeed_CoverPhoto;
        private System.Windows.Forms.Panel panel_TabFeed_Intro;
        private System.Windows.Forms.Label label_TabFeed_Intro;
        private System.Windows.Forms.Panel panel_TabFeed_Gender;
        private System.Windows.Forms.Label label_TabMain_Gender;
        private System.Windows.Forms.Label label_TabFeed_Gender2;
        private System.Windows.Forms.Panel panel_TabFeed_LivesIn;
        private System.Windows.Forms.Label label_TabFeed_LivesIn;
        private System.Windows.Forms.Label label_TabFeed_LivesIn2;
        private System.Windows.Forms.Panel panel_TabFeed_Email;
        private System.Windows.Forms.Label label_TabFeed_Email;
        private System.Windows.Forms.Label label_TabFeed_Email2;
        private System.Windows.Forms.Panel panel_TabFeed_Birthday;
        private System.Windows.Forms.Label label_TabFeed_Birthday;
        private System.Windows.Forms.Label label_TabFeed_Birthday2;
        private System.Windows.Forms.Button button_TabFeed_Logout;
        private System.Windows.Forms.TabPage tabPage_Profile;
        private System.Windows.Forms.TabPage tabPage_Friends;
        private System.Windows.Forms.Panel panel_TabFeed_Posts;
        private System.Windows.Forms.Button button_TabFeed_NextComment;
        private System.Windows.Forms.Button button_TabFeed_NextPost;
        private System.Windows.Forms.Label label_TabFeed_Comments;
        private System.Windows.Forms.RichTextBox richTextBox_TabFeed_CommentText;
        private System.Windows.Forms.RichTextBox richTextBox_TabFeed_PostDescription;
        private System.Windows.Forms.Label label_TabFeed_PostName;
        private System.Windows.Forms.PictureBox pictureBox_TabFeed_PostPic;
        private System.Windows.Forms.Label label_TabFeed_PostDate;
        private System.Windows.Forms.PictureBox pictureBox_TabFeed_ProfilePic;
        private System.Windows.Forms.Panel panel_TabFeed_Navigate;
        private System.Windows.Forms.Button button_TabFeed_Profile;
        private System.Windows.Forms.Button button_TabFeed_Albums;
        private System.Windows.Forms.Button button_TabFeed_Friends;
        private System.Windows.Forms.PictureBox pictureBox_TabFeed_IntroPic;
        private System.Windows.Forms.LinkLabel linkLabel_TabFeed_OpenPostInBrowser;
        private System.Windows.Forms.Button button_TabAlbums_Next;
        private System.Windows.Forms.Button button_TabAlbums_Prevoius;
        private System.Windows.Forms.PictureBox pictureBox_TabAlbums_ChooseYourAlbum;
        private System.Windows.Forms.Label label_TabFeed_CommentDate;
        private System.Windows.Forms.LinkLabel linkLabel_TabFeed_PostInfo;
        private System.Windows.Forms.PictureBox pictureBox_TabAlbums_FacebookLogo;
        private System.Windows.Forms.Button button_TabFeed_Feature2;
        private System.Windows.Forms.Button button_TabFeed_FaceRide;
        private System.Windows.Forms.TabPage tabPage_FaceRide;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_subTitle;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_Title;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_FacebookLogo;
        private System.Windows.Forms.CheckBox checkBox_TabFaceRide_Male;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_Location2;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_Radius;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_Destination;
        private System.Windows.Forms.Button button_TabFaceRide_LetsRide;
        private System.Windows.Forms.RichTextBox richTextBox_TabFaceRide_WhereTo;
        private System.Windows.Forms.RichTextBox richTextBox_TabFaceRide_WhereFrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_TabFaceRide_Female;
        private System.Windows.Forms.LinkLabel linkLabel_TabFaceRide_CurrentLocation;
        private System.Windows.Forms.ComboBox comboBox_TabFaceRide_Radius;
        private System.Windows.Forms.PictureBox pictureBox_TabFaceRide_Location;
        private System.Windows.Forms.LinkLabel linkLabel_TabFaceRide_ShowOnMap;
        private System.Windows.Forms.TextBox textBox_TabFaceRide_Km;
        private System.Windows.Forms.LinkLabel linkLabel_TabFaceRide_GetFromEvent;
        private System.Windows.Forms.TabPage tabPage_Contacts;
        private System.Windows.Forms.Panel panel_TabContacts;
        private System.Windows.Forms.DataGridView dataGridView_TabContacts;
        private System.Windows.Forms.Button button_TabContacts_DisplayContacts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.WebBrowser webBrowser_TabContacts;
        private System.Windows.Forms.Button button_TabContacts_Save;
        private System.Windows.Forms.TextBox textBox_TabFriends_FriendName;
        private System.Windows.Forms.Button button_TabFriends_Search;
        private IAppComponent userAlbumPicturesComponent_TabAlbums;
        private IAppComponent userProfileComponent_TabProfile;
        private IAppComponent userProfileComponent_TabFriends;
        private BindingSource AlbumsBindingSource;
        private ComboBox comboBox_TabAlbums_AlbumsList;
        private Button buttonSlideShow;
    }
}