using System;
using System.Collections.Generic;
using System.IO;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class GoogleContact
    {
        #region Class Members / Properties
        private const string k_CsvHeader = "Name,Given Name,Family Name,Nickname,Short Name,Maiden Name,User Name,Birthday,Gender,Location,Relationship Status,SignificantOther,Religion,Quotes,Locale,About,Language,Cover,Photo,E-mail 1 - Type,E-mail 1 - Value,E-mail 2 - Type,E-mail 2 - Value,Phone 1 - Type,Phone 1 - Value,Phone 2 - Type,Phone 2 - Value,Address 1 - Type,Address 1 - Formatted,Address 1 - Street,Address 1 - City,Address 1 - PO Box,Address 1 - Region,Address 1 - Postal Code,Address 1 - Country,Address 1 - Extended Address,Organization 1 - Type,Organization 1 - Name,Organization 1 - Yomi Name,Organization 1 - Title,Organization 1 - Department,Organization 1 - Symbol,Organization 1 - Location,Organization 1 - Job Description,Website 1 - Type,Website 1 - Value";
        private const string k_SearchProp = "String";
        private const string k_PopulateError = "Error: Populate contacts faild";

        public class TypeValue
        {
            public string Type { get; set; }

            public string Value { get; set; }

            public override string ToString()
            {
                return GoogleContact.objectPropsToCsvString(this);
            }
        }
       
        public class Organization
        {
            public string Type { get; set; }

            public string Name { get; set; }

            public string Yomi_Name { get; set; }

            public string Title { get; set; }

            public string Department { get; set; }

            public string Symbol { get; set; }

            public string Location { get; set; }

            public string JobDescription { get; set; }

            public override string ToString()
            {
                return GoogleContact.objectPropsToCsvString(this);
            }
        }

        public class Address
        {
            public string Type { get; set; }

            public string Formatted { get; set; }

            public string Street { get; set; }

            public string City { get; set; }

            public string POBox { get; set; }

            public string Region { get; set; }

            public string Postal_Code { get; set; }

            public string Country { get; set; }

            public string Extended_Address { get; set; }

            public override string ToString()
            {
                return GoogleContact.objectPropsToCsvString(this);
            }
        }

        public string Name { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string Nickname { get; set; }

        public string ShortName { get; set; }

        public string MaidenName { get; set; }

        public string UserName { get; set; }

        public string Birthday { get; set; }

        public string Gender { get; set; }

        public string Location { get; set; }

        public string RelationshipStatus { get; set; }

        public string SignificantOther { get; set; }

        public string Religion { get; set; }

        public string Quotes { get; set; }

        public string Locale { get; set; }

        public string About { get; set; }

        public string Language { get; set; }

        public string Cover { get; set; }

        public string Photo { get; set; }

        public TypeValue Email1 { get; set; }

        public TypeValue Email2 { get; set; }

        public TypeValue Phone1 { get; set; }

        public TypeValue Phone2 { get; set; }

        public Address Address1 { get; set; }

        public Organization Organization1 { get; set; }

        public TypeValue Website1 { get; set; }
        #endregion

        #region Class Methods
        private static string objectPropsToCsvString(object t)
        {
            string res = null;
            bool first = true;

            foreach (var prop in t.GetType().GetProperties())
            {
                var propVal = prop.GetValue(t, null);
                if (propVal == null)
                {
                    res += ",--";
                    first = false;
                }
                else
                {
                    if(!first && (prop.PropertyType.Name == k_SearchProp))
                    {
                        res += ",";
                    }

                    first = false;
                    res += propVal.ToString();
                }
            }

            return res;
        }

        public GoogleContact()
        {
            Email1 = new TypeValue();
            Email2 = new TypeValue();
            Phone1 = new TypeValue();
            Phone2 = new TypeValue();
            Address1 = new Address();
            Website1 = new TypeValue();
            Organization1 = new Organization();
        }

        public void PopulateContactFromFacebookUser(User i_User)
        {
            try
            {
                this.Birthday = i_User.Birthday;
                this.Name = i_User.Name;
                this.MaidenName = i_User.MiddleName;
                this.Photo = i_User.PictureNormalURL;
                this.FamilyName = i_User.LastName;
                this.GivenName = i_User.FirstName;
                if (i_User.Hometown != null)
                {
                    this.Address1.City = i_User.Hometown.Name;
                }

                this.Gender = i_User.Gender.ToString();
                this.Email1.Value = i_User.Email;
                if (i_User.Cover != null)
                {
                    this.Cover = i_User.Cover.SourceURL;
                }

                this.About = i_User.About;
                this.Locale = i_User.Locale;
                this.Religion = i_User.Religion;
                this.RelationshipStatus = i_User.RelationshipStatus.ToString();
                this.Quotes = i_User.Quotes;
                this.UserName = i_User.UserName;
                if (i_User.SignificantOther != null)
                {
                    this.Name = i_User.SignificantOther.Name;
                }

                this.Location = i_User.Location.Name;
            }
            catch
            {
                throw new Exception(k_PopulateError);
            }
        }

        public static string GetCsvHeader()
        {
            return k_CsvHeader;
        }

        public static void MakeCsvFromContactList(LinkedList<GoogleContact> i_Contacts, string i_FilePath)
        {         
                using (StreamWriter writer = new StreamWriter(new FileStream(i_FilePath, FileMode.Create, FileAccess.Write)))
                {
                    writer.WriteLine(GoogleContact.GetCsvHeader());
                    foreach (GoogleContact contact in i_Contacts)
                    {
                        writer.WriteLine(contact.ToString());
                    }
                }  
        }

        public override string ToString()
        {
            return objectPropsToCsvString(this);
        }
        #endregion
    }
}
