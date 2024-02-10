using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans()
        {
            return _transactions;
        }

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetTitle("Harry Potter");
            book1.SetAuthor("J. K. Rowling");

            book book2 = new book();
            book2.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book: ");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book(10, "Norwegian Wood", "Haruki Murakami");
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the author of the book: ");
            string author = Console.ReadLine();
            book book4 = new book(id, title, author);
            book4.SetTrans();

            Console.WriteLine($"\nWe have {book1.GetTrans()} new books.");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        static void displayBooks(book b)
        {
            Console.WriteLine("\nHere's your book information");
            Console.WriteLine($"Book ID: {b.GetId()}");
            Console.WriteLine($"Book Title: {b.GetTitle()}");
            Console.WriteLine($"Author: {b.GetAuthor()}");
        }
    }
}
