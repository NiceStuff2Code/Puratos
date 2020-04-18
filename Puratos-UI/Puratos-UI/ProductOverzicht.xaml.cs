using Puratos_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Puratos_UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductOverzicht : ContentPage
    {
        public ProductOverzicht()
        {
            /*
             - the same list is that is ised in productenpage is now accesable in productoverzicht.xaml and cs.
             */
            List<Product> overzichtProductList = ProductenPage.productList; //content of list is defined in ProductenPage...

            BindingContext = this; //set the context to this particular piece of code.
            InitializeComponent();

        }
    }
}