namespace View
{
    public partial class RideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RideForm));
            this.m_dataGridView_Friends = new System.Windows.Forms.DataGridView();
            this.m_bindingSource_Friends = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.m_profilePicColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.m_firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView_Friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bindingSource_Friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dataGridView_Friends
            // 
            this.m_dataGridView_Friends.AllowUserToAddRows = false;
            this.m_dataGridView_Friends.AutoGenerateColumns = false;
            this.m_dataGridView_Friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridView_Friends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_profilePicColumn,
            this.m_firstNameColumn,
            this.m_lastNameColumn,
            this.m_locationColumn,
            this.m_emailColumn});
            this.m_dataGridView_Friends.DataSource = this.m_bindingSource_Friends;
            this.m_dataGridView_Friends.Location = new System.Drawing.Point(107, 168);
            this.m_dataGridView_Friends.Name = "m_dataGridView_Friends";
            this.m_dataGridView_Friends.RowHeadersWidth = 42;
            this.m_dataGridView_Friends.RowTemplate.Height = 50;
            this.m_dataGridView_Friends.Size = new System.Drawing.Size(725, 346);
            this.m_dataGridView_Friends.TabIndex = 0;
            // 
            // m_bindingSource_Friends
            // 
            this.m_bindingSource_Friends.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // m_profilePicColumn
            // 
            this.m_profilePicColumn.DataPropertyName = "ImageSmall";
            this.m_profilePicColumn.HeaderText = "Profile Picture";
            this.m_profilePicColumn.Name = "m_profilePicColumn";
            this.m_profilePicColumn.ReadOnly = true;
            // 
            // m_firstNameColumn
            // 
            this.m_firstNameColumn.DataPropertyName = "FirstName";
            this.m_firstNameColumn.HeaderText = "First Name";
            this.m_firstNameColumn.Name = "m_firstNameColumn";
            this.m_firstNameColumn.ReadOnly = true;
            // 
            // m_lastNameColumn
            // 
            this.m_lastNameColumn.DataPropertyName = "LastName";
            this.m_lastNameColumn.HeaderText = "Last Name";
            this.m_lastNameColumn.Name = "m_lastNameColumn";
            this.m_lastNameColumn.ReadOnly = true;
            // 
            // m_locationColumn
            // 
            this.m_locationColumn.HeaderText = "Location";
            this.m_locationColumn.Name = "m_locationColumn";
            this.m_locationColumn.ReadOnly = true;
            // 
            // m_emailColumn
            // 
            this.m_emailColumn.DataPropertyName = "Email";
            this.m_emailColumn.HeaderText = "Email";
            this.m_emailColumn.Name = "m_emailColumn";
            this.m_emailColumn.ReadOnly = true;
            // 
            // RideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 535);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_dataGridView_Friends);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Riding Friend";
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView_Friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bindingSource_Friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dataGridView_Friends;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource m_bindingSource_Friends;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewImageColumn m_profilePicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_locationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_emailColumn;
    }
}