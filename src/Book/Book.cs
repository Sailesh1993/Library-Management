namespace LibraryManagement
{
    public abstract class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int publicationYear;
        private bool canBorrow;
        private bool canPrint;

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            private set { isbn = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            private set { publicationYear = value; }
        }

        public bool CanBorrow
        {
            get { return canBorrow; }
            private set { canBorrow = value; }
        }

        public bool CanPrint
        {
            get { return canPrint; }
            private set { canPrint = value; }
        }

        public Book(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            CanBorrow = canBorrow;
            CanPrint = canPrint;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Can Borrow: {CanBorrow}");
            Console.WriteLine($"Can Print: {CanPrint}");
        }
    }
}



