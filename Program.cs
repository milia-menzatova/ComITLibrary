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

                if (userInput == "c") {
                    // Not done yet
                    theLibrary.CheckoutBook();
                }

                if (userInput == "r") {
                    // Not done yet
                    theLibrary.ReturnBook();
                }

                if (userInput == "s") {
                    // Not done yet
                    Console.WriteLine("What is the title you want to search for?");
                    string titleToSearch = Console.ReadLine();
                    Book result = theLibrary.SearchForBook(titleToSearch);
                    Console.WriteLine("...."); // To be continued
                }

                if (userInput == "q") {
                    break;
                }
            }
        }
    }
}
