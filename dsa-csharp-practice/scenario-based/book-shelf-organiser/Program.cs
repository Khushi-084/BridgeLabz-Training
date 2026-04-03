// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\n1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Library");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    library.AddBook();
                    break;
                case 2:
                    library.BorrowBook();
                    break;
                case 3:
                    library.DisplayLibrary();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}


