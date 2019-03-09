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

namespace View
{
    public delegate void LoginDoneDelegate(User i_LoggedUser);

    public partial class LoginForm : Form
    {
        public event LoginDoneDelegate LoginSucess;
        public event LoginDoneDelegate LoginFailed;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void m_buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            LoginFailed.Invoke(null);
        }

        private void m_buttonLogin_Click(object sender, EventArgs e)
        {
            User user = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;
            Close();
            LoginSucess.Invoke(user);
        }
    }
}
