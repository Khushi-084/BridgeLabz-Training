using System;
// menu class for the program 
class FlashDealzMenu{
    private IFlashDealz service;

    // constructor 
    public FlashDealzMenu(IFlashDealz service){
        this.service = service;
    }

    public void ShowMenu(){
        int choice;
        do{
            // Main menu
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Sort Products by Discount");
            Console.WriteLine("3. Display Products");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    service.AddProduct();
                    break;
                case 2:
                    service.SortProducts();
                    break;
                case 3:
                    service.DisplayProducts();
                    break;
                case 4:
                    Console.WriteLine("Exiting FlashDealz...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}
