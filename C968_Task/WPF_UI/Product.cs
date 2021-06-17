using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UI
{
    public class Product
    {
        public BindingList<Part> IncludedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private int inStock;
        private decimal price;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public string Price
        {
            get
            {
                return price.ToString("C");
            }
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

        //Constructor Time
        public Product() { }
        public Product(int productID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price.ToString("C");
            Min = min;
            Max = max;
        }

        //Product Methods
        public void AddIncludedPart(Part part)
        {
            IncludedParts.Add(part);
        }

        public void RemoveIncludedPart(int partID)
        {
            foreach(Part part in IncludedParts)
            {
                if(part.PartID == partID)
                {
                    IncludedParts.Remove(part);
                    return;
                }
            }
            IncludedParts.ResetBindings();
        }

        public Part SearchIncludedPart(int PartID)
        {
            foreach (Part part in IncludedParts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            InHousePart emptyIHPart = new InHousePart();
            return emptyIHPart;
        }
    }
}
