public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Comic comic = new Comic("The Amazing Spider-Man", "Stan Lee", "978-1302902201", 1963, "Steve Ditko");
        Novel novel = new Novel("To Kill a Mockingbird", "Harper Lee", "978-0060935467", 1960, "Classic");
        TextBook textbook = new TextBook("Introduction to Programming", "John Smith", "978-0134494166", 2020, 500);
        ResearchPaper researchPaper = new ResearchPaper("Research Paper on Artificial Intelligence", "Jane Doe", "978-1234567890", 2022);

        Customer customer = new Customer("John Doe", 1);
        Librarian librarian = new Librarian("Jane Smith", 2);

        library.AddBook(comic);
        library.AddBook(novel);
        library.AddBook(textbook);
        library.AddBook(researchPaper);

        library.BorrowBook(customer, comic);
        library.BorrowBook(customer, textbook);
        library.BorrowBook(customer, researchPaper);

        library.ReturnBook(customer, comic);
        library.ReturnBook(customer, textbook);

        library.EditPerson(librarian);

        Console.ReadLine();
    }
}