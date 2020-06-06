using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFHeadPhones.Models;
using XFHeadPhones.ViewModel;
using XFHeadPhones.Views;

namespace XFHeadPhones.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Phones = new ObservableCollection<Phone>();
            Speakers = new ObservableCollection<Speaker>();
            NavigateToDetailPage = new Command<Phone>(async (model) => await ExecuteNavigateToDetailPage(model));
            GetProducts();
            GetSpeakers();
        }

        private readonly INavigation _navigation;
        public Command NavigateToDetailPage { get; }
        public ObservableCollection<Phone> Phones { get; set; }
        public ObservableCollection<Speaker> Speakers { get; set; }

        void GetProducts()
        {
            Phones.Add(new Phone()
            {
                name = "JBL Jam Beats",
                price = 90,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "phone_jam.png"
            });

            Phones.Add(new Phone()
            {
                name = "JBL Black",
                price = 150,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "phone_jbl.png"
                
            });

            Phones.Add(new Phone()
            {
                name = "JBL On-Ear",
                price = 199,
                description = "Short product description will place here. This content is just a dummy. You will replace this content with the original content provided by the client.",
                image = "phone_on_ear.png"
            });
        }

        void GetSpeakers()
        {
            Speakers.Add(new Speaker()
            {
                description = "Bose Drum",
                price = 99.9m,
                image = "bose1.png"
            });

            Speakers.Add(new Speaker()
            {
                description = "Bose Pocket",
                price = 182.9m,
                image = "bose2.png"
            });

            Speakers.Add(new Speaker()
            {
                description = "Bose Bluetooth",
                price = 165,
                image = "bose_bluetooth.png"
            });
        }

        private async Task ExecuteNavigateToDetailPage(Phone model)
        {
            await Navigation.PushAsync(new DetailPage(model));
        }
    }
}
