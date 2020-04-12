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
            InitializeComponent();
            _business = new Business(); //make a instance
        }
    }
}
