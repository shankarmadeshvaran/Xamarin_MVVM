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
        public ContactsPage()
        {
            InitializeComponent();
            Title = "Contact Details";

            NavigationPage.SetHasBackButton(this, false);
            BindingContext = new ContactViewModel();
        }

        void Handle_Add_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactDetailPage());
        }

        async void Handle_list_itemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }

        private async void OnDetail(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                Contact selectedContact = menuItem.BindingContext as Contact;
                if (selectedContact != null)
                {
                    bool isCall = await this.DisplayAlert("Do you really want to Call?", selectedContact.FullName + "\n" + selectedContact.Phone
                        , "Call", "Cancel");

                    if (isCall)
                    {
                        //Go to Contacts App
                        Device.OpenUri(new Uri("tel:" + selectedContact.Phone));
                    }
                }
            }
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var collections = new ContactViewModel();
            Contact deleteContact;
            var result = await this.DisplayAlert("Alert!", "Are you sure you want to delete this contact?", "Yes", "No");
            if (result)
            {
                var menuitem = sender as MenuItem;
                deleteContact = menuitem.BindingContext as Contact;
                collections.AllContacts.Remove(collections.AllContacts.Where(i => i.UserId == deleteContact.UserId).Single());
                listView.ItemsSource = collections.AllContacts;
            }
        }

        public void addNewUserData(Contact newContact)
        {
            var collections = new ContactViewModel();
            collections.AllContacts.Add(newContact);
            listView.ItemsSource = collections.AllContacts;
        }

        public void updateEditedData(Contact editedContact)
        {
            var collections = new ContactViewModel();
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
