using System;
using System.Collections.Generic;

namespace c_Assignment2
{
    class ListOfProducts
    {
        List<Products> Items = new List<Products>{
            new Products("lettuce", 10.5, 50, "Leafy green"),
            new Products("cabbage", 20.0, 100, "Cruciferous"),
            new Products("pumpkin", 30.0, 30, "Marrow"),
            new Products("cauliflower", 10.0, 25, "Cruciferous"),
            new Products("zucchini", 20.5, 50, "Marrow"),
            new Products("yam", 30.0, 50, "Root"),
            new Products("spinach", 10.0, 100, "Leafy green"),
            new Products("broccoli", 20.2, 75, "Cruciferous"),
            new Products("garlic", 30.0, 20, "Leafy green"),
            new Products("silverbeet", 10.0, 50, "Marrow"),

        };

        public void AddItemToList(string Name, double Price, int Quantity, string Type)
        {
            var obj = new Products(Name, Price, Quantity, Type);
            Items.Add(obj);

        }

        public int GetTheSizeOfList()
        {
            Console.WriteLine(Items.Count);
            return Items.Count;
        }

        public void PrintList()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name + " " + item.Price.ToString() + " " + item.Quantity.ToString() + " " + item.Type);
            }
        }

        public void PrintList(string type)
        {
            foreach (var item in Items)
            {
                if(item.Type == type)
                Console.WriteLine(item.Name + " " + item.Price.ToString() + " " + item.Quantity.ToString() + " " + item.Type);
            }
        }
        public void RemoveObjectFromList(string name)
        {
            Items.RemoveAll(x => x.Name == name);
            
        }

        public void ChangeQuantity(string name, int quantity)
        {
            foreach (var item in Items)
            {   
                if(item.Name == name)
                {
                    item.Quantity = quantity;
                    Console.WriteLine(item.Quantity);
                    break;
                }
            }
            
        }

        
    }
}
