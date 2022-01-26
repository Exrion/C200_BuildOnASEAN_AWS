using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class Contact
    {
        [Range(1, int.MaxValue, ErrorMessage = "Integer out of range")]
        public int Officer_id { get; set; }
        [Required]
        [StringLength(int.MaxValue ,MinimumLength = 2, ErrorMessage = "Name cannot be less than 2 characters")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        public int Contact_no { get; set; }
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Invalid date")]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Select a location")]
        public string Location_Location_id { get; set; }
        public string Location_name { get; set; }
        [Required(ErrorMessage = "Select an organisation")]
        public int Organisation_Organisation_id { get; set; }
        public string Company_name { get; set; }
        [Required(ErrorMessage = "Select a notification id")]
        public int Notification_Notification_id { get; set; }
    }

    public class Contact_Data
    {
        public List<Location_Data> locationData { get; set; }
        public List<Organisation_Data> orgData { get; set; }
        public List<int> notiData { get; set; }
    }

    public class Location_Data
    {
        public string Location_id { get; set; }
        public string Location_name { get; set; }
    }

    public class Organisation_Data
    {
        public int Organisation_id { get; set; }
        public string Company_name { get; set; }
    }

    public class Contact_Package
    {
        public Contact_Package(Contact contact, Contact_Data contactData)
        {
            this.contact = contact;
            this.contactData = contactData;
        }

        public Contact contact { get; set; }
        public Contact_Data contactData { get; set; }

        public static Contact_Data GetContactData()
        {
            Contact_Data conData = new Contact_Data();
            conData.locationData = GetLocationData();
            conData.orgData = GetOrgData();
            conData.notiData = GetNotiData();
            return conData;
        }

        private static List<Location_Data> GetLocationData()
        {
            string sql = "SELECT Location_id, Location_name FROM Location";
            List<Location_Data> dataList = DBUtl.GetList<Location_Data>(sql);
            return dataList;
        }

        private static List<Organisation_Data> GetOrgData()
        {
            string sql = "SELECT Organisation_id, Company_name FROM Organisation";
            List<Organisation_Data> dataList = DBUtl.GetList<Organisation_Data>(sql);
            return dataList;
        }

        private static List<int> GetNotiData()
        {
            string sql = "SELECT Notification_id FROM Notification";
            List<int> dataList = DBUtl.GetList<int>(sql);
            return dataList;
        }
    }
}
