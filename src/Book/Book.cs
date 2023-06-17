
public abstract class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private int _publicationYear;
    private bool _canBorrow;
    private bool _canPrint;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string ISBN
    {
        get { return _isbn; }
    }

    public int PublicationYear
    {
        get { return _publicationYear; }
        set { _publicationYear = value; }
    }

    public bool CanBorrow
    {
        get { return _canBorrow; }
        set { _canBorrow = value; }
    }

    public bool CanPrint
    {
        get { return _canPrint; }
        set { _canPrint = value; }
    }

    public Book(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint)
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _publicationYear = publicationYear;
        _canBorrow = canBorrow;
        _canPrint = canPrint;
    }
    public abstract void PrintInfo();
}


