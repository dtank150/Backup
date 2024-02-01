using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Store_Application
{
    class Program
    {

        static void Main(string[] args)
        {
            Book b = new Book();
            b.Add();
            b.Fetch();
            b.Discount();
            

            /*Product p = new Product();
            p.display();
            Book b = new Book();
            b.StoreBook();
            NoteBook nb = new NoteBook();
            nb.NoteBookStore();
            Pen ps = new Pen();
            ps.penstore();
            Console.Read();*/
            /*NoteBook nb = new NoteBook();
            nb.Add();
            nb.Fetch();
            nb.Discount();

            Pen p = new Pen();
            p.Add();
            p.Fetch();
            p.Discount();
            Console.Read();*/
            

            
                Console.WriteLine("1. 10 book set");
                Console.WriteLine("2. 12 book set");
                int selectSet = Convert.ToInt32(Console.ReadLine());
                switch (selectSet)
                {
                    case 1:
                        TenBookSet();
                        break;
                    case 2:
                        TwelvwBookSet();
                        break;
                }

                void TenBookSet()
                {
                    var Student = new List<Program>()
            {
                new Program("10th Book Set",850)

            };

                    var result = from s in Student
                                     //where s.Name == "Bill"
                                 select s;
                    Console.WriteLine("How many set have you want?");
                    int bookQty = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(bookQty);
                    foreach (var student in result)
                        if (student != null)
                        {
                            if (bookQty > 10)
                            {
                                int actualPrice = student.price * bookQty;
                                Console.WriteLine("Actual Price of 10th Notebooks is " + actualPrice);

                                double discountPrice = (actualPrice * 20) / 100;
                                Console.WriteLine("Discounted Price of 10th Notebooks is " + discountPrice);
                                Console.WriteLine("Total Pay for Notebook peice is " + (actualPrice - discountPrice));

                            }
                            else
                            {
                                int actualPrice = student.price * bookQty;
                                Console.WriteLine("Actual Price of 10th Notebooks is " + actualPrice);

                                double discountPrice = (actualPrice * 10) / 100;
                                Console.WriteLine("Discounted Price of 10th Notebooks is " + discountPrice);
                                Console.WriteLine("Total Pay for Notebook peice is " + (actualPrice - discountPrice));

                            }
                        }
                }

                void TwelvwBookSet()
                {
                    var Student = new List<Program>()
            {
                new Program("12th Book Set",1150)

            };

                    var result = from s in Student
                                     //where s.Name == "Bill"
                                 select s;
                    Console.WriteLine("How many set have you want?");
                    int bookQty = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(bookQty);
                    foreach (var student in result)
                        if (bookQty > 10)
                        {
                            int actualPrice = student.price * bookQty;
                            Console.WriteLine("Actual Price of 10th Notebooks is " + actualPrice);

                            double discountPrice = (actualPrice * 20) / 100;
                            Console.WriteLine("Discounted Price of 10th Notebooks is " + discountPrice);
                            Console.WriteLine("Total Pay: " + (actualPrice - discountPrice));

                        }
                        else
                        {
                            int actualPrice = student.price * bookQty;
                            Console.WriteLine("Actual Price of 10th Notebooks is " + actualPrice);

                            double discountPrice = (actualPrice * 10) / 100;
                            Console.WriteLine("Discounted Price of 10th Notebooks is " + discountPrice);
                            Console.WriteLine("Total Pay: " + (actualPrice - discountPrice));

                        }
                }

                Console.ReadKey();

            }

    }
}
