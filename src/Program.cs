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
            Person person1 = new Customer("Customer 1");
            Person person2 = new Librarian("Librarian 1");

            // Add books and persons to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddPerson(person1);
            library.AddPerson(person2);

            // Perform actions in the library
            Console.WriteLine("Performing actions in the library...\n");

            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Remove book");
                Console.WriteLine("3. Borrow book");
                Console.WriteLine("4. Return book");
                Console.WriteLine("5. Edit person info");
                Console.WriteLine("6. Print books");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter book type (1. Comic, 2. Novel, 3. TextBook, 4. ResearchPaper):");
                        string bookTypeChoice = Console.ReadLine();
                        Console.WriteLine("Enter book title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter book author:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter book ISBN:");
                        string isbn = Console.ReadLine();
                        Console.WriteLine("Enter publication year:");
                        int publicationYear = Convert.ToInt32(Console.ReadLine());

                        switch (bookTypeChoice)
                        {
                            case "1":
                                Console.WriteLine("Enter artist:");
                                string artist = Console.ReadLine();
                                Book comic = new Comic(title, author, isbn, publicationYear, true, false, artist);
                                library.AddBook(comic);
                                Console.WriteLine($"Comic '{title}' added to the library.");
                                break;
                            case "2":
                                Console.WriteLine("Enter genre:");
                                string genre = Console.ReadLine();
                                Book novel = new Novel(title, author, isbn, publicationYear, true, false, genre);
                                library.AddBook(novel);
                                Console.WriteLine($"Novel '{title}' added to the library.");
                                break;
                            case "3":
                                Console.WriteLine("Enter maximum number of pages:");
                                int maxPages = Convert.ToInt32(Console.ReadLine());
                                Book textbook = new TextBook(title, author, isbn, publicationYear, true, true, maxPages);
                                library.AddBook(textbook);
                                Console.WriteLine($"TextBook '{title}' added to the library.");
                                break;
                            case "4":
                                Book researchPaper = new ResearchPaper(title, author, isbn, publicationYear);
                                library.AddBook(researchPaper);
                                Console.WriteLine($"ResearchPaper '{title}' added to the library.");
                                break;
                            default:
                                Console.WriteLine("Invalid book type choice.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter book title to remove:");
                        string removeTitle = Console.ReadLine();
                        Book removeBook = library.FindBookByTitle(removeTitle);
                        if (removeBook != null)
                        {
                            library.RemoveBook(removeBook);
                            Console.WriteLine($"Book '{removeTitle}' removed from the library.");
                        }
                        else
                        {
                            Console.WriteLine($"Book '{removeTitle}' not found in the library.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter book title to borrow:");
                        string borrowTitle = Console.ReadLine();
                        Book borrowBook = library.FindBookByTitle(borrowTitle);
                        if (borrowBook != null)
                        {
                            if (borrowBook.CanBorrow)
                            {
                                Customer customer = (Customer)person1;
                                library.BorrowBook(borrowBook, customer);
                                Console.WriteLine($"Book '{borrowTitle}' borrowed by customer.");
                            }
                            else
                            {
                                Console.WriteLine($"Book '{borrowTitle}' cannot be borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Book '{borrowTitle}' not found in the library.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter book title to return:");
                        string returnTitle = Console.ReadLine();
                        Book returnBook = library.FindBookByTitle(returnTitle);
                        if (returnBook != null)
                        {
                            if (returnBook.CanBorrow)
                            {
                                Customer customer = (Customer)person1;
                                library.ReturnBook(returnBook, customer);
                                Console.WriteLine($"Book '{returnTitle}' returned by customer.");
                            }
                            else
                            {
                                Console.WriteLine($"Book '{returnTitle}' cannot be returned.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Book '{returnTitle}' not found in the library.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Enter person ID to edit:");
                        int personId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new person name:");
                        string newName = Console.ReadLine();
                        Person editPerson = library.FindPersonById(personId);
                        if (editPerson != null)
                        {
                            Librarian librarian = (Librarian)person2;
                            librarian.EditPersonInfo(editPerson, newName, library);
                        }
                        else
                        {
                            Console.WriteLine($"Person with ID {personId} not found.");
                        }
                        break;
                    case "6":
                        library.PrintBooks();
                        break;
                    case "0":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}
