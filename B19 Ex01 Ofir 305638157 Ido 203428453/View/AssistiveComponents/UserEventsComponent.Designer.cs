namespace View.AssistiveComponents
{
    public partial class UserEventsComponent
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
            this.m_dataGridViewUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.m_buttonGetEvents = new System.Windows.Forms.Button();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privacyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkToFacebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureSmallURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureNormalURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureLargeURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureSqaureURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageNormalDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageLargeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageSqaureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewUpcomingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dataGridViewUpcomingEvents
            // 
            this.m_dataGridViewUpcomingEvents.AllowUserToAddRows = false;
            this.m_dataGridViewUpcomingEvents.AllowUserToDeleteRows = false;
            this.m_dataGridViewUpcomingEvents.AutoGenerateColumns = false;
            this.m_dataGridViewUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridViewUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.privacyDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.linkToFacebookDataGridViewTextBoxColumn,
            this.timeStringDataGridViewTextBoxColumn,
            this.updateTimeStringDataGridViewTextBoxColumn,
            this.picturesDataGridViewTextBoxColumn,
            this.pictureSmallURLDataGridViewTextBoxColumn,
            this.pictureNormalURLDataGridViewTextBoxColumn,
            this.pictureLargeURLDataGridViewTextBoxColumn,
            this.pictureSqaureURLDataGridViewTextBoxColumn,
            this.imageSmallDataGridViewImageColumn,
            this.imageNormalDataGridViewImageColumn,
            this.imageLargeDataGridViewImageColumn,
            this.imageSqaureDataGridViewImageColumn,
            this.idDataGridViewTextBoxColumn});
            this.m_dataGridViewUpcomingEvents.DataSource = this.eventBindingSource;
            this.m_dataGridViewUpcomingEvents.Location = new System.Drawing.Point(67, 25);
            this.m_dataGridViewUpcomingEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_dataGridViewUpcomingEvents.Name = "m_dataGridViewUpcomingEvents";
            this.m_dataGridViewUpcomingEvents.ReadOnly = true;
            this.m_dataGridViewUpcomingEvents.RowTemplate.Height = 28;
            this.m_dataGridViewUpcomingEvents.Size = new System.Drawing.Size(643, 388);
            this.m_dataGridViewUpcomingEvents.TabIndex = 19;
            // 
            // m_buttonGetEvents
            // 
            this.m_buttonGetEvents.Location = new System.Drawing.Point(311, 418);
            this.m_buttonGetEvents.Name = "m_buttonGetEvents";
            this.m_buttonGetEvents.Size = new System.Drawing.Size(141, 45);
            this.m_buttonGetEvents.TabIndex = 20;
            this.m_buttonGetEvents.Text = "Get Events";
            this.m_buttonGetEvents.UseVisualStyleBackColor = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
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
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            this.venueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // privacyDataGridViewTextBoxColumn
            // 
            this.privacyDataGridViewTextBoxColumn.DataPropertyName = "Privacy";
            this.privacyDataGridViewTextBoxColumn.HeaderText = "Privacy";
            this.privacyDataGridViewTextBoxColumn.Name = "privacyDataGridViewTextBoxColumn";
            this.privacyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateTimeDataGridViewTextBoxColumn
            // 
            this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkToFacebookDataGridViewTextBoxColumn
            // 
            this.linkToFacebookDataGridViewTextBoxColumn.DataPropertyName = "LinkToFacebook";
            this.linkToFacebookDataGridViewTextBoxColumn.HeaderText = "LinkToFacebook";
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
            // updateTimeStringDataGridViewTextBoxColumn
            // 
            this.updateTimeStringDataGridViewTextBoxColumn.DataPropertyName = "UpdateTimeString";
            this.updateTimeStringDataGridViewTextBoxColumn.HeaderText = "UpdateTimeString";
            this.updateTimeStringDataGridViewTextBoxColumn.Name = "updateTimeStringDataGridViewTextBoxColumn";
            this.updateTimeStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picturesDataGridViewTextBoxColumn
            // 
            this.picturesDataGridViewTextBoxColumn.DataPropertyName = "Pictures";
            this.picturesDataGridViewTextBoxColumn.HeaderText = "Pictures";
            this.picturesDataGridViewTextBoxColumn.Name = "picturesDataGridViewTextBoxColumn";
            this.picturesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureSmallURLDataGridViewTextBoxColumn
            // 
            this.pictureSmallURLDataGridViewTextBoxColumn.DataPropertyName = "PictureSmallURL";
            this.pictureSmallURLDataGridViewTextBoxColumn.HeaderText = "PictureSmallURL";
            this.pictureSmallURLDataGridViewTextBoxColumn.Name = "pictureSmallURLDataGridViewTextBoxColumn";
            this.pictureSmallURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureNormalURLDataGridViewTextBoxColumn
            // 
            this.pictureNormalURLDataGridViewTextBoxColumn.DataPropertyName = "PictureNormalURL";
            this.pictureNormalURLDataGridViewTextBoxColumn.HeaderText = "PictureNormalURL";
            this.pictureNormalURLDataGridViewTextBoxColumn.Name = "pictureNormalURLDataGridViewTextBoxColumn";
            this.pictureNormalURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureLargeURLDataGridViewTextBoxColumn
            // 
            this.pictureLargeURLDataGridViewTextBoxColumn.DataPropertyName = "PictureLargeURL";
            this.pictureLargeURLDataGridViewTextBoxColumn.HeaderText = "PictureLargeURL";
            this.pictureLargeURLDataGridViewTextBoxColumn.Name = "pictureLargeURLDataGridViewTextBoxColumn";
            this.pictureLargeURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureSqaureURLDataGridViewTextBoxColumn
            // 
            this.pictureSqaureURLDataGridViewTextBoxColumn.DataPropertyName = "PictureSqaureURL";
            this.pictureSqaureURLDataGridViewTextBoxColumn.HeaderText = "PictureSqaureURL";
            this.pictureSqaureURLDataGridViewTextBoxColumn.Name = "pictureSqaureURLDataGridViewTextBoxColumn";
            this.pictureSqaureURLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageSmallDataGridViewImageColumn
            // 
            this.imageSmallDataGridViewImageColumn.DataPropertyName = "ImageSmall";
            this.imageSmallDataGridViewImageColumn.HeaderText = "ImageSmall";
            this.imageSmallDataGridViewImageColumn.Name = "imageSmallDataGridViewImageColumn";
            this.imageSmallDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageNormalDataGridViewImageColumn
            // 
            this.imageNormalDataGridViewImageColumn.DataPropertyName = "ImageNormal";
            this.imageNormalDataGridViewImageColumn.HeaderText = "ImageNormal";
            this.imageNormalDataGridViewImageColumn.Name = "imageNormalDataGridViewImageColumn";
            this.imageNormalDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageLargeDataGridViewImageColumn
            // 
            this.imageLargeDataGridViewImageColumn.DataPropertyName = "ImageLarge";
            this.imageLargeDataGridViewImageColumn.HeaderText = "ImageLarge";
            this.imageLargeDataGridViewImageColumn.Name = "imageLargeDataGridViewImageColumn";
            this.imageLargeDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageSqaureDataGridViewImageColumn
            // 
            this.imageSqaureDataGridViewImageColumn.DataPropertyName = "ImageSqaure";
            this.imageSqaureDataGridViewImageColumn.HeaderText = "ImageSqaure";
            this.imageSqaureDataGridViewImageColumn.Name = "imageSqaureDataGridViewImageColumn";
            this.imageSqaureDataGridViewImageColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // UserEventsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_buttonGetEvents);
            this.Controls.Add(this.m_dataGridViewUpcomingEvents);
            this.Name = "UserEventsComponent";
            this.Size = new System.Drawing.Size(785, 533);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewUpcomingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dataGridViewUpcomingEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToFacebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSmallURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureNormalURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLargeURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSqaureURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageNormalDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageLargeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageSqaureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Button m_buttonGetEvents;
    }
}
