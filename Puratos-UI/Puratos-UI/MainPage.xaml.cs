using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Puratos_Domain; //Business layer

namespace Puratos_UI
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Business _business; //business class
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false); //remove the bottem bar by the beginning of the screen
            InitializeComponent();
            _business = new Business(); //make a instance
        }

        //methode die aangeroepen/uitgevoerd wordt als er op de knop product wordt geklikt.
        private void btnProducten_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Producten());
        }

        //methode die aangeroepen/uitgevoerd wordt als er op de knop product wordt Locatie.
        private void btnLocatie_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocatiePage());
            
        }

        //methode die aangeroepen/uitgevoerd wordt als er op de knop Bestellen wordt geklikt.
        private void btnBestellingen_Clicked(object sender, EventArgs e)
        {
            //TODO Bestellingen class?
        }

        //methode die aangeroepen/uitgevoerd wordt als er op de knop Service wordt geklikt.
        private void btnService_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Service());
        }

        private void btnProducten_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLocatie_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBestellingen_Clicked(object sender, EventArgs e)
        {

        }

        private void btnService_Clicked(object sender, EventArgs e)
        {

        }
    }
}
