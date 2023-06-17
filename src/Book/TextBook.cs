

public class TextBook : Book
{
    private int _maxPrintPages;
    public int MaxPrintPages
    {
        get { return _maxPrintPages; }
        set { _maxPrintPages = value; }
    }


    public TextBook(string title, string author, string isbn, int publicationYear, int maxPrintPages)
        : base(title, author, isbn, publicationYear, true, true)
    {
        _maxPrintPages = maxPrintPages;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"TextBook Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
        Console.WriteLine($"MaxPrintPages: {MaxPrintPages}");
    }
    public void PrintPages(int startPage, int endPage)
    {
        if (endPage > MaxPrintPages)
        {
            Console.WriteLine("Invalid print page range.");
            return;
        }
        else
        {
            Console.WriteLine($"Printing pages {startPage}-{endPage} of TextBook: {Title}");
        }
    }
}
