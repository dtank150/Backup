using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application
{
    class Pen /*: List*/
    {
        string Penitems;
        int Rate;
        int Qty;
        public void penstore()
        {
            List<Pen> pens = new List<Pen>();
            int ch;
            do
            {
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
                            Pen ps = new Pen
                            {
                                Penitems = pnm,
                                Rate = pr,
                                Qty = pq
                            };
                            pens.Add(ps);
                        }
                        Console.WriteLine(pens.Count);
                        break;
                   default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (ch != 4);
        }
    }
}
        /*public void Add() {
            Console.Write("Pen Item:- ");
            Penitems = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pen Price:-");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qty:- ");
            Qty = Convert.ToInt32(Console.ReadLine());
        }
        public void Fetch() 
        {
            Console.WriteLine($"Pen Items:- {Penitems}");
            Console.WriteLine($"Pen Price:- {Rate}");
            Console.WriteLine($"Qty:- {Qty}");
        }
        public void Remove() { }
        public void Discount()
        {
            if (Penitems > 10)
            {
                int discount = 15;
                int amount = Rate - (Rate * discount / 100);
                Console.WriteLine($"Amount:- {Rate}");
                Console.WriteLine($"You get {discount}% discount");
                Console.WriteLine($"After Discount Amount:- {amount}");
            }
            else if (Penitems == 10)
            {
                int discount = 10;
                int amount = Rate - (Rate * discount / 100);
                Console.WriteLine($"Amount:- {Rate}");
                Console.WriteLine($"You get {discount}% discount");
                Console.WriteLine($"Total Amount:- {amount}");
            }
            else
            {
                Console.WriteLine($"Total Amount:- {Rate}");
            }
        }*/
    

