using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Model;

namespace View
{
    public delegate void LoginSucessDelegate(User i_LoggedUser);
    public delegate void LoginFailedDelegate();

    public partial class LoginForm : Form
    {
        #region Class Members / Properties
        private const string             k_InternetErrorMsg = "Please check your internet connection.";
        private FacebookAuthenticator    m_FacebookAuthenticator;
        public event LoginSucessDelegate LoginSucessListeners;
        public event LoginFailedDelegate LoginFailedListeners;
        #endregion

        #region Class Methods
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
                User user = m_FacebookAuthenticator.LoginUser();
                finishLoginWithSucess(user);
            }
            catch (Exception exception)
            {
                string errorMsg = exception.Message + System.Environment.NewLine + k_InternetErrorMsg;
                MessageBox.Show(errorMsg);
                finishLoginWithFailure();
            }
        }

        private void m_checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_FacebookAuthenticator.RememberUser = checkBox_RememberUser.Checked;
        }

        public LoginForm()
        {
            InitializeComponent();
            m_FacebookAuthenticator = new FacebookAuthenticator();
        }

        public void StartLoginSession()
        {
            User user = null;
            try
            {
                bool isLoggedIn = m_FacebookAuthenticator.IsUserLoggedIn(out user);

                if (isLoggedIn)
                {
                    finishLoginWithSucess(user);
                }
                else
                {
                    ShowDialog();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + "Acess token file has been corrupted?");
                m_FacebookAuthenticator.LogoutUser();
                ShowDialog();
            }
        }

        public void LogoutUser()
        {
            m_FacebookAuthenticator.LogoutUser();
            ShowDialog();
        }
        #endregion
    }
}
