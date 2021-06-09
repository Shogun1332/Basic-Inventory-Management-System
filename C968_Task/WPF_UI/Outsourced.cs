using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UI
{
    public class OutsourcedPart : Part
    {
        private string companyName;
        public string CompanyName { get; set; }

        public OutsourcedPart() { }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
        }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
