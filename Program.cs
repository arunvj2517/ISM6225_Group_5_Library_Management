namespace USFLibraryManagementSystem
{
    internal class Program

    {
        static void Main(string[] args)
        {
            
            Library usfLibrary = new Library();

            // Adding books to the library
            usfLibrary.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
            usfLibrary.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
            usfLibrary.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

            // Adding patrons to the library
            usfLibrary.AddPatron(new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026));
            usfLibrary.AddPatron(new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025));
            usfLibrary.AddPatron(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

            // Display initial state
            Console.WriteLine("Initial Library State:");
            usfLibrary.DisplayBooks();
            Console.WriteLine();
            usfLibrary.DisplayPatrons();
            Console.WriteLine();

            // Borrow books
            Console.WriteLine("Borrowing Books...");
            if (usfLibrary.BorrowBook("Sandeep", "Business Insights with AI"))
            {
                Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            }
            else
            {
                Console.WriteLine("Failed to borrow 'Business Insights with AI'");
            }

            if (usfLibrary.BorrowBook("Akhil", "Analytics in Action"))
            {
                Console.WriteLine("Akhil borrowed 'Analytics in Action'");
            }
            else
            {
                Console.WriteLine("Failed to borrow 'Analytics in Action'");
            }
            Console.WriteLine();

            
            Console.WriteLine("Books After Borrowing:");
            usfLibrary.DisplayBooks();
        }
    }
}
