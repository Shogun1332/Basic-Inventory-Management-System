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

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for Add_Part.xaml
    /// </summary>
    public partial class Modify_Part : Window
    {
        bool IHRadio;
        bool OSRadio;
        public Modify_Part(InHousePart IHPart)
        {
            InitializeComponent();

            mod_Part_ID_TextBox.Text = IHPart.PartID.ToString();
            mod_Name_TextBox.Text = IHPart.Name;
            mod_Inventory_TextBox.Text = IHPart.InStock.ToString();
            mod_Price_TextBox.Text = IHPart.Price.Substring(1).ToString();
            mod_Min_TextBox.Text = IHPart.Min.ToString();
            mod_Max_TextBox.Text = IHPart.Max.ToString();
            mod_CompanyName_TextBox.Text = IHPart.MachineID.ToString();
            mod_Part_IH_Radio.IsChecked = true;
            IHRadio = true;
        }
        public Modify_Part(OutsourcedPart OSPart)
        {
            InitializeComponent();

            mod_Part_ID_TextBox.Text = OSPart.PartID.ToString();
            mod_Name_TextBox.Text = OSPart.Name;
            mod_Inventory_TextBox.Text = OSPart.InStock.ToString();
            mod_Price_TextBox.Text = OSPart.Price.Substring(1).ToString();
            mod_Min_TextBox.Text = OSPart.Min.ToString();
            mod_Max_TextBox.Text = OSPart.Max.ToString();
            mod_CompanyName_TextBox.Text = OSPart.CompanyName;
            mod_Part_Out_Radio.IsChecked = true;
            OSRadio = true;
        }

        private void mod_Part_Save_Button_Click(object sender, RoutedEventArgs e)
        {
            //TryParse methods for the need-to-be-numeric values and Exception handling for invalid numeric values
            int minTextVal;
            int maxTextVal;
            int invTextVal;
            decimal priceTextVal;
            int partIDNum;
            int machineIDNum;

            bool minParsable = int.TryParse(mod_Min_TextBox.Text, out minTextVal);
            bool maxParsable = int.TryParse(mod_Max_TextBox.Text, out maxTextVal);
            bool invParsable = int.TryParse(mod_Inventory_TextBox.Text, out invTextVal);
            bool priceParsable = decimal.TryParse(mod_Price_TextBox.Text, out priceTextVal);
            bool partIDParsable = int.TryParse(mod_Part_ID_TextBox.Text, out partIDNum);
            bool machineIDParsable = int.TryParse(mod_CompanyName_TextBox.Text, out machineIDNum);

            if (!invParsable || !priceParsable || !minParsable || !maxParsable || !partIDParsable || (!machineIDParsable && (bool)mod_Part_IH_Radio.IsChecked))
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
                else if (!partIDParsable)
                {
                    MessageBox.Show("Error Code 007: Part ID must contain a numeric value.");
                    return;
                }
                else if (!machineIDParsable && (bool)mod_Part_IH_Radio.IsChecked)
                {
                    MessageBox.Show("Error Code 008: Machine ID must contain a numeric value.");
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

            //Determine what type of part to update based on the radio buttons
            if ((bool)mod_Part_IH_Radio.IsChecked && IHRadio)
            {
                InHousePart inHouse = new InHousePart(int.Parse(mod_Part_ID_TextBox.Text), mod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal, int.Parse(mod_CompanyName_TextBox.Text));
                Inventory.UpdateIHPart(int.Parse(mod_Part_ID_TextBox.Text), inHouse);
            }
            else if ((bool)mod_Part_IH_Radio.IsChecked && OSRadio)
            {
                Inventory.RemovePart(int.Parse(mod_Part_ID_TextBox.Text));
                InHousePart inHouse = new InHousePart(int.Parse(mod_Part_ID_TextBox.Text), mod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal, int.Parse(mod_CompanyName_TextBox.Text));
                Inventory.AddPart(inHouse);
            }
            else if ((bool)mod_Part_Out_Radio.IsChecked && IHRadio)
            {
                Inventory.RemovePart(int.Parse(mod_Part_ID_TextBox.Text));
                OutsourcedPart OSPart = new OutsourcedPart(int.Parse(mod_Part_ID_TextBox.Text), mod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal, mod_CompanyName_TextBox.Text);
                Inventory.AddPart(OSPart);
            }
            else
            {
                OutsourcedPart OSPart = new OutsourcedPart(int.Parse(mod_Part_ID_TextBox.Text), mod_Name_TextBox.Text, invTextVal, priceTextVal, minTextVal, maxTextVal, mod_CompanyName_TextBox.Text);
                Inventory.UpdateOSPart(int.Parse(mod_Part_ID_TextBox.Text), OSPart);
            }
            Inventory.Parts.ResetBindings();
            this.Close();
        }

        private void mod_Part_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mod_Part_Radio_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                if ((bool)mod_Part_IH_Radio.IsChecked)
                {
                    IHorOS.Text = "Machine ID";
                }
                else if ((bool)mod_Part_Out_Radio.IsChecked)
                {
                    IHorOS.Text = "Company Name";
                }
            }
        }
    }
}
