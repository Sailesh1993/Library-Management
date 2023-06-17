public class Librarian : Person
{
    public Librarian(string name, int id)
        : base(name, id)
    {
    }
    public void Addbook(Book book)
    {
        Console.WriteLine($"Librarian {Name} is adding the book: {book.Title}");
    }
    public void RemoveBook(Book book)
    {
        Console.WriteLine($"Librarian {Name} is removing the book: {book.Title}");
    }
    public void EditBook(Book book)
    {
         Console.WriteLine($"Librarian {Name} is editing the book: {book.Title}");
    }
}