namespace View
{
    public partial class SelectedRideFriendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedRideFriendForm));
            this.m_pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.m_pictureBoxFriendProfilePic = new System.Windows.Forms.PictureBox();
            this.m_textBoxFriendFirstName = new System.Windows.Forms.TextBox();
            this.m_textBoxFriendLastName = new System.Windows.Forms.TextBox();
            this.m_textBoxRequestText = new System.Windows.Forms.TextBox();
            this.m_buttonSendViaMessanger = new System.Windows.Forms.Button();
            this.m_buttonPostOnWall = new System.Windows.Forms.Button();
            this.m_pictureBox_Albums_FacebookLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFriendProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox_Albums_FacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pictureBoxTitle
            // 
            this.m_pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBoxTitle.Image")));
            this.m_pictureBoxTitle.Location = new System.Drawing.Point(251, 14);
            this.m_pictureBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_pictureBoxTitle.Name = "m_pictureBoxTitle";
            this.m_pictureBoxTitle.Size = new System.Drawing.Size(353, 79);
            this.m_pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxTitle.TabIndex = 0;
            this.m_pictureBoxTitle.TabStop = false;
            // 
            // m_pictureBoxFriendProfilePic
            // 
            this.m_pictureBoxFriendProfilePic.Location = new System.Drawing.Point(251, 123);
            this.m_pictureBoxFriendProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_pictureBoxFriendProfilePic.Name = "m_pictureBoxFriendProfilePic";
            this.m_pictureBoxFriendProfilePic.Size = new System.Drawing.Size(141, 122);
            this.m_pictureBoxFriendProfilePic.TabIndex = 1;
            this.m_pictureBoxFriendProfilePic.TabStop = false;
            // 
            // m_textBoxFriendFirstName
            // 
            this.m_textBoxFriendFirstName.Location = new System.Drawing.Point(397, 194);
            this.m_textBoxFriendFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_textBoxFriendFirstName.Name = "m_textBoxFriendFirstName";
            this.m_textBoxFriendFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_textBoxFriendFirstName.Size = new System.Drawing.Size(112, 22);
            this.m_textBoxFriendFirstName.TabIndex = 2;
            // 
            // m_textBoxFriendLastName
            // 
            this.m_textBoxFriendLastName.Location = new System.Drawing.Point(397, 223);
            this.m_textBoxFriendLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_textBoxFriendLastName.Name = "m_textBoxFriendLastName";
            this.m_textBoxFriendLastName.Size = new System.Drawing.Size(112, 22);
            this.m_textBoxFriendLastName.TabIndex = 3;
            // 
            // m_textBoxRequestText
            // 
            this.m_textBoxRequestText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxRequestText.BackColor = System.Drawing.Color.AliceBlue;
            this.m_textBoxRequestText.Location = new System.Drawing.Point(259, 277);
            this.m_textBoxRequestText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_textBoxRequestText.Multiline = true;
            this.m_textBoxRequestText.Name = "m_textBoxRequestText";
            this.m_textBoxRequestText.Size = new System.Drawing.Size(363, 162);
            this.m_textBoxRequestText.TabIndex = 13;
            this.m_textBoxRequestText.Tag = string.Empty;
            this.m_textBoxRequestText.Text = "[Request Text]";
            this.m_buttonSendViaMessanger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.m_buttonSendViaMessanger.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.m_buttonSendViaMessanger.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.m_buttonSendViaMessanger.Location = new System.Drawing.Point(469, 458);
            this.m_buttonSendViaMessanger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_buttonSendViaMessanger.Name = "m_buttonSendViaMessanger";
            this.m_buttonSendViaMessanger.Size = new System.Drawing.Size(153, 46);
            this.m_buttonSendViaMessanger.TabIndex = 14;
            this.m_buttonSendViaMessanger.Text = "Send via Messanger";
            this.m_buttonSendViaMessanger.UseVisualStyleBackColor = false;
            // 
            // m_buttonPostOnWall
            // 
            this.m_buttonPostOnWall.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.m_buttonPostOnWall.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.m_buttonPostOnWall.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.m_buttonPostOnWall.Location = new System.Drawing.Point(259, 458);
            this.m_buttonPostOnWall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_buttonPostOnWall.Name = "m_buttonPostOnWall";
            this.m_buttonPostOnWall.Size = new System.Drawing.Size(153, 46);
            this.m_buttonPostOnWall.TabIndex = 15;
            this.m_buttonPostOnWall.Text = "Post on Timeline";
            this.m_buttonPostOnWall.UseVisualStyleBackColor = false;
            // 
            // m_pictureBox_Albums_FacebookLogo
            // 
            this.m_pictureBox_Albums_FacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBox_Albums_FacebookLogo.Image")));
            this.m_pictureBox_Albums_FacebookLogo.Location = new System.Drawing.Point(1, 1);
            this.m_pictureBox_Albums_FacebookLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_pictureBox_Albums_FacebookLogo.Name = "m_pictureBox_Albums_FacebookLogo";
            this.m_pictureBox_Albums_FacebookLogo.Size = new System.Drawing.Size(119, 103);
            this.m_pictureBox_Albums_FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBox_Albums_FacebookLogo.TabIndex = 21;
            this.m_pictureBox_Albums_FacebookLogo.TabStop = false;
            // 
            // SelectedRideFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.m_pictureBox_Albums_FacebookLogo);
            this.Controls.Add(this.m_buttonPostOnWall);
            this.Controls.Add(this.m_buttonSendViaMessanger);
            this.Controls.Add(this.m_textBoxRequestText);
            this.Controls.Add(this.m_textBoxFriendLastName);
            this.Controls.Add(this.m_textBoxFriendFirstName);
            this.Controls.Add(this.m_pictureBoxFriendProfilePic);
            this.Controls.Add(this.m_pictureBoxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectedRideFriendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request A Ride";
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFriendProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox_Albums_FacebookLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pictureBoxTitle;
        private System.Windows.Forms.PictureBox m_pictureBoxFriendProfilePic;
        private System.Windows.Forms.TextBox m_textBoxFriendFirstName;
        private System.Windows.Forms.TextBox m_textBoxFriendLastName;
        private System.Windows.Forms.TextBox m_textBoxRequestText;
        private System.Windows.Forms.Button m_buttonSendViaMessanger;
        private System.Windows.Forms.Button m_buttonPostOnWall;
        private System.Windows.Forms.PictureBox m_pictureBox_Albums_FacebookLogo;
    }
}