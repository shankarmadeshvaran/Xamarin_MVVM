using System;
namespace SlidingMenu.Models
{
    public class Contact
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhotoUrl { get; set; }
        public string State { get; set; }

        public string FullName => FirstName + " " + LastName;
        public string Address => Street + "," + City + "," + PostalCode + "," + State;
    }
}
