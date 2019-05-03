using System;
using System.Collections.Generic;
using System.IO;
using FacebookWrapper.ObjectModel;
using Model.Interfaces;

namespace Model
{
    public class GoogleContact
    {
        #region Class Members / Properties
        private const string k_SearchProp = "String";
       
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
       
        public override string ToString()
        {
            return objectPropsToCsvString(this);
        }
        #endregion
    }
}
