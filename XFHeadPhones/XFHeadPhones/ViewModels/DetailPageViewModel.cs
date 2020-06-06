using System.Threading.Tasks;
using Xamarin.Forms;
using XFHeadPhones.Models;
using XFHeadPhones.ViewModel;

namespace XFHeadPhones.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, Phone phone)
        {
            Navigation = navigation;
            Phone = phone;
            NavigateToMainPage = new Command(async () => await ExecuteNavigateToMainPage());
            GetFirstLastName();
        }

        public Command NavigateToMainPage { get; }

        public Phone Phone { get; set; }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        void GetFirstLastName()
        {
            FirstName = Phone.name.Split(' ')[0];
            LastName = Phone.name.Split(' ')[1];
        }

        private async Task ExecuteNavigateToMainPage()
        {
            await Navigation.PopAsync();
        }
    }
}
