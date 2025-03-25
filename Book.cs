namespace USFLibraryManagementSystem
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int AvailableCopies;

        public Book(string title, string author, string isbn, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
        }

        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void ReturnBook()
        {
            AvailableCopies++;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
        }
    }


}