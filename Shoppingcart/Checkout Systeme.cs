using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Shoppingcart
{
    class Checkout_Systeme
    {
        public ArrayList products { get; set; }
        public static double number_product { get; set; }
        public void Total_Price()
        {
            foreach(ArrayList element in products)
            {
                number_product=number_product+element.price;
            }
        }
        public void Add_Apple()
        {
            products.Add()
        }
    }
    class Apple
    {
        static int price { get; set; }
    }
    class Orange
    {
        static int price { get; set; }
    }
}
