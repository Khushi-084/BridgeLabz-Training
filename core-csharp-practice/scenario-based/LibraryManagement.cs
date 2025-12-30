using System;
using System.ComponentModel.Design;
class LibraryManagement{
    static string[,] books = new string[50, 3];        //50 rows and 3 columns 
    static int count = 0;
    static string role = "";
    static string password = "dahi_vada123";
    public static void Main(){
        SelectRole();
        ShowMenu();
    }
    
    //method to select role
    public static void SelectRole(){      
        Console.WriteLine("Select Role: ");
        Console.WriteLine("1. Librarian : ");
        Console.WriteLine("2. User: ");

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1){
            role = "Admin";
        }else{
            role = "User";
        }

        Console.WriteLine("Logged in as " + role);
    }

    //method to show menu
    public static void ShowMenu(){
        int option = 0;
        do{
            Console.WriteLine("\n--------------LIBRARY MANAGEMENT SYSTEM-------------------");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Search Books");
            Console.WriteLine("4.Check-out Books");
            Console.WriteLine("5. Check Availability");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter choice");

            option = int.Parse(Console.ReadLine());

            switch (option){
                case 1:
                    if (Secure())
                        AddBook();
                    break;
                case 2:
                    DisplayBooks();
                    break;
                case 3:
                    SearchBooks();
                    break;
                case 4:
                    CheckOutBooks();
                    break;
                case 5:
                    CheckAvailability();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (option != 6);
    }
    
    //method to check password
    public static bool Secure(){
        if (role == "Admin"){
            Console.Write("Enter PassKey: ");
            string str = Console.ReadLine();

            if (str != password){
                Console.WriteLine("Access Denied!");
                return false;
            }
        }
        return true;
    }

    //method to add book
    public static void AddBook(){
        if (role != "Admin"){
            Console.WriteLine("Only librarian can add books.");
            return;
        }
        Console.Write("Enter Title"); //count kept as rows so the next row is empty
        books[count, 0] = Console.ReadLine(); //data input
        Console.Write("Enter Author");
        books[count, 1] = Console.ReadLine();
        Console.Write("Enter Status");
        books[count, 2] = Console.ReadLine();
        count++;

        Console.WriteLine("The book is added successfully");

    }

    //method to display books
    public static void DisplayBooks(){
        if (count == 0){
            Console.WriteLine("No books found");
            return;
        }
        Console.WriteLine("Title\t\t Author\t\tStatus");
        for (int i = 0; i < count; i++){
            Console.WriteLine(books[i, 0] + "\t\t" + books[i, 1] + "\t\t" + books[i, 2]);
        }

    }

    //method to search books
    public static void SearchBooks(){
        Console.Write("Enter Title to search");
        string str = Console.ReadLine().ToLower();
        bool found = false;
        for (int i = 0; i < count; i++){
            if (books[i, 0].ToLower().Contains(str)){
                Console.WriteLine("Found :" + books[i, 0] + " by Author with status " + books[i, 2]);
                found = true;
            }

        }
        if (!found){
            Console.WriteLine("Not Found");
        }
    }
    
    //method to check out books
    public static void CheckOutBooks(){
        if (role == "Admin"){
            Console.Write("Enter Title to checkout");
            string str = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < count; i++){
                if (books[i, 0].ToLower().Contains(str)){
                    if (books[i, 2] == "Available"){
                        books[i, 2] = "Checked Out";
                        Console.WriteLine("Checkout successful");
                    }
                    else{
                        Console.WriteLine("Book already checked out");
                    }
                    found = true;
                    break;
                }
            }
            if (!found){
                Console.WriteLine("Books not found");
            }
        }
        else{
            Console.WriteLine("Access Denied");
        }
    }

    //method to check availability
    public static void CheckAvailability(){
        Console.WriteLine("Enter book title ");
        string str = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < count; i++){
            if (books[i, 0].ToLower().Contains(str)){
                Console.WriteLine("Status: " + books[i, 2]);
                found = true;
                break;
            }
        }
        if (!found){
            Console.WriteLine("Book not found ");
        }
    }
}