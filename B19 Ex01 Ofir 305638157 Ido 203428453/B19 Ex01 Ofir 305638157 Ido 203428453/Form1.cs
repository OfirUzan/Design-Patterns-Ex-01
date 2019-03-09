﻿using FacebookWrapper.ObjectModel;
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
        private User m_User;
        private AlbumsManager m_AlbumsManager;
        private LinkedList<string> m_CurrentAlbumPhotosURL;

        public Form1()
        {
            InitializeComponent();
            //FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            //FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginAndInit()
        {
            m_User = FacebookService.Login(
                "451139335614057",
                "public_profile",
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
                "user_hometown")
                .LoggedInUser;
            m_AlbumsManager = new AlbumsManager(m_User);
            m_PB_UserProfilePic.LoadAsync(m_User.PictureNormalURL);
            label1.Text = m_User.FirstName;
            label2.Text = m_User.LastName;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_User.Albums)
            {
                m_comboBoxAlbums.Items.Add(album.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAndInit();
            setTabProfile();
        }

        private void setTabProfile()
        {
            m_PB_TabProfile_CoverPhoto.LoadAsync(mostLikedPictureFromAlbum("Cover Photos"));
            m_PB_TabProfile_ProfilePic.LoadAsync(m_User.PictureNormalURL);
            m_Label_TabProfile_FullName.Text = m_User.Name;
        }

        private string mostLikedPictureFromAlbum(string i_AlbumName)
        {
            int maxLikes = 0;
            Photo res = null;

            Album profilePicAlbum = m_User.Albums.Find(x => x.Name == i_AlbumName);
            if (profilePicAlbum == null)
            {
                // Album Not Found Exeption
            }
            else
            {
                foreach (var p in profilePicAlbum.Photos)
                {
                    if (sumPhotoLikes(p) > maxLikes)
                    {
                        res = p;
                    }
                }
            }

            return res.Pictures.PictureUrl;
        }

        private int sumAlbumLikes(Album i_Album)
        {
            int res = 0;
            foreach (var p in i_Album.Photos)
            {
                res += sumPhotoLikes(p);
            }

            return res;
        }

        private int sumPhotoLikes(Photo i_Photo)
        {
            int res = 0;
            foreach(var like in i_Photo.LikedBy)
            {
                res++;
            }

            return res;
        }

        private void countLikesOfPhotoByGender(Photo i_Photo ,ref int r_MaleCount, ref int r_FemaleCount)
        {
            r_MaleCount = 0;
            r_FemaleCount = 0;
            foreach (var like in i_Photo.LikedBy)
            {
                if(like.Gender == User.eGender.male)
                {
                    r_MaleCount++;
                }
                else if (like.Gender == User.eGender.female)
                {
                    r_FemaleCount++;
                }

            }
        }

        private void countLikesOfAlbumByGender(Album i_Album, ref int r_MaleCount, ref int r_FemaleCount)
        {
            r_MaleCount = 0;
            r_FemaleCount = 0;
            foreach (var photo in i_Album.Photos)
            {
                int male = 0, female = 0;
                countLikesOfPhotoByGender(photo, ref male, ref female);
                r_MaleCount += male;
                r_FemaleCount += female;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void m_comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            string albumName = m_comboBoxAlbums.SelectedItem.ToString();
            m_AlbumsManager.setCurrentAlbum(albumName);
            m_pictureBoxCurrentPic.ImageLocation = m_AlbumsManager.GetLatestPhotoURL(albumName);
            m_pictureBoxCurrentPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string nextPhotoUrl = m_AlbumsManager.GetNextPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = nextPhotoUrl;
        }

        private void m_buttonPrevoiusPic_Click(object sender, EventArgs e)
        {
            string previousPhotoUrl = m_AlbumsManager.GetPreviousPhotoURL();
            m_pictureBoxCurrentPic.ImageLocation = previousPhotoUrl;
        }
    }
}
