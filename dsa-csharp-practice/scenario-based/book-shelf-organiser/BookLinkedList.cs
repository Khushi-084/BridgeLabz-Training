class BookNode
{
    public Book Data;
    public BookNode Next;

    public BookNode(Book book)
    {
        Data = book;
        Next = null;
    }
}

class BookLinkedList
{
    private BookNode head;

    public void AddBook(Book book)
    {
        BookNode newNode = new BookNode(book);

        if (head == null)
        {
            head = newNode;
            return;
        }

        BookNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    public bool RemoveBook(int bookId)
    {
        if (head == null) return false;

        if (head.Data.Id == bookId)
        {
            head = head.Next;
            return true;
        }

        BookNode temp = head;
        while (temp.Next != null && temp.Next.Data.Id != bookId)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            return false;
        }

        temp.Next = temp.Next.Next;
        return true;
    }

    public void DisplayBooks()
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data.Title + " - " + temp.Data.Author);
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}
