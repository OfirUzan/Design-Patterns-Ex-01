using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;

namespace B19_Ex01_Ofir_305638157_Ido_203428453
{
    public partial class Form1 : Form
    {
        User m_User;

        public Form1()
        {
            InitializeComponent();
            //FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            //FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginAndInit()
        {
            m_User = FacebookService.Login("451139335614057", "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown").LoggedInUser;
            m_PB_UserProfilePic.LoadAsync(m_User.PictureNormalURL);
            label1.Text = m_User.FirstName;
            label2.Text = m_User.LastName;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
