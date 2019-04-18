using System;
using System.Collections.Generic;
using System.IO;
using Model.Interfaces;
using FacebookWrapper.ObjectModel;

namespace Model.Adapters
{
    public class GoogleContactListAdapter : IContactList
    {
        private const string k_CsvHeader = "Name,Given Name,Family Name,Nickname,Short Name,Maiden Name,User Name,Birthday,Gender,Location,Relationship Status,SignificantOther,Religion,Quotes,Locale,About,Language,Cover,Photo,E-mail 1 - Type,E-mail 1 - Value,E-mail 2 - Type,E-mail 2 - Value,Phone 1 - Type,Phone 1 - Value,Phone 2 - Type,Phone 2 - Value,Address 1 - Type,Address 1 - Formatted,Address 1 - Street,Address 1 - City,Address 1 - PO Box,Address 1 - Region,Address 1 - Postal Code,Address 1 - Country,Address 1 - Extended Address,Organization 1 - Type,Organization 1 - Name,Organization 1 - Yomi Name,Organization 1 - Title,Organization 1 - Department,Organization 1 - Symbol,Organization 1 - Location,Organization 1 - Job Description,Website 1 - Type,Website 1 - Value";
        private const string k_PopulateError = "Error: Populate contacts faild";
        private List<GoogleContact> ContactList { get; }
        private User m_FacebookUser;

        public GoogleContactListAdapter(User i_FacebookUser)
        {
            ContactList = new List<GoogleContact>();
            m_FacebookUser = i_FacebookUser;
            createContactList();
        }

        private void createContactList()
        {
            foreach (User friend in m_FacebookUser.Friends)
            {
                GoogleContact gContact = new GoogleContact();
                populate(gContact, friend);
                ContactList.Add(gContact);
            }
        }

        private void populate(GoogleContact i_Contact, User i_FacebookUser)
        {
            try
            {
                i_Contact.Birthday = m_FacebookUser.Birthday;
                i_Contact.Name = m_FacebookUser.Name;
                i_Contact.MaidenName = m_FacebookUser.MiddleName;
                i_Contact.Photo = m_FacebookUser.PictureNormalURL;
                i_Contact.FamilyName = m_FacebookUser.LastName;
                i_Contact.GivenName = m_FacebookUser.FirstName;
                if (m_FacebookUser.Hometown != null)
                {
                    i_Contact.Address1.City = m_FacebookUser.Hometown.Name;
                }

                i_Contact.Gender = m_FacebookUser.Gender.ToString();
                i_Contact.Email1.Value = m_FacebookUser.Email;
                if (m_FacebookUser.Cover != null)
                {
                    i_Contact.Cover = m_FacebookUser.Cover.SourceURL;
                }

                i_Contact.About = m_FacebookUser.About;
                i_Contact.Locale = m_FacebookUser.Locale;
                i_Contact.Religion = m_FacebookUser.Religion;
                i_Contact.RelationshipStatus = m_FacebookUser.RelationshipStatus.ToString();
                i_Contact.Quotes = m_FacebookUser.Quotes;
                i_Contact.UserName = m_FacebookUser.UserName;
                if (m_FacebookUser.SignificantOther != null)
                {
                    i_Contact.Name = m_FacebookUser.SignificantOther.Name;
                }

                i_Contact.Location = m_FacebookUser.Location.Name;
            }
            catch
            {
                throw new Exception(k_PopulateError);
            }

        }

        string IContactList.GetCsvHeader()
        {
            return k_CsvHeader;
        }

        void IContactList.MakeCsvFromContactList(string i_FilePath)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(i_FilePath, FileMode.Create, FileAccess.Write)))
            {
                writer.WriteLine(k_CsvHeader);
                foreach (GoogleContact contact in ContactList)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
        }
    }
}