using System;
using task8;
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library(5);

        library.AddBook(new Book("Miguel de Cervantes", "Don Quixote", 180));
        library.AddBook(new Book("Jane Eyre", "Charlotte Brontë", 281));
        library.AddBook(new Book("1984", "George Orwell", 328));

        Console.WriteLine("Books in the library:");
        library.DisplayBooks();

        Book bookToRemove = new Book("1984", "George Orwell", 328);
        library.RemoveBook(bookToRemove);

        Console.WriteLine("\nAfter removing a book:");
        library.DisplayBooks();
    }
}