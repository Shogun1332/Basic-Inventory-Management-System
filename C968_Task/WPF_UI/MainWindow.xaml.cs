﻿using System;
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

        }
        private void products_Search_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void parts_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new Add_Part().ShowDialog();
        }

        private void parts_Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            new Modify_Part().ShowDialog();
        }

        private void parts_Delete_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void products_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new Add_Product().ShowDialog();
        }

        private void products_Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            new Modify_Product().ShowDialog();
        }

        private void products_Delete_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
