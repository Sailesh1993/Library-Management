
public class Customer : Person
{
    public Customer(string name, int id)
        : base(name, id)
    {
    }

    public void Borrow(Book book)
    {
        if (book.CanBorrow)
        {
            Console.WriteLine($"Customer {Name} is borrowing the book: {book.Title}");
        }
        else
        {
            Console.WriteLine($"Book {book.Title} cannot be borrowed");
        }
    }
    public void Return(Book book)
    {
        Console.WriteLine($"Customer {Name} is returning the book: {book.Title}");
    }
}
