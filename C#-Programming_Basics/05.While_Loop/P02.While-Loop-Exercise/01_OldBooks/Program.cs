using System;

namespace _01_OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string nextBookName = Console.ReadLine();

            int bookCounter = 0;

            while (nextBookName != "No More Books")
            {
                if(nextBookName == searchedBook)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }

                bookCounter++;
                nextBookName = Console.ReadLine();
            }


            if(nextBookName == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
