using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AppController
    {
        public User User { get; set; }

        public User Friend { get; set; }

        public string GetFacebookUserInfo(User i_User)
        {
            return string.Format(
@"Name: {0}
Gender: {1}
Birthday: {2}
Email: {3}
City: {4}
Education: {5}
Work: {6}
Status: {7}
About: {8}",
                i_User.Name,
                i_User.Gender,
                i_User.Birthday,
                i_User.Email,
                i_User.Hometown?.Name,
                i_User.Educations?[0].School?.Name,
                i_User.WorkExperiences?[0].Name,
                i_User.RelationshipStatus,
                i_User.About
);
        }
    }
}
