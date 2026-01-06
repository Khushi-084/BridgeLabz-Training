using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.CafeteriaMenuApp
{
    internal class Menu
    {    
        //array of items
        public string[] items ={
        "Tea",
        "Coffee",
        "Salad",
        "Burger",
        "Pizza",
        "Pasta",
        "Fries",
        "Noodles",
        "Juice",
        "Momos"
    };

        public int[] prices ={
        20, 30, 50, 80, 120, 100, 60, 70, 40, 50
    };
        
        //method to display menu
        public void DisplayMenu(){
            Console.WriteLine("------ Cafeteria Menu ------");
            Console.WriteLine("Index\tItem\t\tPrice");
            for (int i = 0; i < items.Length; i++){
                Console.WriteLine(i + "\t" + items[i] + "\t\t Rs." + prices[i]);
            }
        }
    }
}
