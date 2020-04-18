using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Puratos_Domain; //using business layer

namespace Puratos_UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Producten : ContentPage
    {
        public List<Product> productList { get; private set; } //list ~ collection

        public Producten()
        {
            InitializeComponent();

            productList = new List<Product>();

            //add S500 product to productList
            productList.Add(new Product("S500 sence", 0.0d,
                "https://boulangerie-bakery.com/wp-content/uploads/2020/03/Pack-4014311-Sac-Puratos-S500-Special-CL-1140x1489.png"));
            productList.Add(new Product("crimpyvit", 0.0d,
                "https://www.papyrus.co.ke/wp-content/uploads/2019/03/creamyvit-classic-1200x960.jpg"));
            productList.Add(new Product("Deli", 0.0d,
                "https://www.puratos.fr/content/dam/france/images/packshot/p%C3%A2tisserie/fourrages/4101812%20DELI%20SPECULOOS.png/jcr:content/renditions/cq5dam.web.800.800.png"));
            productList.Add(new Product("chcolaté", 0.0d,
                "https://santoantonio.ciaimg.com.br/Assets/Produtos/SuperZoom/85275---Chocolate-Ao-Leite-Chocolante---Moedas-201kg-PURATOS.jpg?v=eca54ae8-1"));

            BindingContext = this;
        }

        private void listViewProduct_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}