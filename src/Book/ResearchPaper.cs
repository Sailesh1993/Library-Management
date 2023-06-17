
public class ResearchPaper : Book
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear, false, true)
    {
    }
    public override void PrintInfo()
    {
        Console.WriteLine($"Research Paper Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}
