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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadFormData();

        }

        public void LoadFormData()
        {
            Inventory.GenerateStartingData();

            parts_DataGrid.ItemsSource = Inventory.Parts;
            products_DataGrid.ItemsSource = Inventory.Products;
            
        }

        private void parts_Search_Button_Click(object sender, RoutedEventArgs e)
        {
            if (parts_Search_TextBox.Text.Count() > 0)
            {
                var filtered = Inventory.Parts.Where<Part>(part => part.PartID.ToString().Equals(parts_Search_TextBox.Text));
                parts_DataGrid.ItemsSource = filtered;
            }
            else
            {
                parts_DataGrid.ItemsSource = Inventory.Parts;
            }
        }
        private void products_Search_Button_Click(object sender, RoutedEventArgs e)
        {
            if (products_Search_TextBox.Text.Count() > 0)
            {
                var filtered = Inventory.Products.Where<Product>(product => product.ProductID.ToString().Equals(products_Search_TextBox.Text));
                products_DataGrid.ItemsSource = filtered;
            }
            else
            {
                products_DataGrid.ItemsSource = Inventory.Products;
            }
        }

        private void parts_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new Add_Part().ShowDialog();
        }

        private void parts_Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            if (parts_DataGrid.SelectedItem.GetType() == typeof(InHousePart))
            {
                InHousePart IHPart = (InHousePart)parts_DataGrid.SelectedItem;
                new Modify_Part(IHPart).ShowDialog();
            }
            else
            {
                OutsourcedPart OSPart = (OutsourcedPart)parts_DataGrid.SelectedItem;
                new Modify_Part(OSPart).ShowDialog();
            }
            
        }

        private void parts_Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            Part delPart = (Part)parts_DataGrid.SelectedItem;
            int delPartID = delPart.PartID;
            string confirmDelete = "Are you sure you want to delete this part?";
            string delCaption = "Deletion Warning";
            var delResult = MessageBox.Show(confirmDelete, delCaption, MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (delResult == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                Inventory.RemovePart(delPartID);
            }
        }

        private void products_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new Add_Product().ShowDialog();
        }

        private void products_Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = (Product)products_DataGrid.SelectedItem;
            new Modify_Product(product).ShowDialog();
        }

        private void products_Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            Product delProd = (Product)products_DataGrid.SelectedItem;
            int delProdID = delProd.ProductID;
            string confirmDelete = "Are you sure you want to delete this product?";
            string delCaption = "Deletion Warning";
            var delResult = MessageBox.Show(confirmDelete, delCaption, MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (delResult == MessageBoxResult.No)
            {
                return;
            }
            if (delProd.IncludedParts.Count > 0)
            {
                MessageBox.Show("Unable to delete product while there are parts associated with it. Please remove the included parts and try again.", "Removal Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Inventory.RemoveProduct(delProdID);
            }
        }

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
