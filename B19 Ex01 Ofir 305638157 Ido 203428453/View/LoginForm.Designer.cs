using System.Windows.Forms;

namespace View
{
    public partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.checkBox_RememberUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // m_buttonLogin
            // 
            this.button_Login.Location = new System.Drawing.Point(76, 124);
            this.button_Login.Name = "m_buttonLogin";
            this.button_Login.Size = new System.Drawing.Size(160, 62);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.m_buttonLogin_Click);
            // 
            // m_buttonExit
            // 
            this.button_Exit.Location = new System.Drawing.Point(320, 124);
            this.button_Exit.Name = "m_buttonExit";
            this.button_Exit.Size = new System.Drawing.Size(160, 62);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.m_buttonExit_Click);
            // 
            // m_checkBoxRememberUser
            // 
            this.checkBox_RememberUser.AutoSize = true;
            this.checkBox_RememberUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_RememberUser.Location = new System.Drawing.Point(76, 203);
            this.checkBox_RememberUser.Name = "m_checkBoxRememberUser";
            this.checkBox_RememberUser.Size = new System.Drawing.Size(122, 21);
            this.checkBox_RememberUser.TabIndex = 2;
            this.checkBox_RememberUser.Text = "Remember Me";
            this.checkBox_RememberUser.UseVisualStyleBackColor = false;
            this.checkBox_RememberUser.CheckedChanged += new System.EventHandler(this.m_checkBoxRememberUser_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.checkBox_RememberUser);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook For Desktop! - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Exit;
        private CheckBox checkBox_RememberUser;
    }
}