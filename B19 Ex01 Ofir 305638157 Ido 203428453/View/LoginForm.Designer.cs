namespace View
{
    partial class LoginForm
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
            this.m_buttonLogin = new System.Windows.Forms.Button();
            this.m_buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_buttonLogin
            // 
            this.m_buttonLogin.Location = new System.Drawing.Point(76, 124);
            this.m_buttonLogin.Name = "m_buttonLogin";
            this.m_buttonLogin.Size = new System.Drawing.Size(160, 62);
            this.m_buttonLogin.TabIndex = 0;
            this.m_buttonLogin.Text = "Login";
            this.m_buttonLogin.UseVisualStyleBackColor = true;
            this.m_buttonLogin.Click += new System.EventHandler(this.m_buttonLogin_Click);
            // 
            // m_buttonExit
            // 
            this.m_buttonExit.Location = new System.Drawing.Point(320, 124);
            this.m_buttonExit.Name = "m_buttonExit";
            this.m_buttonExit.Size = new System.Drawing.Size(160, 62);
            this.m_buttonExit.TabIndex = 1;
            this.m_buttonExit.Text = "Exit";
            this.m_buttonExit.UseVisualStyleBackColor = true;
            this.m_buttonExit.Click += new System.EventHandler(this.m_buttonExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 315);
            this.Controls.Add(this.m_buttonExit);
            this.Controls.Add(this.m_buttonLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook For Desktop! - Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonLogin;
        private System.Windows.Forms.Button m_buttonExit;
    }
}