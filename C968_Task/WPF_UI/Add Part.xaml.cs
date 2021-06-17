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
using System.Text.RegularExpressions;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for Add_Part.xaml
    /// </summary>
    public partial class Add_Part : Window
    {
        public Add_Part()
        {
            InitializeComponent();
        }


        private void add_Part_Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //TryParse methods for the need-to-be-numeric values and Exception handling for invalid numeric values
            int minTextVal;
            int maxTextVal;
            int invTextVal;
            decimal priceTextVal;

            bool minParsable = int.TryParse(add_Min_TextBox.Text, out minTextVal);
            bool maxParsable = int.TryParse(add_Max_TextBox.Text, out maxTextVal);
            bool invParsable = int.TryParse(add_Inventory_TextBox.Text, out invTextVal);
            bool priceParsable = decimal.TryParse(add_Price_TextBox.Text, out priceTextVal);

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

            //Determine what type of part to create based on the radio buttons
            if ((bool)add_Part_IH_Radio.IsChecked)
            {
                InHousePart inHouse = new InHousePart(int.Parse(add_Part_ID_TextBox.Text), add_Name_TextBox.Text, int.Parse(add_Inventory_TextBox.Text), decimal.Parse(add_Price_TextBox.Text), minTextVal, maxTextVal, int.Parse(add_CompanyName_TextBox.Text));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutsourcedPart OSPart = new OutsourcedPart(int.Parse(add_Part_ID_TextBox.Text), add_Name_TextBox.Text, int.Parse(add_Inventory_TextBox.Text), decimal.Parse(add_Price_TextBox.Text), minTextVal, maxTextVal, add_CompanyName_TextBox.Text);
                Inventory.AddPart(OSPart);
            }
            this.Close();
        }

        private void add_Part_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Event Handler for switching the IHorOS textblock text between Machine ID and Company Name depending on radio button selection
        private void add_Part_Radio_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                if ((bool)add_Part_IH_Radio.IsChecked)
                {
                    IHorOS.Text = "Machine ID";
                }
                else if ((bool)add_Part_Out_Radio.IsChecked)
                {
                    IHorOS.Text = "Company Name";
                }
            }
        }
    }
}
