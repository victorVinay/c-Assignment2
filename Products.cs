using System;
using System.Collections.Generic;

namespace c_Assignment2
{
    public class Products
    {
        public string Name{ get; set; }
        public double Price{ get; set; }
        public int Quantity{ get; set; }
        public string Type{ get; set; }


        public Products(string name, double price, int quantity, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;

        }
        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public string GetTypeP()
        {
            return Type;
        }

    }
}