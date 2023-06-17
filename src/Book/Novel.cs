
public class Novel : Book
{
    private string _genre;

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }
    public Novel(string title, string author, string isbn, int publicationYear, string genre)
        : base(title, author, isbn, publicationYear, true, false)
    {
        _genre = genre;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Novel Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
        Console.WriteLine($"Genre: {Genre}");

    }
}

