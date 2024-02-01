using System;
using System.Collections.Generic;
namespace Store_Application
{
    internal class NoteBook : Items
    {
        public string NotebookName { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
        public List<NoteBook> notebook = new List<NoteBook>();

       

        public void Add(Items i)
        {
            notebook.Add((NoteBook)i);
        }
        public void Fetch()
        {
            Console.WriteLine("The list of Notebooks is....");
            Console.WriteLine("Count: " + notebook.Count);
            foreach (var nb in notebook)
            {
                Console.WriteLine($"NoteBook Name : {nb.NotebookName}\t NoteBook Price : {nb.price}\t NoteBook Qty : {nb.qty}");
            }
        }
        public void Remove(Items i)
        {
            notebook.Remove((NoteBook)i);
        }
        /* public int DiscountCount()
         {
            *//* int ns = qty > 10 ? 20 : 10;
             return (int)(qty * price * (100 - ns) / 100.0);*//*
            if(qty > 10)
             {
                 int discount = 20;
                 int amount = price - (price * discount / 100);
                 return amount;
             }
            else if(qty == 10)
             {
                 int discount = 10;
                 int amount = price - (price * discount / 100);

                 return amount;
             }
            else
             {
                 int amount = price;
                 return amount;
             }
         }
         public int AvalibleBill()
         {
             return qty * price;
         }*/
        public void BuyProduct(string name, int qty)
        {
            double Totalbill = 0;
            foreach (NoteBook tb in notebook)
            {

                if (name == tb.NotebookName)
                {
                    if (qty > tb.qty)
                    {
                        Console.WriteLine("not sufficient product available");
                    }
                    else
                    {
                        double discount;
                        double Actualbill = (qty * tb.price);

                        if (qty >= 10)
                        {

                            discount = Actualbill * 0.20;
                            Totalbill = Actualbill - discount;
                            Console.WriteLine("Total Bill : " + Totalbill);
                        }
                        else if(qty == 10)
                        {
                            discount = Actualbill * 0.10;
                            Totalbill = Actualbill - discount;
                            Console.WriteLine("Total Bill : " + Totalbill);
                        }
                        else
                        {
                            Console.WriteLine("Total Bill : " + Totalbill);
                        }

                    }

                }


            }

        }
        public int Remove(string name, int customer_qty, out int remain_qty)
        {
            int remain = 0;


            foreach (NoteBook tb in notebook)
            {
                if (name == tb.NotebookName)
                {
                    tb.qty -= customer_qty;
                    remain = tb.qty;
                }
            }
            remain_qty = remain;
            return remain_qty;
        }
    }


    }