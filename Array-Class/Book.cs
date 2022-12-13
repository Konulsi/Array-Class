using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    internal class Book
    {
        public string name;
        public string author;


        //public Book()
        //{
        //    Console.WriteLine("empty");
        //}
        //public Book(string text)
        //{
        //    Console.WriteLine(text);
        //}
        //public Book(string text, int number)
        //{
        //    Console.WriteLine(text + " " + number );
        //}

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;

        }   

    }
}
