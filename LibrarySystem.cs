using System;
using System.Collections.Generic;

namespace ComitLibrary
{

    public class LibrarySystem
    {
        // Constructor
        public LibrarySystem() {
            // Create an empty list
            _books = new List<Book>();
            _patrons = new List<Patron>();

            // Create 3 sample books
            var book1 = new Book(123, "The Hobbit", "Tolkien");
            var book2 = new Book(999, "Handmaids Tale", "Atwood");
            var book3 = new Book(76348, "Slaughterhouse five", "Vonnegut");

            // Add sample books to our book collection
            _books.Add(book1);
            _books.Add(book2);
            _books.Add(book3);

            // Create 2 sample patrons
            var patron1 = new Patron(11118888, "Pablo", "Listingart");
            var patron2 = new Patron(22227777, "Jesselyn", "Popoff");

            // Add sample patrons to our list
            _patrons.Add(patron1);
            _patrons.Add(patron2);
        }

        // Data member to represent a collection of books
        private List<Book> _books;

        // Data member to represent all of the library patrons
        private List<Patron> _patrons;



        // Search for a book
        public Book SearchForBook(string titleToSearch) {
            Console.WriteLine($"Searching for book: {titleToSearch}");

            for (int i = 0; i < _books.Count; i++) {
                Book nextBook = _books[i];
                if (nextBook.Title.ToLower() == titleToSearch.ToLower()) {
                    return nextBook;
                }
            }
            
            return null; // Null is absence of a book
        }

        // Checkout a book
        public bool CheckoutBook(long patronId, long bookId) {
            Console.WriteLine("Checking out a book...");

            bool patronExists = false;
            bool bookExists = false;
            bool result = false;

            for (int i = 0; i < _patrons.Count; i++) {
                var nextPatron = _patrons[i];
                if (nextPatron.Id == patronId) {
                    patronExists = true;
                }
            }

            // TODO: Handle this!
            if (!patronExists) {
                throw new Exception($"Patron {patronId} does not exist!!");
            }

            for (int i = 0; i < _books.Count; i++) {
                var nextBook = _books[i];
                if (nextBook.Id == bookId) {
                    bookExists = true;

                    if (nextBook.IsCheckedOut) {
                        result = false;
                    } else {
                        result = true;
                        nextBook.IsCheckedOut = true;
                    }
                }
            }

            // TODO: Handle this!
            if (!bookExists) {
                throw new Exception($"Book {bookId} does not exist!!");
            }

            return result;
        }

        // Return a book
        public void ReturnBook() {
            Console.WriteLine("Returning a book...");
        }

    }
}