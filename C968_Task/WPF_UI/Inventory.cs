﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}