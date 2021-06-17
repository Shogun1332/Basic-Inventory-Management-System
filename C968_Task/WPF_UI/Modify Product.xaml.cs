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
    /// Interaction logic for Add_Part.xaml
    /// </summary>
    public partial class Modify_Product : Window
    {
        //Bound list to hold Included Parts data for access within the Modify_Product class
        public BindingList<Part> localIncludedParts = new BindingList<Part>();

        public Modify_Product(Product product)
        {
            InitializeComponent();

            mod_Prod_ID_TextBox.Text = product.ProductID.ToString();
            mod_Prod_Name_TextBox.Text = product.Name;
            mod_Prod_Inventory_TextBox.Text = product.InStock.ToString();
            mod_Prod_Price_TextBox.Text = product.Price.Substring(1).ToString();
            mod_Prod_Min_TextBox.Text = product.Min.ToString();
            mod_Prod_Max_TextBox.Text = product.Max.ToString();
            localIncludedParts = product.IncludedParts;

            LoadFormData();
        }

        public void LoadFormData()
        {
            mod_Parts_DataGrid.ItemsSource = Inventory.Parts;
            mod_Product_DataGrid.ItemsSource = localIncludedParts;
        }

        private void mod_Prod_Search_Button_Click(object sender, RoutedEventArgs e)
        {
            if (modd_Prod_Search_TextBox.Text.Count() > 0)
            {
                var filtered = Inventory.Parts.Where<Part>(part => part.PartID.ToString().Equals(modd_Prod_Search_TextBox.Text));
                mod_Parts_DataGrid.ItemsSource = filtered;
            }
            else
            {
                mod_Parts_DataGrid.ItemsSource = Inventory.Parts;
            }
        }

        private void mod_Parts_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Part part in mod_Parts_DataGrid.SelectedItems)
            {
                localIncludedParts.Add(part);
            }
        }

        private void mod_Product_Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Part> deleteList = new List<Part>();
            foreach (Part part in mod_Product_DataGrid.SelectedItems)
            {
                deleteList.Add(part);
            }
            foreach (Part part in deleteList)
            {
                localIncludedParts.Remove(part);
            }
            localIncludedParts.ResetBindings();
        }

        private void mod_Product_Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //TryParse methods for the need-to-be-numeric values and Exception handling for invalid numeric values
            int minTextVal;
            int maxTextVal;
            int invTextVal;
            decimal priceTextVal;

            bool minParsable = int.TryParse(mod_Prod_Min_TextBox.Text, out minTextVal);
            bool maxParsable = int.TryParse(mod_Prod_Max_TextBox.Text, out maxTextVal);
            bool invParsable = int.TryParse(mod_Prod_Inventory_TextBox.Text, out invTextVal);
            bool priceParsable = decimal.TryParse(mod_Prod_Price_TextBox.Text, out priceTextVal);

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

            Product product = new Product(int.Parse(mod_Prod_ID_TextBox.Text), mod_Prod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal);
            foreach (Part part in localIncludedParts)
            {
                product.AddIncludedPart(part);
            }
            Inventory.UpdateProduct(int.Parse(mod_Prod_ID_TextBox.Text), product);
            this.Close();
        }

        private void mod_Product_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
