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
    public partial class Add_Part : Window
    {
        public Add_Part()
        {
            InitializeComponent();

            if ((bool)add_Part_IH_Radio.IsChecked)
            {
                IHorOS.Text = "Machine ID";
            }
            else
            {
                IHorOS.Text = "Company Name";
            }
        }


        private void add_Part_Save_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void add_Part_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            //Inventory.RemovePart(0);
            this.Close();
        }
    }
}
