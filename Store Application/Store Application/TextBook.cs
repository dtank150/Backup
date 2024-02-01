using System;
using System.Collections.Generic;
namespace Store_Application
{
    internal class TextBook:Items
    {
        public string Bookname { get; set; }
        public int rate { get; set; }
        public int qty { get; set; }
        public List<TextBook> textbook = new List<TextBook>();

        public void Add(Items i)
        {
            textbook.Add((TextBook)i);
        }
        public void Fetch()
        {
            Console.WriteLine("The list of Textbooks is....");
            Console.WriteLine("Count: " + textbook.Count);
            foreach (var tb in textbook)
            {
                Console.WriteLine($"Textbook Name : {tb.Bookname}\t Textbook Price : {tb.rate}\t Textbook Qty : {tb.qty}");
            }
        }
        public void BuyProduct(string name, int qty)
        {
            double Totalbill = 0;
           
            foreach (TextBook tb in textbook)
            {

                if (name == tb.Bookname)
                {
                    if (qty > tb.qty)
                    {
                        Console.WriteLine("not sufficient product available");
                    }
                    else
                    {
                        double discount;
                        double Actualbill = (qty * tb.rate);

                        if (qty >= 10)
                        {

                            discount = Actualbill * 0.15;
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


            foreach (TextBook tb in textbook)
            {
                if (name == tb.Bookname)
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