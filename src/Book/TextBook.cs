namespace LibraryManagement
{
    public class TextBook : Book, IPrintable
    {
        private int maxPrintPages;

        public int MaxPrintPages
        {
            get { return maxPrintPages; }
            private set { maxPrintPages = value; }
        }

        public TextBook(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint, int maxPrintPages)
            : base(title, author, isbn, publicationYear, canBorrow, canPrint)
        {
            MaxPrintPages = maxPrintPages;
        }

        public void PrintPages(int startPage, int endPage)
        {
            if (endPage > MaxPrintPages)
            {
                Console.WriteLine("Cannot print the specified number of pages. Exceeds maximum print limit.");
                return;
            }

            Console.WriteLine($"Printing pages {startPage}-{endPage} of the textbook '{Title}'.");
        }

    }
}

