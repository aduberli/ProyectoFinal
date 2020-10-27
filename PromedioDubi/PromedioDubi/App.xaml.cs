using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PromedioDubi.Services;
using PromedioDubi.Views;

namespace PromedioDubi
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
