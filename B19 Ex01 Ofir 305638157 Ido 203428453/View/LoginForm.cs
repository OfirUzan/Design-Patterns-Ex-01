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
    public delegate void LoginDoneDelegate(User i_LoggedUser);

    public partial class LoginForm : Form
    {
        public event LoginDoneDelegate LoginSucessListeners;
        public event LoginDoneDelegate LoginFailedListeners;
        private FacebookAuthenticator m_facebookAuthenticator;
        public LoginForm()
        {
            InitializeComponent();
            m_facebookAuthenticator = new FacebookAuthenticator();
        }

        private void finishLoginWithSucess(User i_User)
        {
            Close();
            LoginSucessListeners.Invoke(i_User);
        }

        private void finishLoginWithFailure()
        {
            Close();
            LoginFailedListeners.Invoke(null);
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
            User user;

            if (m_facebookAuthenticator.IsUserLoggedIn(out user))
            {
                finishLoginWithSucess(user);
            }
            else
            {
                ShowDialog();
            }
        }
    }
}
