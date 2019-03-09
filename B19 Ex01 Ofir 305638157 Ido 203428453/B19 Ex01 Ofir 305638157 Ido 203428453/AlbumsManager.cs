using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B19_Ex01_Ofir_305638157_Ido_203428453
{
    public class AlbumsManager
    {
        private User m_User;
        private LinkedList<string> m_CurrentAlbumPhotosURL;
        private LinkedListNode<string> m_CurrentPhotoURL;
        public AlbumsManager(User i_User)
        {
            m_CurrentAlbumPhotosURL = new LinkedList<string>();
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

            if(m_CurrentPhotoURL.Next != null)
            {
                nextPhotoURL = m_CurrentPhotoURL.Next.Value;
                m_CurrentPhotoURL = m_CurrentPhotoURL.Next;
            }
            else
            {
                nextPhotoURL = m_CurrentAlbumPhotosURL.First.Value;
                m_CurrentPhotoURL = m_CurrentAlbumPhotosURL.First;
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
                previousPhotoURL = m_CurrentAlbumPhotosURL.Last.Value;
                m_CurrentPhotoURL = m_CurrentAlbumPhotosURL.Last;
            }

            return previousPhotoURL;
        }

        public void setCurrentAlbum(string i_AlbumName)
        {
            m_CurrentAlbumPhotosURL.Clear();
            Album photosAlbum = m_User.Albums.Find(x => x.Name == i_AlbumName);

            foreach (Photo photo in photosAlbum.Photos)
            {
                m_CurrentAlbumPhotosURL.AddLast(photo.PictureNormalURL);
            }

            m_CurrentPhotoURL = m_CurrentAlbumPhotosURL.First;
        }
    }
}
