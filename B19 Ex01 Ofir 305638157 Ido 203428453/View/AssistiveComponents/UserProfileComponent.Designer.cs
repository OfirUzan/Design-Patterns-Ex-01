using System.Windows.Forms;

namespace View
{
    public partial class UserProfileComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileComponent));
            this.m_ComponentBindingSourceFeed = new System.Windows.Forms.BindingSource(this.components);
            this.m_dataGridViewUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkToFacebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ComponentBindingSourceUpcomingEvents = new System.Windows.Forms.BindingSource(this.components);
            this.m_labelUpcomingEvents = new System.Windows.Forms.Label();
            this.m_labelBasicInformation = new System.Windows.Forms.Label();
            this.m_buttonPost = new System.Windows.Forms.Button();
            this.m_textBoxPostText = new System.Windows.Forms.TextBox();
            this.m_textBoxUserInfo = new System.Windows.Forms.TextBox();
            this.m_pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.m_buttonAttachAPicture = new System.Windows.Forms.Button();
            this.m_buttonGetEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ComponentBindingSourceFeed
            // 
            this.m_ComponentBindingSourceFeed.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // m_dataGridViewUpcomingEvents
            // 
            this.m_dataGridViewUpcomingEvents.AllowUserToAddRows = false;
            this.m_dataGridViewUpcomingEvents.AllowUserToDeleteRows = false;
            this.m_dataGridViewUpcomingEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dataGridViewUpcomingEvents.AutoGenerateColumns = false;
            this.m_dataGridViewUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.linkToFacebookDataGridViewTextBoxColumn,
            this.timeStringDataGridViewTextBoxColumn});
            this.m_dataGridViewUpcomingEvents.DataSource = this.m_ComponentBindingSourceUpcomingEvents;
            this.m_dataGridViewUpcomingEvents.Location = new System.Drawing.Point(509, 53);
            this.m_dataGridViewUpcomingEvents.Name = "m_dataGridViewUpcomingEvents";
            this.m_dataGridViewUpcomingEvents.ReadOnly = true;
            this.m_dataGridViewUpcomingEvents.RowTemplate.Height = 28;
            this.m_dataGridViewUpcomingEvents.Size = new System.Drawing.Size(597, 350);
            this.m_dataGridViewUpcomingEvents.TabIndex = 17;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkToFacebookDataGridViewTextBoxColumn
            // 
            this.linkToFacebookDataGridViewTextBoxColumn.DataPropertyName = "LinkToFacebook";
            this.linkToFacebookDataGridViewTextBoxColumn.HeaderText = "Link To Facebook";
            this.linkToFacebookDataGridViewTextBoxColumn.Name = "linkToFacebookDataGridViewTextBoxColumn";
            this.linkToFacebookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStringDataGridViewTextBoxColumn
            // 
            this.timeStringDataGridViewTextBoxColumn.DataPropertyName = "TimeString";
            this.timeStringDataGridViewTextBoxColumn.HeaderText = "TimeString";
            this.timeStringDataGridViewTextBoxColumn.Name = "timeStringDataGridViewTextBoxColumn";
            this.timeStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // m_ComponentBindingSourceUpcomingEvents
            // 
            this.m_ComponentBindingSourceUpcomingEvents.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // m_labelUpcomingEvents
            // 
            this.m_labelUpcomingEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_labelUpcomingEvents.AutoSize = true;
            this.m_labelUpcomingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_labelUpcomingEvents.Location = new System.Drawing.Point(504, 25);
            this.m_labelUpcomingEvents.Name = "m_labelUpcomingEvents";
            this.m_labelUpcomingEvents.Size = new System.Drawing.Size(187, 25);
            this.m_labelUpcomingEvents.TabIndex = 14;
            this.m_labelUpcomingEvents.Text = "Upcoming Events:";
            // 
            // m_labelBasicInformation
            // 
            this.m_labelBasicInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_labelBasicInformation.AutoSize = true;
            this.m_labelBasicInformation.BackColor = System.Drawing.SystemColors.Control;
            this.m_labelBasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_labelBasicInformation.Location = new System.Drawing.Point(136, 425);
            this.m_labelBasicInformation.Name = "m_labelBasicInformation";
            this.m_labelBasicInformation.Size = new System.Drawing.Size(185, 25);
            this.m_labelBasicInformation.TabIndex = 16;
            this.m_labelBasicInformation.Text = "Basic Information:";
            // 
            // m_buttonPost
            // 
            this.m_buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonPost.AutoSize = true;
            this.m_buttonPost.BackColor = System.Drawing.Color.DarkBlue;
            this.m_buttonPost.ForeColor = System.Drawing.Color.White;
            this.m_buttonPost.Location = new System.Drawing.Point(925, 748);
            this.m_buttonPost.Name = "m_buttonPost";
            this.m_buttonPost.Size = new System.Drawing.Size(181, 55);
            this.m_buttonPost.TabIndex = 13;
            this.m_buttonPost.Text = "Post";
            this.m_buttonPost.UseVisualStyleBackColor = false;
            // 
            // m_textBoxPostText
            // 
            this.m_textBoxPostText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxPostText.BackColor = System.Drawing.Color.AliceBlue;
            this.m_textBoxPostText.Location = new System.Drawing.Point(509, 453);
            this.m_textBoxPostText.Multiline = true;
            this.m_textBoxPostText.Name = "m_textBoxPostText";
            this.m_textBoxPostText.Size = new System.Drawing.Size(597, 289);
            this.m_textBoxPostText.TabIndex = 12;
            this.m_textBoxPostText.Tag = "Do you want to say anything?";
            this.m_textBoxPostText.Text = "Do you want to say anything?";
            this.m_textBoxPostText.Click += new System.EventHandler(this.m_textBoxPostText_Click);
            // 
            // m_textBoxUserInfo
            // 
            this.m_textBoxUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_textBoxUserInfo.Location = new System.Drawing.Point(79, 453);
            this.m_textBoxUserInfo.Multiline = true;
            this.m_textBoxUserInfo.Name = "m_textBoxUserInfo";
            this.m_textBoxUserInfo.ReadOnly = true;
            this.m_textBoxUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textBoxUserInfo.Size = new System.Drawing.Size(402, 350);
            this.m_textBoxUserInfo.TabIndex = 11;
            // 
            // m_pictureBoxProfilePic
            // 
            this.m_pictureBoxProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pictureBoxProfilePic.Location = new System.Drawing.Point(79, 53);
            this.m_pictureBoxProfilePic.Name = "m_pictureBoxProfilePic";
            this.m_pictureBoxProfilePic.Size = new System.Drawing.Size(413, 350);
            this.m_pictureBoxProfilePic.TabIndex = 10;
            this.m_pictureBoxProfilePic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 748);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // m_pictureBoxFacebookLogo
            // 
            this.m_pictureBoxFacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBoxFacebookLogo.Image")));
            this.m_pictureBoxFacebookLogo.Location = new System.Drawing.Point(4, 5);
            this.m_pictureBoxFacebookLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_pictureBoxFacebookLogo.Name = "m_pictureBoxFacebookLogo";
            this.m_pictureBoxFacebookLogo.Size = new System.Drawing.Size(68, 66);
            this.m_pictureBoxFacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxFacebookLogo.TabIndex = 19;
            this.m_pictureBoxFacebookLogo.TabStop = false;
            // 
            // m_buttonAttachAPicture
            // 
            this.m_buttonAttachAPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonAttachAPicture.AutoSize = true;
            this.m_buttonAttachAPicture.BackColor = System.Drawing.SystemColors.HotTrack;
            this.m_buttonAttachAPicture.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_buttonAttachAPicture.ForeColor = System.Drawing.Color.AliceBlue;
            this.m_buttonAttachAPicture.Location = new System.Drawing.Point(509, 748);
            this.m_buttonAttachAPicture.Name = "m_buttonAttachAPicture";
            this.m_buttonAttachAPicture.Size = new System.Drawing.Size(202, 55);
            this.m_buttonAttachAPicture.TabIndex = 20;
            this.m_buttonAttachAPicture.Text = "Attach A Picture";
            this.m_buttonAttachAPicture.UseVisualStyleBackColor = false;
            // 
            // m_buttonGetEvents
            // 
            this.m_buttonGetEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonGetEvents.AutoSize = true;
            this.m_buttonGetEvents.Location = new System.Drawing.Point(509, 413);
            this.m_buttonGetEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_buttonGetEvents.Name = "m_buttonGetEvents";
            this.m_buttonGetEvents.Size = new System.Drawing.Size(597, 37);
            this.m_buttonGetEvents.TabIndex = 21;
            this.m_buttonGetEvents.Text = "Get Events";
            this.m_buttonGetEvents.UseVisualStyleBackColor = true;
            // 
            // UserProfileComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.m_buttonGetEvents);
            this.Controls.Add(this.m_buttonAttachAPicture);
            this.Controls.Add(this.m_pictureBoxFacebookLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_dataGridViewUpcomingEvents);
            this.Controls.Add(this.m_labelUpcomingEvents);
            this.Controls.Add(this.m_labelBasicInformation);
            this.Controls.Add(this.m_buttonPost);
            this.Controls.Add(this.m_textBoxPostText);
            this.Controls.Add(this.m_textBoxUserInfo);
            this.Controls.Add(this.m_pictureBoxProfilePic);
            this.Name = "UserProfileComponent";
            this.Size = new System.Drawing.Size(1109, 871);
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ComponentBindingSourceUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxFacebookLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView m_dataGridViewUpcomingEvents;
        private System.Windows.Forms.Label m_labelUpcomingEvents;
        private System.Windows.Forms.Label m_labelBasicInformation;
        private System.Windows.Forms.Button m_buttonPost;
        private System.Windows.Forms.TextBox m_textBoxPostText;
        private System.Windows.Forms.TextBox m_textBoxUserInfo;
        private System.Windows.Forms.PictureBox m_pictureBoxProfilePic;
        private System.Windows.Forms.BindingSource m_ComponentBindingSourceFeed;
        private System.Windows.Forms.BindingSource m_ComponentBindingSourceUpcomingEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToFacebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStringDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private PictureBox m_pictureBoxFacebookLogo;
        private Button m_buttonAttachAPicture;
        private Button m_buttonGetEvents;
    }
}