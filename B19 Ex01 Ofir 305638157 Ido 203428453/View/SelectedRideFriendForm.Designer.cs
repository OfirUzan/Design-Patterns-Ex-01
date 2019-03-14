﻿namespace View
{
    partial class SelectedRideFriendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedRideFriendForm));
            this.m_pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.m_pictureBoxFriendProfilePic = new System.Windows.Forms.PictureBox();
            this.m_textBoxFriendFirstName = new System.Windows.Forms.TextBox();
            this.m_textBoxFriendLastName = new System.Windows.Forms.TextBox();
            this.m_textBoxRequestText = new System.Windows.Forms.TextBox();
            this.m_buttonPostOnMessanger = new System.Windows.Forms.Button();
            this.m_buttonPostOnWall = new System.Windows.Forms.Button();
            this.m_bindingSourceSelectedFriend = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFriendProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bindingSourceSelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pictureBoxTitle
            // 
            this.m_pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBoxTitle.Image")));
            this.m_pictureBoxTitle.Location = new System.Drawing.Point(12, 12);
            this.m_pictureBoxTitle.Name = "m_pictureBoxTitle";
            this.m_pictureBoxTitle.Size = new System.Drawing.Size(353, 79);
            this.m_pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxTitle.TabIndex = 0;
            this.m_pictureBoxTitle.TabStop = false;
            // 
            // m_pictureBoxFriendProfilePic
            // 
            this.m_pictureBoxFriendProfilePic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.m_bindingSourceSelectedFriend, "PictureNormalURL", true));
            this.m_pictureBoxFriendProfilePic.Location = new System.Drawing.Point(12, 97);
            this.m_pictureBoxFriendProfilePic.Name = "m_pictureBoxFriendProfilePic";
            this.m_pictureBoxFriendProfilePic.Size = new System.Drawing.Size(231, 210);
            this.m_pictureBoxFriendProfilePic.TabIndex = 1;
            this.m_pictureBoxFriendProfilePic.TabStop = false;
            // 
            // m_textBoxFriendFirstName
            // 
            this.m_textBoxFriendFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_bindingSourceSelectedFriend, "FirstName", true));
            this.m_textBoxFriendFirstName.Location = new System.Drawing.Point(249, 114);
            this.m_textBoxFriendFirstName.Name = "m_textBoxFriendFirstName";
            this.m_textBoxFriendFirstName.Size = new System.Drawing.Size(143, 22);
            this.m_textBoxFriendFirstName.TabIndex = 2;
            // 
            // m_textBoxFriendLastName
            // 
            this.m_textBoxFriendLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_bindingSourceSelectedFriend, "LastName", true));
            this.m_textBoxFriendLastName.Location = new System.Drawing.Point(249, 153);
            this.m_textBoxFriendLastName.Name = "m_textBoxFriendLastName";
            this.m_textBoxFriendLastName.Size = new System.Drawing.Size(143, 22);
            this.m_textBoxFriendLastName.TabIndex = 3;
            // 
            // m_textBoxRequestText
            // 
            this.m_textBoxRequestText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxRequestText.BackColor = System.Drawing.Color.AliceBlue;
            this.m_textBoxRequestText.Location = new System.Drawing.Point(259, 307);
            this.m_textBoxRequestText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_textBoxRequestText.Multiline = true;
            this.m_textBoxRequestText.Name = "m_textBoxRequestText";
            this.m_textBoxRequestText.Size = new System.Drawing.Size(363, 132);
            this.m_textBoxRequestText.TabIndex = 13;
            this.m_textBoxRequestText.Tag = "";
            this.m_textBoxRequestText.Text = "[Request Text]";
            // 
            // m_buttonPostOnMessanger
            // 
            this.m_buttonPostOnMessanger.Location = new System.Drawing.Point(469, 456);
            this.m_buttonPostOnMessanger.Name = "m_buttonPostOnMessanger";
            this.m_buttonPostOnMessanger.Size = new System.Drawing.Size(153, 45);
            this.m_buttonPostOnMessanger.TabIndex = 14;
            this.m_buttonPostOnMessanger.Text = "Send FaceRide request via Messanger";
            this.m_buttonPostOnMessanger.UseVisualStyleBackColor = true;
            // 
            // m_buttonPostOnWall
            // 
            this.m_buttonPostOnWall.Location = new System.Drawing.Point(259, 456);
            this.m_buttonPostOnWall.Name = "m_buttonPostOnWall";
            this.m_buttonPostOnWall.Size = new System.Drawing.Size(153, 45);
            this.m_buttonPostOnWall.TabIndex = 15;
            this.m_buttonPostOnWall.Text = "Post FaceRide request on Timeline";
            this.m_buttonPostOnWall.UseVisualStyleBackColor = true;
            // 
            // m_bindingSourceSelectedFriend
            // 
            this.m_bindingSourceSelectedFriend.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // SelectedRideFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 554);
            this.Controls.Add(this.m_buttonPostOnWall);
            this.Controls.Add(this.m_buttonPostOnMessanger);
            this.Controls.Add(this.m_textBoxRequestText);
            this.Controls.Add(this.m_textBoxFriendLastName);
            this.Controls.Add(this.m_textBoxFriendFirstName);
            this.Controls.Add(this.m_pictureBoxFriendProfilePic);
            this.Controls.Add(this.m_pictureBoxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectedRideFriendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request A Ride";
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFriendProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bindingSourceSelectedFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pictureBoxTitle;
        private System.Windows.Forms.PictureBox m_pictureBoxFriendProfilePic;
        private System.Windows.Forms.TextBox m_textBoxFriendFirstName;
        private System.Windows.Forms.TextBox m_textBoxFriendLastName;
        private System.Windows.Forms.TextBox m_textBoxRequestText;
        private System.Windows.Forms.Button m_buttonPostOnMessanger;
        private System.Windows.Forms.Button m_buttonPostOnWall;
        private System.Windows.Forms.BindingSource m_bindingSourceSelectedFriend;
    }
}