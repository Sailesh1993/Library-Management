using LibraryManagement;
namespace LibraryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            // Create some books
            Book book1 = new Comic("Comic 1", "Author 1", "ISBN001", 2021, true, false, "Artist 1");
            Book book2 = new Novel("Novel 1", "Author 2", "ISBN002", 2022, true, false, "Genre 1");
            Book book3 = new TextBook("TextBook 1", "Author 3", "ISBN003", 2023, true, true, 500);
            Book book4 = new ResearchPaper("ResearchPaper 1", "Author 4", "ISBN004", 2023);

            // Create some persons
            Person person1 = new Customer("Customer 1", 1);
            Person person2 = new Librarian("Librarian 1", 2);

            // Add books and persons to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddPerson(person1);
            library.AddPerson(person2);

            // Perform actions in the library
            Console.WriteLine("Performing actions in the library...\n");

            // Librarian adds a book
            Librarian librarian = (Librarian)person2;
            librarian.AddBook(book1, library);

            // Customer borrows a book
            Customer customer = (Customer)person1;
            library.BorrowBook(book1, customer);

            // Customer tries to borrow the same book again
            library.BorrowBook(book1, customer);

            // Customer borrows another book
            library.BorrowBook(book2, customer);

            // Customer returns a book
            library.ReturnBook(book1, customer);

            // Librarian removes a book
            librarian.RemoveBook(book1, library);

            // Librarian edits a person's info
            librarian.EditPersonInfo(person1, "New Customer Name", library);

            // Print all books in the library
            library.PrintBooks();

            Console.ReadLine();
        }
    }
}
