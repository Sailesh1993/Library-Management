public abstract class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private string _publicationYear;
    private string _canBorrow;
    private string _canPrint;

    public Book(
        string Title, 
        string Author, 
        string ISBN, 
        string PublicationYear, 
        string CanBorrow, 
        string CanPrint )
    {
        _title = Title;
        _author = Author;
        _isbn = ISBN;
        _publicationYear = PublicationYear;
        _canBorrow = CanBorrow;
        _canPrint = CanPrint;
    }
}