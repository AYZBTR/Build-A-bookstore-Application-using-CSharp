using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Application_Using_CSharp
{
    class Book
    {
        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Book> BuyABook(List<Book> thoseBooks)
        {
            Console.WriteLine("Welcome to our Book store!\n");

            List<Book> books = new List<Book>();
            bool more;

            do

            {
                bool Y = false;

                Console.Write("Which book are you intrested in?: ");
                string recei = Console.ReadLine();
                foreach (var book in thoseBooks)
                {
                    if (book.Name.Contains(recei))
                    {
                        Console.WriteLine("Book Found: {0}", book.Name);
                        Console.Write("Are you buying this book (Y/N): ");
                        string stored = Console.ReadLine().ToLower();

                        if (stored.StartsWith("y"))

                        {
                            Console.Write("Adding the book {0} to your shopping list \n", book.Name);
                            books.Add(book);
                            Y = true;
                        }

                    }

                }
                if (Y != true)

                {
                    Console.WriteLine("The book you were looking for was not found!");
                }
                Console.Write("More book?(Y/N): ");
                string deci = Console.ReadLine().ToLower();
                if (deci.StartsWith("y"))
                    more = true;
                else
                    more = false;

            } while (more);
            return books;
        }

        public double CalcTotalPrice(List<Book> thosebooks)

        {
            double TotalPrice = 0;

            if (thosebooks.Count != 0)
            {
                foreach (var item in thosebooks)
                {
                    TotalPrice = TotalPrice + item.Price;

                }
            }


            return TotalPrice;

        }
    }
}
    

