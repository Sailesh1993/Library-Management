public class Library
{
    private List<Book> _books;
    private List<Person> _person;

    public Library()
    {
        _books = new List<Book>();
        _person = new List<Person>();
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
        Console.WriteLine($"Book added: {book.Title}");
    }
    public void RemoveBook(Book book)
    {
        _books.Remove(book);
        Console.WriteLine($"Book removed: {book.Title}");
    }
    public void EditPerson(Person person)
    {
        Console.WriteLine($"Person edited: {person.Name}");
    }

    public void BorrowBook(Person person, Book book)
    {
        if (person is Customer customer)
        {
            customer.Borrow(book);
        }
        else
        {
            Console.WriteLine("Only customers can borrow books.");
        }
    }
    public void ReturnBook(Person person, Book book)
    {
        if (person is Customer customer)
        {
            customer.Return(book);
        }
        else
        {
            Console.WriteLine("Only customers can return books.");
        }
    }

}
