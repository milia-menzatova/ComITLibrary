using System;

namespace ComitLibrary
{

    public class LibrarySystem
    {
        // Search for a book
        public Book SearchForBook(string title) {
            Console.WriteLine($"Searching for book: {title}");
            var result = new Book();
            return result;
        }

        // Checkout a book
        public void CheckoutBook() {
            Console.WriteLine("Checking out a book...");
        }

        // Return a book
        public void ReturnBook() {
            Console.WriteLine("Returning a book...");
        }

    }
}