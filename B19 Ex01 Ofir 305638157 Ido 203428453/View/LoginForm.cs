using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Model;

namespace View
{
    public delegate void LoginSucessDelegate(User i_LoggedUser);
    public delegate void LoginFailedDelegate();

    public partial class LoginForm : Form
    {
        public event LoginSucessDelegate LoginSucessListeners;
        public event LoginFailedDelegate LoginFailedListeners;
        private FacebookAuthenticator m_facebookAuthenticator;
        public LoginForm()
        {
            InitializeComponent();
            m_facebookAuthenticator = new FacebookAuthenticator();
        }

        private void finishLoginWithSucess(User i_User)
        {
            Hide();
            Close();
            LoginSucessListeners.Invoke(i_User);
        }

        private void finishLoginWithFailure()
        {
            Hide();
            Close();
            LoginFailedListeners.Invoke();
        }

        private void m_buttonExit_Click(object sender, EventArgs e)
        {
            finishLoginWithFailure();
        }

        private void m_buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = m_facebookAuthenticator.LoginUser();
                finishLoginWithSucess(user);
            }
            catch (Exception exception)
            {
                string errorMsg = exception.Message + System.Environment.NewLine + "Please check your internet connection.";
                MessageBox.Show(errorMsg);
                finishLoginWithFailure();
            }
        }

        public void StartLoginSession()
        {
            //Change next line to null
            User user = FacebookService.Connect("EAAGaTwZCX7mkBAK93KkGatqUwhdljP2lQ9TXEK4RfA8xpfYZBeYeLf3hI5Sa0nw9JvrTy5eYjv1lbznBq6LI0KtozQQQBm39LBNk3VXnZBBKIMeiOeNEhlj1ZC7UId1Pm7qUVZBnh8WwKuKFIOJT130VEZCxaZBOm6hClZAGjdxbLQZDZD").LoggedInUser;
            //delete next line
            finishLoginWithSucess(user);
            bool isLoggedIn = m_facebookAuthenticator.IsUserLoggedIn(out user);

            if (isLoggedIn)
            {
                finishLoginWithSucess(user);
            }
            else
            {
                ShowDialog();
            }
        }

        public void LogoutUser()
        {
            m_facebookAuthenticator.LogoutUser();
            ShowDialog();
        }

        private void m_checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_facebookAuthenticator.RememberUser = m_checkBoxRememberUser.Checked;
        }
    }
}
