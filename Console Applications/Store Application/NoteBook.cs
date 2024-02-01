using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application
{
    class NoteBook /*: List
*/    {
        string Notebookitems;
        int Rate;
        int Qty;
        public void NoteBookStore()
        {
            List<NoteBook> notebook = new List<NoteBook>();
            int ch;
            do
            {
                Console.WriteLine("1. 100 Page Set");
                Console.WriteLine("2. 200 Page Set");
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
                            string nnm = Console.ReadLine();
                            Console.WriteLine("Rate:- ");
                            int nr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qty:- ");
                            int nq = Convert.ToInt32(Console.ReadLine());
                            NoteBook nb = new NoteBook
                            {
                                Notebookitems = nnm,
                                Rate = nr,
                                Qty = nq
                            };
                            notebook.Add(nb);
                        }
                        Console.WriteLine(notebook.Count);
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
    }
      /*  public void Add() 
        {
            Console.Write("Notebook Item:- ");
            Notebookitems = Convert.ToInt32(Console.ReadLine());
            Console.Write("Notebook Price:-");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qty:- ");
            Qty = Convert.ToInt32(Console.ReadLine());
        }
        public void Fetch()
        {
            Console.WriteLine($"Notebook Items:- {Notebookitems}");
            Console.WriteLine($"Notebook Price:- {Rate}");
            Console.WriteLine($"Qty:- {Qty}");
        }
        public void Remove() { }
        public void Discount()
        {
            if (Notebookitems > 10)
            {
                int discount = 20;
                int amount = Rate - (Rate * discount / 100);
                Console.WriteLine($"Amount:- {Rate}");
                Console.WriteLine($"You get {discount}% discount");
                Console.WriteLine($"After Discount Amount:- {amount}");
            }
            else if (Notebookitems == 10)
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
    }

