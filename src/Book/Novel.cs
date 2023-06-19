namespace LibraryManagement
{
    public class Novel : Book
    {
        private string genre;

        public string Genre
        {
            get { return genre; }
            private set { genre = value; }
        }

        public Novel(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint, string genre)
            : base(title, author, isbn, publicationYear, canBorrow, canPrint)
        {
            Genre = genre;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}


