using System;
using System.Collections.Generic;
namespace Store_Application
{
    internal class Pen : Items
    {
        public string PensName { get; set; }
        public int price { get; set; }
        public int qty { get; set; }

        public List<Pen> pens = new List<Pen>();
        public void Add(Items i)
        {
            pens.Add((Pen)i);
        }
        public void Fetch()
        {
            Console.WriteLine("The list of Pen is....");
            Console.WriteLine("Count: " + pens.Count);
            foreach (Pen p in pens)
            {
                Console.WriteLine($"Pen Name : {p.PensName}\t Pen Price : {p.price}\t Pen Qty : {p.qty}");
            }
        }
        public void BuyProduct(string name, int qty)
        {
            double Totalbill = 0;
            

            foreach (Pen p in pens)
            {

                if (name == p.PensName)
                {
                    if (qty > p.qty)
                    {
                        Console.WriteLine("not sufficient product available");
                        
                    }
                    else
                    {
                        Totalbill = qty * p.price;
                        Console.WriteLine("Total Bill : " + Totalbill);

                    }

                }


            }
            
        }
        public int Remove(string name, int customer_qty, out int remain_qty)
        {
            remain_qty = 0;
            int avail_qty = 0;
            foreach (Pen p in pens)
            {
                if (name == p.PensName)
                {
                    p.qty -= customer_qty;

                }
                avail_qty = p.qty;

            }
            return remain_qty = avail_qty;
        }

    }
}