namespace LibraryManagement
{
    public class Comic : Book
    {
        private string artist;

        public string Artist
        {
            get { return artist; }
            private set { artist = value; }
        }

        public Comic(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint, string artist)
            : base(title, author, isbn, publicationYear, canBorrow, canPrint)
        {
            Artist = artist;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Artist: {Artist}");
        }

    }
}