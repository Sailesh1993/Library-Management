namespace LibraryManagement
{
        public class Library
    {
        private List<Book> books;
        private List<Person> persons;

        public Library()
        {
            books = new List<Book>();
            persons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void BorrowBook(Book book, Customer customer)
        {
            if (books.Contains(book) && book.CanBorrow && !customer.BorrowedBooks.Contains(book))
            {
                customer.BorrowedBooks.Add(book);
                Console.WriteLine($"{customer.Name} borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Cannot borrow '{book.Title}'.");
            }
        }

        public void ReturnBook(Book book, Customer customer)
        {
            if (customer.BorrowedBooks.Contains(book))
            {
                customer.BorrowedBooks.Remove(book);
                Console.WriteLine($"{customer.Name} returned '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"{customer.Name} does not have '{book.Title}' to return.");
            }
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        public void EditPersonInfo(Person person, string newName)
        {
            person.Name = newName;
        }

        public void PrintBooks()
        {
            foreach (Book book in books)
            {
                book.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}

