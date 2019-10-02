using System.Collections.Generic;
using System.Threading.Tasks;

namespace SlidingMenu.Models
{
    public class Contacts
    {
        public static IEnumerable<Contact> Get()
        {
            return new List<Contact>
            {
                new Contact() { FirstName="Suresh", LastName="Narayanan", Company="Google", JobTitle="iOS Developer",Email="suresh.n@cgvakindia.com",
                    Phone="2425254554", Street="23rd Street Extension", City="Chennai", PostalCode="641012", State="TamilNadu", PhotoUrl="profile01.png" },
                new Contact() { FirstName="Rajesh", LastName="Gopal", Company="Facebook", JobTitle="Android Developer",Email="rajesh.g@cgvakindia.com",
                    Phone="9559595934", Street="100th", City="Salem", PostalCode="641012", State="TamilNadu", PhotoUrl="profile02.png" },
                new Contact() { FirstName="Shankar", LastName="Mathesh", Company="Apple", JobTitle="iOS Developer",Email="shankar.m@cgvakindia.com",
                    Phone="5455342454", Street="1st", City="Coimbatore", PostalCode="641012", State="TamilNadu", PhotoUrl="profile03.png" },
                new Contact() { FirstName="Shree", LastName="Vairamuthu", Company="LinkedIn", JobTitle="Human Resource",Email="shree.v@cgvakindia.com",
                    Phone="5756784563", Street="1/2 Street", City="Madurai", PostalCode="641012", State="TamilNadu", PhotoUrl="profile04.png" },
                new Contact() { FirstName="Siva", LastName="Prakasam", Company="ZOHO", JobTitle="Test Engineer",Email="siva.p@cgvakindia.com",
                    Phone="3455342454", Street="6/7 Street", City="Erode", PostalCode="641012", State="TamilNadu", PhotoUrl="profile05.png" },
                new Contact() { FirstName="Venkat", LastName="Shanmugam", Company="Google", JobTitle="Xamarin Developer",Email="vankat.s@cgvakindia.com",
                    Phone="2425254554", Street="1st Street", City="Thirunelveli", PostalCode="641012", State="TamilNadu", PhotoUrl="profile06.png" }
            };
        }

    }
}
