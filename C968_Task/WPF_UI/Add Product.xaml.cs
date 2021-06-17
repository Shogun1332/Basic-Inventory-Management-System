using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for Add_Product.xaml
    /// </summary>
    public partial class Add_Product : Window
    {
        public Add_Product()
        {
            InitializeComponent();
            LoadFormData();
        }

        public BindingList<Part> preSaveIncludedParts = new BindingList<Part>();
        public void LoadFormData()
        {
            all_Parts_DataGrid.ItemsSource = Inventory.Parts;
        }

        private void add_Prod_Search_Button_Click(object sender, RoutedEventArgs e)
        {
            if (add_Prod_Search_TextBox.Text.Count() > 0)
            {
                var filtered = Inventory.Parts.Where<Part>(part => part.PartID.ToString().Equals(add_Prod_Search_TextBox.Text));
                all_Parts_DataGrid.ItemsSource = filtered;
            }
            else
            {
                all_Parts_DataGrid.ItemsSource = Inventory.Parts;
            }
        }

        private void parts_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Part part in all_Parts_DataGrid.SelectedItems)
            {
                preSaveIncludedParts.Add(part);
            }
            product_DataGrid.ItemsSource = preSaveIncludedParts;
        }

        private void product_Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Part part in product_DataGrid.SelectedItems)
            {
                preSaveIncludedParts.Remove(part);
            }
        }

        private void product_Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //TryParse methods for the need-to-be-numeric values and Exception handling for invalid numeric values
            int minTextVal;
            int maxTextVal;
            int invTextVal;
            decimal priceTextVal;

            bool minParsable = int.TryParse(add_Prod_Min_TextBox.Text, out minTextVal);
            bool maxParsable = int.TryParse(add_Prod_Max_TextBox.Text, out maxTextVal);
            bool invParsable = int.TryParse(add_Prod_Inventory_TextBox.Text, out invTextVal);
            bool priceParsable = decimal.TryParse(add_Prod_Price_TextBox.Text, out priceTextVal);

            if (!invParsable || !priceParsable || !minParsable || !maxParsable)
            {
                if (!invParsable)
                {
                    MessageBox.Show("Error Code 005: Current inventory stock value must be a numeric value.");
                    return;
                }
                else if (!priceParsable)
                {
                    MessageBox.Show("Error Code 006: Price / Cost must contain a decimal value.");
                    return;
                }
                else if (!minParsable)
                {
                    MessageBox.Show("Error Code 003: Minimum stock value must be a numeric value.");
                    return;
                }
                else if (!maxParsable)
                {
                    MessageBox.Show("Error Code 004: Maximum stock value must be a numeric value.");
                    return;
                }
            }

            //Controls to ensure numeric values are within appropriate levels
            if (minTextVal > maxTextVal)
            {
                MessageBox.Show("Error Code 001: Minimum stock cannot be more than the maximum stock value");
                return;
            }

            if (invTextVal < minTextVal || invTextVal > maxTextVal)
            {
                MessageBox.Show("Error Code 002: Current inventory stocked must be greater than the minimum stock level and less than the maximum stock level.");
                return;
            }

            Product product = new Product(int.Parse(add_Prod_ID_TextBox.Text), add_Prod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal);
            foreach (Part part in preSaveIncludedParts)
            {
                product.AddIncludedPart(part);
            }
            Inventory.Products.Add(product);
            this.Close();
        }

        private void product_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
