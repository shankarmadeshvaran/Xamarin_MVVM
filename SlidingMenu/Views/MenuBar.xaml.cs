using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlidingMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuBar : MasterDetailPage
    {
        public MenuBar()
        {
            InitializeComponent();
            MyMenu();
        }
        public void MyMenu()
        {
            Detail = new NavigationPage(new ContactsPage());
            List<Menu> menu = new List<Menu>
            {
                new Menu{ Page= new ProfilePage(),MenuTitle="Profile", MenuDetail="To change your profile",icon="user.png"},
                new Menu{ Page= new MessagesPage(),MenuTitle="Messages",  MenuDetail="To chat with your contacts",icon="message.png"},
                new Menu{ Page= new ContactsPage(),MenuTitle="Contacts",  MenuDetail="To find contacts",icon="contacts.png"},
                new Menu{ Page= new SettingsPage(),MenuTitle="Settings",  MenuDetail="To change your settings",icon="settings.png"}
            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }
            public ImageSource icon
            {
                get;
                set;
            }
            public Page Page
            {
                get;
                set;
            }
        }
    }
}
