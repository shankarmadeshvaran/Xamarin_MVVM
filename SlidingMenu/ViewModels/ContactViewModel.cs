using System;
using SlidingMenu.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SlidingMenu.Views;
using System.Windows.Input;
using System.Linq;

namespace SlidingMenu.ViewModels
{
 
    public class ContactViewModel
    {
        public ContactsPage ContactsPage { get; set; }
        public ObservableCollection<Contact> List { get; set; } = new ObservableCollection<Contact>();
        public ICommand AddButtonClickedCommand { get; set; }

        public ICommand OnDetailClickedCommand { get; set; }
        public ICommand OnDeleteClickedCommand { get; set; }

        public ObservableCollection<Contact> AllContacts { get; set; }

        public ContactViewModel(ContactsPage _ContactsPage)
        {
            ContactsPage = _ContactsPage;

            AllContacts = new ObservableCollection<Contact>(Contacts.Get());
            AddButtonClickedCommand = new Command(AddBtnClickedOperation);

            OnDetailClickedCommand = new Command<Contact>(CallContact);
            OnDeleteClickedCommand = new Command<Contact>(DeleteContactFromDetails);
        }

        public async void DeleteContactFromDetails(Contact deleteContact)
        {
            Console.WriteLine(deleteContact.FullName);

            var result = await ContactsPage.DisplayAlert("Alert!", "Are you sure you want to delete this contact?", "Yes", "No");
            if (result)
            {
                this.AllContacts.Remove(AllContacts.Single(i => i.UserId == deleteContact.UserId));
            }
        }

        public async void CallContact(Contact callingContact)
        {
            if (callingContact != null)
            {
                var message = callingContact.FullName + "\n" + callingContact.Phone;
                bool isCall = await ContactsPage.DisplayAlert("Do you really want to Call?", message, "Call", "Cancel");
                if (isCall)
                {
                    //Go to Contacts App
                    Device.OpenUri(new Uri("tel:" + callingContact.Phone));
                }
            }
        }

        public async void AddBtnClickedOperation()
        {
           await ContactsPage.Navigation.PushAsync(new ContactDetailPage());
        }

    }
}
