using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;

namespace Model
{
    public class AlbumsManager
    {
        private User m_User;
        private LinkedListNode<string> m_CurrentPhotoURL;
        private object m_threadsLock = new object();

        public LinkedList<string> CurrentAlbumPhotosURL { get; set; }

        public AlbumsManager(User i_User)
        {
            CurrentAlbumPhotosURL = new LinkedList<string>();
            m_User = i_User;
        }

        public string GetLatestPhotoURL(string i_AlbumName)
        {
            Album photosAlbum = m_User.Albums.Find(x => x.Name == i_AlbumName);
            Photo latestPhoto = photosAlbum.Photos[0];
            return latestPhoto.PictureNormalURL;
        }

        public string GetNextPhotoURL()
        {
            string nextPhotoURL;

            lock (m_threadsLock)
            {
                if (m_CurrentPhotoURL.Next != null)
                {
                    nextPhotoURL = m_CurrentPhotoURL.Next.Value;
                    m_CurrentPhotoURL = m_CurrentPhotoURL.Next;
                }
                else
                {
                    nextPhotoURL = CurrentAlbumPhotosURL.First.Value;
                    m_CurrentPhotoURL = CurrentAlbumPhotosURL.First;
                };
            }

            return nextPhotoURL;
        }

        public string GetPreviousPhotoURL()
        {
            string previousPhotoURL;

            if (m_CurrentPhotoURL.Previous != null)
            {
                previousPhotoURL = m_CurrentPhotoURL.Previous.Value;
                m_CurrentPhotoURL = m_CurrentPhotoURL.Previous;
            }
            else
            {
                previousPhotoURL = CurrentAlbumPhotosURL.Last.Value;
                m_CurrentPhotoURL = CurrentAlbumPhotosURL.Last;
            }

            return previousPhotoURL;
        }

        public void setCurrentAlbum(string i_AlbumName)
        {
            CurrentAlbumPhotosURL.Clear();
            Album photosAlbum = m_User.Albums.Find(x => x.Name == i_AlbumName);
            
            foreach (Photo photo in photosAlbum.Photos)
            {
                CurrentAlbumPhotosURL.AddLast(photo.PictureNormalURL);
                
            }

            m_CurrentPhotoURL = CurrentAlbumPhotosURL.First;
        }

        // like counters
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
            foreach (var like in i_Photo.LikedBy)
            {
                res++;
            }

            return res;
        }

        private void countLikesOfPhotoByGender(Photo i_Photo, ref int r_MaleCount, ref int r_FemaleCount)
        {
            r_MaleCount = 0;
            r_FemaleCount = 0;
            foreach (var like in i_Photo.LikedBy)
            {
                if (like.Gender == User.eGender.male)
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

        public void UploadPhotoToCurrentAlbum(string i_PhotoLocalPath)
        {
            m_User.PostPhoto(i_PhotoLocalPath);
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
    }
}
