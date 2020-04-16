using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Puratos_Domain;
using Xamarin.Forms.Maps;

namespace Puratos_UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocatiePage : ContentPage
    {
        public LocatiePage()
        {
            Location locatie = new Location();

            locatie.setMap(mapPuratos);
            
            InitializeComponent();
        }
    }
}