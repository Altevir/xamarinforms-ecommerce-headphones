﻿using Xamarin.Forms;
using XFHeadPhones.Interfaces;

namespace XFHeadPhones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            if (Device.RuntimePlatform == Device.iOS)
                DependencyService.Get<IStatusBarStyle>().ChangeTextColor();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
