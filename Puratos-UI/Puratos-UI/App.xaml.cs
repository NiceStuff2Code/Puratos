using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Puratos_Domain;

namespace Puratos_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);
            MainPage = new NavigationPage(new MainPage()) {
                BarBackgroundColor = Color.Orange
                
            };            
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
