namespace View
{
    public partial class UserEventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEventsForm));
            this.m_userEventsComponent = new View.AssistiveComponents.UserEventsComponent();
            this.SuspendLayout();
            // 
            // m_userEventsComponent
            // 
            this.m_userEventsComponent.Location = new System.Drawing.Point(102, 64);
            this.m_userEventsComponent.Name = "m_userEventsComponent";
            this.m_userEventsComponent.Size = new System.Drawing.Size(725, 471);
            this.m_userEventsComponent.TabIndex = 0;
            // 
            // UserEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 626);
            this.Controls.Add(this.m_userEventsComponent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upcoming Events";
            this.ResumeLayout(false);

        }

        #endregion

        private AssistiveComponents.UserEventsComponent m_userEventsComponent;
    }
}