using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application
{
    class Book 
    {
        int bookitems;
        int price;
        int qty;
       public void StoreBook()
        {
            List<Book> books = new List<Book>();
            int ch;
            do
            {
                Console.WriteLine("1. 10th Set");
                Console.WriteLine("2. 12th Set");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your Choice:- ");

                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Items:- ");
                        int item = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= item; i++)
                        {
                            Console.WriteLine("Name:- ");
                            int bnm = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Rate:- ");
                            int bp = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qty:- ");
                            int bq = Convert.ToInt32(Console.ReadLine());
                            Book b = new Book
                            {
                                bookitems = bnm,
                                price = bp,
                                qty = bq
                            };
                            books.Add(b);
                        }
                        Console.WriteLine(books.Count);
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine("You are Exit from List");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (ch != 4);
        }
        
    /* public void Add()
        {
            Console.Write("Book Item:- ");
            bookname = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book Price:-");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qty:- ");
            qty = Convert.ToInt32(Console.ReadLine());
        }
        public void Fetch()
        {
            Console.WriteLine($"Book Items:- {bookname}");
            Console.WriteLine($"Book Price:- {price}");
            Console.WriteLine($"Qty:- {qty}");

        }
        public void Remove()
        {
           
        }
        public void Discount()
        {
            if(bookname > 10)
            {
                int discount = 15;
                int amount = price - (price * discount / 100);
                Console.WriteLine($"Amount:- {price}");
                Console.WriteLine($"You get {discount}% discount");
                Console.WriteLine($"After Discount Amount:- {amount}");
            }
            else if(bookitem == 10)
            {
                int discount = 10;
                int amount = price - (price * discount / 100);
                Console.WriteLine($"Amount:- {price}");
                Console.WriteLine($"You get {discount}% discount");
                Console.WriteLine($"Total Amount:- {amount}");
            }
            else
            {
                Console.WriteLine($"Total Amount:- {price}");
            }
        }*/
        


        
    }
}
