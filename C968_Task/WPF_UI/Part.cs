using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UI
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int inStock;
        private decimal price;
        private int min;
        private int max;

        //Public vars and the getter and setter functions for the Part class 
        public int PartID //For the purpose of showing that I understand the long-hand method of calling a getter/setter, from here I switch to the short-hand way of doing it
        {
            get
            {
                return this.partID;
            }
            set
            {
                this.partID = value;
            }
        }
        public string Name { get; set; }
        public int InStock { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
