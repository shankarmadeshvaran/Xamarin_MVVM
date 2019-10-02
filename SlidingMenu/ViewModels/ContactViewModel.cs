using System;
using SlidingMenu.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SlidingMenu.ViewModels
{
    public class ContactViewModel
    {
        public List<Contact> allContacts { get; set; }

        public ContactViewModel()
        {
            allContacts = new List<Contact>(Contacts.Get());
        }
    }
}
