using CustomLinkedList;
class Genre{
    public string Name { get; private set; }
    private CustomLinkedList<Book> books;

    public Genre(string name){
        Name = name;
        books = new CustomLinkedList<Book>();
    }

    public bool AddBook(Book book){
        if (books.Exists(b => b.Title.Equals(book.Title, StringComparison.OrdinalIgnoreCase)))
            return false;

        books.AddLast(book);
        return true;
    }

    public bool RemoveBook(string title){
        return books.Remove(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public void DisplayBooks(){
        books.Display(b => b.Display());
    }
}
