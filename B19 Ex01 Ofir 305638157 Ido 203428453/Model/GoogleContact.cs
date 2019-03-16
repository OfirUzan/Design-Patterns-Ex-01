using System;
using System.Linq;
using System.Reflection;


namespace Model
{
    public class GoogleContact
    {
        private const string k_Csv_Head = "Name,Given Name,Additional Name,Family Name,Yomi Name,Given Name Yomi,Additional Name Yomi,Family Name Yomi,Name Prefix,Name Suffix,Initials,Nickname,Short Name,Maiden Name,Birthday,Gender,Location,Billing Information,Directory Server,Mileage,Occupation,Hobby,Sensitivity,Priority,Subject,Notes,Language,Photo,Group Membership,E-mail 1 - Type,E-mail 1 - Value,E-mail 2 - Type,E-mail 2 - Value,Phone 1 - Type,Phone 1 - Value,Phone 2 - Type,Phone 2 - Value,Phone 3 - Type,Phone 3 - Value,Phone 4 - Type,Phone 4 - Value,Phone 5 - Type,Phone 5 - Value,Address 1 - Type,Address 1 - Formatted,Address 1 - Street,Address 1 - City,Address 1 - PO Box,Address 1 - Region,Address 1 - Postal Code,Address 1 - Country,Address 1 - Extended Address,Organization 1 - Type,Organization 1 - Name,Organization 1 - Yomi Name,Organization 1 - Title,Organization 1 - Department,Organization 1 - Symbol,Organization 1 - Location,Organization 1 - Job Description,Website 1 - Type,Website 1 - Value";
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string Additional_Name { get; set; }
        public string Family_Name { get; set; }
        public string Yomi_Name { get; set; }
        public string Given_Name_Yomi { get; set; }
        public string Additional_Name_Yomi { get; set; }
        public string Family_Name_Yomi { get; set; }
        public string Name_Prefix { get; set; }
        public string Name_Suffix { get; set; }
        public string Initials { get; set; }
        public string Nickname { get; set; }
        public string Short_Name { get; set; }
        public string Maiden_Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Billing_Information { get; set; }
        public string Directory_Server { get; set; }
        public string Mileage { get; set; }
        public string Occupation { get; set; }
        public string Hobby { get; set; }
        public string Sensitivity { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public string Language { get; set; }
        public Uri Photo { get; set; }
        public string Group_Membershi { get; set; }
        public Email Email1 { get; set; }
        public Email Email2 { get; set; }
        public Phone Phone1 { get; set; }
        public Phone Phone2 { get; set; }
        public Phone Phone3 { get; set; }
        public Phone Phone4 { get; set; }
        public Phone Phone5 { get; set; }
        public Website Website1 { get; set; }

        public GoogleContact()
        {

        }

        public class Email
        {
            string Type { get; set; }
            string Value { get; set; }
            public Email() { }
            public override string ToString()
            {
                return GoogleContact.ObjectPropsToCsvString(this);
            }
        }

        public class Website
        {
            string Type { get; set; }
            string Value { get; set; }
            public Website() { }
            public override string ToString()
            {
                return GoogleContact.ObjectPropsToCsvString(this);
            }
        }

        public class Phone
        {
            string Type { get; set; }
            string Value { get; set; }
            public Phone()
            {

            }
            public override string ToString()
            {
                return GoogleContact.ObjectPropsToCsvString(this);
            }
        }

        public class Organization
        {
            string Type { get; set; }
            string Name { get; set; }
            string Yomi_Name { get; set; }
            string Title { get; set; }
            string Department { get; set; }
            string Symbol { get; set; }
            string Location { get; set; }
            string JobDescription { get; set; }
            public Organization()
            {

            }
            public override string ToString()
            {
                return GoogleContact.ObjectPropsToCsvString(this);
            }
        }

        public class Address
        {
            string Type { get; set; }
            string Formatted { get; set; }
            string Street { get; set; }
            string City { get; set; }
            string POBox { get; set; }
            string Region { get; set; }
            string Postal_Code { get; set; }
            string Country { get; set; }
            string Extended_Address { get; set; }
            public Address()
            {

            }
            public override string ToString()
            {
                return GoogleContact.ObjectPropsToCsvString(this);
            }
        }

        private static string ObjectPropsToCsvString(object t)
        {
            string res = null;

            foreach (var prop in t.GetType().GetProperties())
            {
                var propVal = prop.GetValue(t, null);
                if (propVal == null)
                {
                    res += "null, ";
                }
                else
                {
                    res += propVal.ToString();
                }
            }

            return res;
        }

        public override string ToString()
        {
            return ObjectPropsToCsvString(this);
        }

        public string Csv_Header()
        {
            return k_Csv_Head;
        }

    }
}
