using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_UI
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void GenerateStartingData()
        {
            //Generate starting products
            Product starterProd1 = new Product(0, "Red Bicycle", 15, 11.44m, 1, 25);
            Product starterProd2 = new Product(1, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Product starterProd3 = new Product(2, "Blue Bicycle", 5, 12.77m, 1, 25);

            Products.Add(starterProd1);
            Products.Add(starterProd2);
            Products.Add(starterProd3);

            //Generate starting parts
            Part starterPart1 = new InHousePart(0, "Wheel", 15, 12.11m, 5, 25);
            Part starterPart2 = new InHousePart(1, "Pedal", 11, 8.22m, 5, 25);
            Part starterPart3 = new InHousePart(2, "Chain", 12, 8.33m, 5, 25);
            Part starterPart4 = new InHousePart(3, "Seat", 8, 4.55m, 2, 15);

            Parts.Add(starterPart1);
            Parts.Add(starterPart2);
            Parts.Add(starterPart3);
            Parts.Add(starterPart4);

            //Add starter parts to the starter products
            starterProd1.IncludedParts.Add(starterPart1);
            starterProd1.IncludedParts.Add(starterPart2);
            starterProd1.IncludedParts.Add(starterPart3);
            starterProd1.IncludedParts.Add(starterPart4);

            starterProd2.IncludedParts.Add(starterPart1);
            starterProd2.IncludedParts.Add(starterPart2);
            starterProd2.IncludedParts.Add(starterPart3);
            starterProd2.IncludedParts.Add(starterPart4);

            starterProd3.IncludedParts.Add(starterPart1);
            starterProd3.IncludedParts.Add(starterPart2);
            starterProd3.IncludedParts.Add(starterPart3);
            starterProd3.IncludedParts.Add(starterPart4);

        }

        //Add Methods
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }


        //Removal Methods
        public static bool RemoveProduct(int ProdID)
        {
            List<Product> deleteList = new List<Product>();
            bool prodFound = false;
            foreach(Product product in Products)
            {
                if (ProdID == product.ProductID)
                {
                    if (product.IncludedParts.Count != 0)
                    {
                        prodFound = true;
                        deleteList.Add(product);
                        return prodFound;
                    }
                    else
                    {
                        prodFound = false;
                        MessageBox.Show("Unable to delete product while there are parts associated with it. Please remove the included parts and try again.", "Removal Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return prodFound;
                    }
                }
            }
            foreach (Product product in deleteList)
            {
                Products.Remove(product);
            }
            return prodFound;
        }

        public static bool RemovePart(int PartID)
        {
            List<Part> deleteList = new List<Part>();
            bool partFound = false;
            foreach (Part part in Parts)
            {
                if (PartID == part.PartID)
                {
                    deleteList.Add(part);
                    partFound = true;
                }
            }
            foreach (Part part in deleteList)
            {
                Parts.Remove(part);
            }
            return partFound;
        }

        //Searching Methods
        public static Product SearchProducts(int ProdID) //not all code paths return a value
        {
            bool prodFound = false;
            foreach (Product product in Products)
            {
                if (product.ProductID == ProdID)
                {
                    prodFound = true;
                    return product;
                }
            }
            Product emptyProd = new Product();
            return emptyProd;
        }

        public static Part SearchParts(int PartID) //not all code paths return a value
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        } 

        //Update Methods
        public static void UpdateProduct(int ProdID, Product updatedProd)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == ProdID)
                {
                    currentProd.Name = updatedProd.Name;
                    currentProd.InStock = updatedProd.InStock;
                    currentProd.Price = updatedProd.Price;
                    currentProd.Min = updatedProd.Min;
                    currentProd.Max = updatedProd.Max;
                    currentProd.IncludedParts = updatedProd.IncludedParts;
                }
            }
        }

        //Post-code, Not really useable, need to update on inHouse/Outsourced parts instead
        /*public static void UpdatePart(int PartID, Part updatedPart) 
        {
            foreach (Part currentPart in Parts)
            {
                if (currentPart.PartID == PartID)
                {
                    currentPart.Name = updatedPart.Name;
                    currentPart.Name = updatedPart.Name;
                    currentPart.Name = updatedPart.Name;
                    currentPart.Name = updatedPart.Name;
                    currentPart.Name = updatedPart.Name;
                    currentPart.Name = updatedPart.Name;
                }
            }
        } */

        public static void UpdateIHPart(int PartID, InHousePart IHPart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(InHousePart))
                {
                    InHousePart newIHPart = (InHousePart)Parts[i];

                    if (newIHPart.PartID == PartID)
                    {
                        newIHPart.Name = IHPart.Name;
                        newIHPart.InStock = IHPart.InStock;
                        newIHPart.Price = IHPart.Price;
                        newIHPart.Min = IHPart.Min;
                        newIHPart.Max = IHPart.Max;
                        newIHPart.MachineID = IHPart.MachineID;
                    }
                }
            }
        }

        public static void UpdateOSPart(int PartID, OutsourcedPart OSPart)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(OutsourcedPart))
                {
                    OutsourcedPart newOSPart = (OutsourcedPart)Parts[i];

                    if (newOSPart.PartID == PartID)
                    {
                        newOSPart.Name = OSPart.Name;
                        newOSPart.InStock = OSPart.InStock;
                        newOSPart.Price = OSPart.Price;
                        newOSPart.Min = OSPart.Min;
                        newOSPart.Max = OSPart.Max;
                        newOSPart.CompanyName = OSPart.CompanyName;
                    }
                }
            }
        }

    }
}
