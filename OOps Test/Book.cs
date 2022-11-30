using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Hand_Written_Test
{
    class Book
    {
        String title;
        String author;
        int price;

        public Book(String title, String author, int price)
        {
            title = this.title;
            author = this.author;
            price = this.price;
        }

        public Book()
        {

        }

        public String Title
        {
            set { title = value; }
            get { return title; }
        }

        public String Author
        {
            set { author = value; }
            get { return author; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }
    }

    class BookDemo
    {
        static void Main(string[] args)
        {
            BookDemo B = new BookDemo();
            Book b = new Book("Developing java Sofware", "Russel Winderrand", 100);

            Console.WriteLine(b.Title);
            Console.WriteLine(b.Author);
            Console.WriteLine(b.Price);
        }
    }
}
