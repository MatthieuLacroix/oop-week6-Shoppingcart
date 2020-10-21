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
        public List<Product> products { get; set; }
        public static double number_product { get; set; }
        public void Total_Price()
        {
            foreach(Product element in products)
            {
                number_product=number_product+element.price;
            }
        }
        public void Add_Product(Product product)
        {
            products.Add(product);
        }
    }
    class Product
    {
        public static double apple_price = 0.6;
        public static double orange_price = 0.25;
        public string name { get; set; }
        public double price { get; set; }
        public void Give_Prive()
        {
            if (name == "apple") price = apple_price;
            else price = orange_price;
        }
    }
}
