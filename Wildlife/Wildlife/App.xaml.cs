using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wildlife.Services;
using Wildlife.Views;
using RestSharp;
using Autofac;

namespace Wildlife
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var setup = new AppSetup();
            AppContainer.Container = setup.CreateContainer();

            MainPage = new NavigationPage((Page)AppContainer.Container.Resolve<IVideoCapturePage>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
