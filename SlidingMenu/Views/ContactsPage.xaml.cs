using SlidingMenu.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SlidingMenu.Models;
using System;
using System.Linq;

namespace SlidingMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactViewModel collections;
        public ContactsPage()
        {
            InitializeComponent();
            Title = "Contact Details";

            NavigationPage.SetHasBackButton(this, false);
            BindingContext = new ContactViewModel(this);
            collections = new ContactViewModel(this);
        }

        async void Handle_list_itemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            listView.SelectedItem = null;
            await Navigation.PushAsync(new ContactDetailPage(contact));
        }

        public void AddNewUserData(Contact newContact)
        {
            collections.AllContacts.Add(newContact);
            listView.ItemsSource = collections.AllContacts;
        }

        public void UpdateEditedData(Contact editedContact)
        {
            foreach (var data in collections.AllContacts)
            {
                if (data.UserId == editedContact.UserId)
                {
                    data.FirstName = editedContact.FirstName;
                    data.LastName = editedContact.LastName;
                    data.Company = editedContact.Company;
                    data.Email = editedContact.Email;
                    data.JobTitle = editedContact.JobTitle;
                    data.Phone = editedContact.Phone;
                    data.Street = editedContact.Street;
                    data.City = editedContact.City;
                    data.PostalCode = editedContact.PostalCode;
                    data.State = editedContact.State;
                }
            }
            listView.ItemsSource = collections.AllContacts;
        }
    }
}
