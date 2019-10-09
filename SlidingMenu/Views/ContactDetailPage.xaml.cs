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
                    newContact = new Contact();
                    newContact.UserId = userId.Text;
                    newContact.FirstName = firstName.Text;
                    newContact.LastName = lastName.Text;
                    newContact.Company = company.Text;
                    newContact.Email = email.Text;
                    newContact.JobTitle = jobTitle.Text;
                    newContact.Phone = phone.Text;
                    newContact.Street = street.Text;
                    newContact.City = city.Text;
                    newContact.PostalCode = postalCode.Text;
                    newContact.State = state.Text;

                    newContact.PhotoUrl = "profile07.png";

                    contactsPage.addNewUserData(newContact: newContact);
                }
                else
                {
                    contactsPage.updateEditedData(editedContact: contactDetails);
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
