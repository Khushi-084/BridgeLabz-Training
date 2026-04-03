using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceriesApp.GroceriesApp
{
    internal class Menu
    {
        //array of items available in the store
        public string[] items ={
        "Biscuit", "Noodles", "Bread","Wafers","Chips","Tea","Coffee","Pasta","Paneer","Fruits"
    };

        //array of prices of the availabe items 
        public int[] prices ={
        20, 50, 25, 80, 100, 150, 200, 70, 55, 65
    };

        //method to display menu
        public void DisplayMenu()
        {
            Console.WriteLine("------SmartMart------");
            Console.WriteLine("Menu");
            Console.WriteLine("Index\tItem\t\tPrice");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(i + "\t" + items[i] + "\t\tRs." + prices[i]);
            }
        }
    }
}
