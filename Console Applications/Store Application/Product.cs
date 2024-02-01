using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application
{
    class Product
    {
        string Name;
        int Rate;
        int Qty;
        public void display()
        {
            List<Product> products = new List<Product>();
            int ch;
            do
            {
                Console.WriteLine("1. Texbook Set");
                Console.WriteLine("2. Notebook Set");
                Console.WriteLine("3. Pen Set");
                Console.WriteLine("4. Exit");
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
                            string pnm = Console.ReadLine();
                            Console.WriteLine("Rate:- ");
                            int pr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qty:- ");
                            int pq = Convert.ToInt32(Console.ReadLine());
                            Product p = new Product
                            {
                                Name = pnm,
                                Rate = pr,
                                Qty = pq
                            };
                            products.Add(p);
                        }
                        Console.WriteLine(products.Count);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("You are Exit from List");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (ch != 4);
           /* List<string> product = new List<string>();
            Console.WriteLine("Textbook Set ");
            Console.WriteLine("Notebook Set");
            Console.WriteLine("Pen set");
            foreach (object products in product)
            {
                switch (products)
                {
                    case 1:
                        Console.WriteLine("You are selected Textbook");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("You are Exit for Application");
                        break;
                    default:
                        break;
                }
            }*/

            /*   while (true)
               {
                   Console.WriteLine("10th TextBook set");
                   string tbs1 = Console.ReadLine();

                   Console.WriteLine("12th TextBook Set");
                   string tbs2 = Console.ReadLine();

                   Console.WriteLine("100 Pages Book");
                   string  nbs1= Console.ReadLine();

                   Console.WriteLine("200 pages Book");
                   string nbs2 = Console.ReadLine();

                   Console.WriteLine("Pen Set");
                   string ps = Console.ReadLine();



               }
            */
        }
        /* public void store()
         {

             List<string> list = new List<string>();
             list.Add("10th set");
             list.Add("12th set");
             list.Add("100 Page books");
             list.Add("200 Page books");
             list.Add("Pen Set");
             foreach (object each in list)
             {
                 Console.WriteLine(each);
             }
         }*/
    }
}
