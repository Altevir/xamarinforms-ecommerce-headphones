using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFHeadPhones.Models;
using XFHeadPhones.ViewModels;

namespace XFHeadPhones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        const uint DURATION_NAME = 550;
        const uint DURATION_IMG = 300;

        public DetailPage(Phone phone)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, phone);
            lbFirstName.TranslationX = -150;
            lbLastName.TranslationX = -300;
            imgPhone.TranslationX = 350;
        }

        protected override async void OnAppearing()
        {
            await Task.WhenAll(
                lbFirstName.TranslateTo(-150, 0, DURATION_NAME, Easing.Linear),
                lbFirstName.TranslateTo(-75, 0, DURATION_NAME, Easing.Linear),
                lbFirstName.TranslateTo(0, 0, DURATION_NAME, Easing.Linear),
                lbLastName.TranslateTo(-300, 0, DURATION_NAME, Easing.Linear),
                lbLastName.TranslateTo(-150, 0, DURATION_NAME, Easing.Linear),
                lbLastName.TranslateTo(0, 0, DURATION_NAME, Easing.Linear)
            );

            await imgPhone.TranslateTo(350, 0, DURATION_IMG, Easing.Linear);
            await imgPhone.FadeTo(0.5, DURATION_IMG, Easing.Linear);
            await imgPhone.TranslateTo(175, 0, DURATION_IMG, Easing.Linear);
            await imgPhone.TranslateTo(0, 0, DURATION_IMG, Easing.Linear);
            await imgPhone.FadeTo(1, DURATION_IMG, Easing.Linear);
        }
    }
}