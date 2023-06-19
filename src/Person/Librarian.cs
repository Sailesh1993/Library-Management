namespace LibraryManagement
{
    public class Librarian : Person
    {
        public Librarian(string name, int id) : base(name, id)
        {
        }

        public void AddBook(Book book, Library library)
        {
            library.AddBook(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void RemoveBook(Book book, Library library)
        {
            library.RemoveBook(book);
            Console.WriteLine($"Book '{book.Title}' removed from the library.");
        }

        public void EditPersonInfo(Person person, string newName, Library library)
        {
            library.EditPersonInfo(person, newName);
            Console.WriteLine($"Person with ID {person.ID} info edited. New name: {newName}");
        }
    }
}
