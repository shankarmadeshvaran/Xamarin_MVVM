using System;
using SlidingMenu.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SlidingMenu.ViewModels
{
    public class ContactViewModel
    {
        public ObservableCollection<Contact> AllContacts { get; set; }

        public ContactViewModel()
        {
            AllContacts = new ObservableCollection<Contact>(Contacts.Get());
        }
    }
}
