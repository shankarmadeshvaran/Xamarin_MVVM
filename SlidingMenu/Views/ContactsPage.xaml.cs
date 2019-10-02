using SlidingMenu.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlidingMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            BindingContext = new ContactViewModel();
        }
    }
}
