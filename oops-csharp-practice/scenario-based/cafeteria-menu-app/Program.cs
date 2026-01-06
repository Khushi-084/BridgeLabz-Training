using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.CafeteriaMenuApp
{
    internal class Program
    {
        static void Main(string[] args){
            // Create objects
            Menu menu = new Menu();
            Order order = new Order();

            int totalBill = 0;
            char choice;

            do{
                menu.DisplayMenu();      // Display menu
                
                // Get user input
                Console.Write("\nEnter item index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                // Check if index is valid
                if (order.IsValidIndex(index, menu.items.Length)) {
                    Console.Write("Enter quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    int itemCost = order.CalculateItemCost(menu.prices[index], quantity);
                    totalBill += itemCost;
                // Add item to order and calculate cost
                    Console.WriteLine("Added: " + menu.items[index]);
                    Console.WriteLine("Cost: Rs." + itemCost);
                }
                else{
                    Console.WriteLine("Invalid item index!");
                }
               // Get user input for more items
                Console.Write("\nDo you want to order more items? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
            

            // Display total bill amount
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Total Bill Amount: Rs." + totalBill);
            Console.WriteLine("Thank you! Visit Again!");
        }
    }
}
