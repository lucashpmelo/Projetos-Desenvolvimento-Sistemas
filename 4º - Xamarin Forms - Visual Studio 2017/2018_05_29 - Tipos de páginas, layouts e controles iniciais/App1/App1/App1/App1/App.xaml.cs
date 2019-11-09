using App1.Views;
using App1.Views.ContentViews;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var navigationPage = new Xamarin.Forms.NavigationPage(new NavigationPageClientesViews());
            navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPrefersLargeTitles(true);
            navigationPage.BarBackgroundColor = Color.Red;
            navigationPage.BarTextColor = Color.White;
            MainPage = new MasterDetailPageView();

            //MainPage = new Xamarin.Forms.NavigationPage(new NavigationPageClientesViews());

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
