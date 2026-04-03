class Library
{
    private GenreLinkedList genres = new GenreLinkedList();
    private HashSet<int> bookIds = new HashSet<int>(); // Avoid duplicates

    public void AddBook()
    {
        Console.Write("Enter Genre: ");
        string genre = Console.ReadLine();

        Console.Write("Enter Book ID: ");
        int id = int.Parse(Console.ReadLine());

        if (bookIds.Contains(id))
        {
            Console.WriteLine(" Duplicate book ID.");
            return;
        }

        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author: ");
        string author = Console.ReadLine();

        GenreNode genreNode = genres.GetGenre(genre);
        if (genreNode == null)
            genreNode = genres.AddGenre(genre);

        genreNode.Books.AddBook(new Book(id, title, author));
        bookIds.Add(id);

        Console.WriteLine("Book added successfully.");
    }

    public void BorrowBook()
    {
        Console.Write("Enter Genre: ");
        string genre = Console.ReadLine();

        Console.Write("Enter Book ID: ");
        int id = int.Parse(Console.ReadLine());

        GenreNode genreNode = genres.GetGenre(genre);
        if (genreNode == null)
        {
            Console.WriteLine(" Genre not found.");
            return;
        }

        if (genreNode.Books.RemoveBook(id))
        {
            bookIds.Remove(id);
            Console.WriteLine("Book borrowed.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void DisplayLibrary()
    {
        genres.DisplayLibrary();
    }
}
