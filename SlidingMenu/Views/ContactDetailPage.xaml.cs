using System;
using System.Collections.Generic;
using SlidingMenu.Models;
using Xamarin.Forms;

namespace SlidingMenu.Views
{
    public partial class ContactDetailPage : ContentPage
    {
        public Contact contactDetails;
        Contact newContact;
        public bool isAdd;

        public ContactDetailPage(Contact contact = null)
        {
            InitializeComponent();
            contactDetails = contact;

            if (contact == null)
            {
                Title = "New Contact Detail";
                isAdd = true;
                saveButton.Text = "Add";
                Emp_id.IsVisible = true;
            }
            else
            {
                Title = "Edit Contact Detail";
                isAdd = false;
                BindingContext = contact;
                Emp_id.IsVisible = false;
                saveButton.Text = "Save";
            }
        }

        async void Handle_Save_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var contactsPage = new ContactsPage();
                if (isAdd)
                {
                    newContact = new Contact
                    {
                        UserId = userId.Text,
                        FirstName = firstName.Text,
                        LastName = lastName.Text,
                        Company = company.Text,
                        Email = email.Text,
                        JobTitle = jobTitle.Text,
                        Phone = phone.Text,
                        Street = street.Text,
                        City = city.Text,
                        PostalCode = postalCode.Text,
                        State = state.Text,

                        PhotoUrl = "profile07.png"
                    };
                    contactsPage.AddNewUserData(newContact: newContact);
                }
                else
                {
                    contactsPage.UpdateEditedData(editedContact: contactDetails);
                }
                await Navigation.PushAsync(contactsPage);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
