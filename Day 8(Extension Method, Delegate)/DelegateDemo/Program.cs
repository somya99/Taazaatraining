using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();
            AddBooks(bookDB);
            Console.WriteLine("Paperbackbooks Title");
            ProcessBookCallbackDelegate d = new ProcessBookCallbackDelegate(sellBook);
            d += rentBook;
            bookDB.ProcessPaperbackBooks(d);

        }
        static void sellBook(Book b)
        {
            Console.WriteLine($"Title Sold = {b.Title}");
        }
        static void rentBook(Book b)
        {
            Console.WriteLine($"Book rented = {b.Title}");
        }
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("HELLO", "abc", 236, true);
            bookDB.AddBook("There", "xyz", 735, true);
            bookDB.AddBook("Sparkle", "def", 546, true);
        }
        //delegate void Del(string str);
        //static void Main(string[] args)
        //{
        //    Del d = new Del(Notify);
        //    d("India");
        //    d("USA");
        //    abc(d);
        //    d = Greet;
        //    abc(d);
        //}
        //static void foo(int a)
        //{
        //    Console.WriteLine(a);
        //}
        //static void Notify(string a)
        //{
        //    Console.WriteLine($"Notification received for: {a}");
        //}
        //static void Greet(string a)
        //{
        //    Console.WriteLine($"Greeting received for: {a}");
        //}
        //static void abc(Del d)
        //{
        //    d("Japan");
        //}
    }
}
