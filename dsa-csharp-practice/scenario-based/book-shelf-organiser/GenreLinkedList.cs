class GenreNode
{
    public string GenreName;
    public BookLinkedList Books;
    public GenreNode Next;

    public GenreNode(string genre)
    {
        GenreName = genre;
        Books = new BookLinkedList();
        Next = null;
    }
}

class GenreLinkedList
{
    private GenreNode head;

    public GenreNode GetGenre(string genre)
    {
        GenreNode temp = head;
        while (temp != null)
        {
            if (temp.GenreName.Equals(genre, StringComparison.OrdinalIgnoreCase))
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public GenreNode AddGenre(string genre)
    {
        GenreNode newNode = new GenreNode(genre);

        if (head == null)
        {
            head = newNode;
            return newNode;
        }

        GenreNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
        return newNode;
    }

    public void DisplayLibrary()
    {
        GenreNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(" Genre: " + temp.GenreName);
            temp.Books.DisplayBooks();
            temp = temp.Next;
        }
    }
}
