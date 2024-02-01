using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChangeDemo
{
    class Product : INotifyPropertyChanged
    {
        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        public Product(int id, int rate)
        {
            id = id;
            _rate = rate;
        }
        public int Id { get; private set; }
        public String ProductName { get; set; } = string.Empty;
        private int _qty = 10;
        public int Qty
        {
            get
            {
                return _qty;
            }
            set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Qty"));
                }
                _qty = value;
            }
        }
        private int _rate;
        public int Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if(this.PropertyChanged!=null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Rate"));
                }
                _rate = value;
            }
        }
        public void ChangeQty(int qty)
        {
            this.Qty = qty;
            Console.WriteLine($"Qty Changed of {this.Id} Product with a {qty}");
        }
        public void ChangeRate(int rate)
        {
            this.Rate = rate;
            Console.WriteLine($"Rate Changed of {this.Id} Product with a {rate}");
        }
    }
}
