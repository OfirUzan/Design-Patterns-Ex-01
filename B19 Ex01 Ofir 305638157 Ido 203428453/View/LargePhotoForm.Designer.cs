namespace View
{
    public partial class LargePhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LargePhotoForm));
            this.m_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pictureBox
            // 
            this.m_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_pictureBox.Name = "m_pictureBox";
            this.m_pictureBox.Size = new System.Drawing.Size(705, 500);
            this.m_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBox.TabIndex = 0;
            this.m_pictureBox.TabStop = false;
            // 
            // LargePhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.m_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LargePhotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo";
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pictureBox;
    }
}