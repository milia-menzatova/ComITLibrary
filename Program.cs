using System;

namespace ComitLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var theLibrary = new LibrarySystem();

            Console.WriteLine("Welcome to the ComIT Library!");

            while (true) {
                Console.WriteLine("\nc - checkout a book; r - return a book; s - search for a book; q - quit");
                string userInput = Console.ReadLine();

                // Checkout a book
                if (userInput == "c") {
                    Console.WriteLine("Please enter patron Id: ");
                    string patronIdInput = Console.ReadLine();
                    long patronId = Convert.ToInt64(patronIdInput);

                    Console.WriteLine("Please enter the book Id: ");
                    string bookIdInput = Console.ReadLine();
                    long bookId = Convert.ToInt64(bookIdInput);

                    bool success = theLibrary.CheckoutBook(patronId, bookId);
                    if (success) {
                        Console.WriteLine("Book has been checked out!");
                    } else {
                        Console.WriteLine("Something went wrong. Could not check out book");
                    }
                }

                // Return a book
                if (userInput == "r") {
                    // Not done yet
                    theLibrary.ReturnBook();
                }

                // Search for a book
                if (userInput == "s") {
                    Console.WriteLine("What is the title you want to search for?");
                    string titleToSearch = Console.ReadLine();
                    Book result = theLibrary.SearchForBook(titleToSearch);
                    
                    if (result == null) {
                        Console.WriteLine("Book was not found");
                    } else {
                        Console.WriteLine($"Found a book with Id: {result.Id} ");
                    }
                }

                // Quit
                if (userInput == "q") {
                    break;
                }
            }
        }
    }
}
