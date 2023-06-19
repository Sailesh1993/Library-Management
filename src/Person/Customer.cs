namespace LibraryManagement
{
    public class Customer : Person
    {
     public List<Book> BorrowedBooks { get; }

        public Customer(string name, int id) : base(name, id)
        {
            BorrowedBooks = new List<Book>();
        }
    }
}

