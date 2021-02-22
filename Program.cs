using System;
using System.Collections.Generic;

namespace c_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new ListOfProducts();
            obj.GetTheSizeOfList();
            System.Console.WriteLine("----------------------------------------");
            obj.AddItemToList("Potato", 10.0, 50, "Root");
            obj.PrintList("Leafy green");
            System.Console.WriteLine("----------------------------------------");
            obj.RemoveObjectFromList("garlic");
            obj.GetTheSizeOfList();
            System.Console.WriteLine("----------------------------------------");
            obj.ChangeQuantity("cabbage", 50);

        }
    }


    
}
