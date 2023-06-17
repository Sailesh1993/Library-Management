
public class Comic : Book
{
    private string _artist;
    public string Artist
    {
        get { return _artist; }
        set { _artist = value; }
    }
    public Comic(string title, string author, string isbn, int publicationYear, string artist)
     : base(title, author, isbn, publicationYear, true, false)
    {
        _artist = artist;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Comic Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}