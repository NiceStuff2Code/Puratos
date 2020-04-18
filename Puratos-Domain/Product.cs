using System;
using System.Collections.Generic;
using System.Text;

namespace Puratos_Domain
{
    //helip class for ListView in ....Page.xaml
    public class Product
    {
        //product properties
        public string NaamProduct { get; set; }
        public double PrijsProduct { get; set; }
        public string AfbeeldingLink { get; set; }
        //public string ProductBeschrijving { }

        //default constructor
        public Product()
        {

        }

        public Product(string naamProduct, double PrijsProduct, string afbeelding)
        {
            this.NaamProduct = naamProduct;
            this.PrijsProduct = PrijsProduct;
            this.AfbeeldingLink = afbeelding;
        }

        //de listview gaat deze methode oproepen waneer dit object wordt getoond bij een collection (List)
        public override string ToString()
        {
            return NaamProduct;
        }
    }
}
