using System;
using System.Collections.Generic;

namespace Store_Application
{
    class Program
    {

        static void Main(string[] args)
        {
            var textbook = new TextBook();
            var notebook = new NoteBook();
            var pen = new Pen();

            int ch;
            int choice;
            do
            {
                Console.WriteLine("1. Add TextBook");
                Console.WriteLine("2. Display TextBook");
                Console.WriteLine("3. Add Notebook");
                Console.WriteLine("4. Display Notebook");
                Console.WriteLine("5. Add Pen");
                Console.WriteLine("6. Display Pen");
                Console.WriteLine("7. Shopping");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Enter your choice:- ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Total Textbook to be added: ");
                        int counttb = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= counttb; i++)
                        {
                            Console.WriteLine("Entre Name:- ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int Rate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Qty:- ");
                            int Qty = Convert.ToInt32(Console.ReadLine());
                            TextBook tb = new TextBook
                            {
                                Bookname = name,
                                rate = Rate,
                                qty = Qty,
                            };
                            textbook.Add(tb);
                            
                        }
                        break;
                    case 2:
                        textbook.Fetch();                        
                        break;
                    case 3:
                        Console.WriteLine("Enter Total Notebook to be added: ");
                        int countnb = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= countnb; i++)
                        {
                            Console.WriteLine("Entre Name:- ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int Rate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Qty:- ");
                            int Qty = Convert.ToInt32(Console.ReadLine());
                            NoteBook nb = new NoteBook
                            {
                                NotebookName = name,
                                price = Rate,
                                qty = Qty,
                            };
                            notebook.Add(nb);
                           



                        }
                        break;
                    case 4:
                        notebook.Fetch();
                        break;
                    case 5:
                        Console.WriteLine("Enter Total Pen to be added: ");
                        int countp = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= countp; i++)
                        {
                            Console.WriteLine("Entre Name:- ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Price:- ");
                            int Rate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Qty:- ");
                            int Qty = Convert.ToInt32(Console.ReadLine());
                            Pen p = new Pen
                            {
                                PensName = name,
                                price = Rate,
                                qty = Qty,
                            };
                            pen.Add(p);
                        }
                        break;
                    case 6:
                        pen.Fetch();
                        break;
                    case 7:
                        do
                        {
                            Console.WriteLine("\n1. Buy TextBook");
                            Console.WriteLine("2. Buy Notebook");
                            Console.WriteLine("3. Buy Pen");

                            Console.WriteLine("Enter your Choice:- ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter Textbook name:- ");
                                    string t_name = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Enter Textbook quantity:- ");
                                    int qty = Convert.ToInt32(Console.ReadLine());

                                    textbook.BuyProduct(t_name, qty);
                                    break;

                                case 2:
                                   Console.WriteLine("enter notebook name:");
                                    string n_name = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("enter notebook quantity=");
                                    int nb_qty = Convert.ToInt32(Console.ReadLine());
                                    notebook.BuyProduct(n_name, nb_qty);
                                    break;


                                case 3:
                                    Console.WriteLine("enter pen name:");
                                    string p_name = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("enter pen quantity=");
                                    int p_qty = Convert.ToInt32(Console.ReadLine());

                                    pen.BuyProduct(p_name, p_qty);
                                    break;
                            }
                        } while (choice > 3);
                        break;
                    case 8:
                        break;
                    }
            } while (ch != 8);
           
            Console.ReadKey();
            
        }
        
    }
}
