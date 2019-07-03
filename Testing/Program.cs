using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?"+number.hasValue);
            Console.WriteLine("Value: "+number.GetValueOrDefault());

            //var book = new Book {Isbn = "1234", Title = "C# Advanced"};

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.add("1234", new Book());
        }
    }
}
