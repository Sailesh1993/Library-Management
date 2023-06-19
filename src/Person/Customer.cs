namespace LibraryManagement
{
    public class Customer : Person
    {
     public List<Book> BorrowedBooks { get; }

        public Customer(string name) : base(name)
        {
            BorrowedBooks = new List<Book>();
        }
    }
}

