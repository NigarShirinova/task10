using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Library
    {
        private Book[] books;
        private int count;

        public Library(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

        public void RemoveBook(Book book)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (books[i].Title == book.Title && books[i].Author == book.Author && books[i].Pages == book.Pages)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }

                    count--;
                    found = true;
                    Console.WriteLine("Book removed successfully.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the library.");
            }
        }

        public void DisplayBooks()
        {
            
            Console.WriteLine("Books in the library:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Title: {books[i].Title}");
                Console.WriteLine($"Author: {books[i].Author}");
                Console.WriteLine($"Pages: {books[i].Pages}");
                Console.WriteLine();
            }
        }
    }

        
}
