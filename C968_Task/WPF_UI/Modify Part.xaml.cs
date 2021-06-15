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
        public Modify_Part()
        {
            InitializeComponent();
        }

        private void mod_Part_Save_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mod_Part_Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
