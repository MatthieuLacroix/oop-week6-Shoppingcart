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
        public void Add_Apple(Apple apple)
        {
            products.Add(apple);
        }
        public void Add_Orange(Orange orange)
        {
            products.Add(orange);
        }
    }
    class Apple
    {
        public static double price = 0.6;
    }
    class Orange
    {
        public static double price = 25;
    }
}
