// Updated by XamlIntelliSenseFileGenerator 6/1/2021 9:55:22 PM
#pragma checksum "..\..\Add Product.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E89D71B320392A43074EC50919E3F5A00958704FF4D9452833CD5D8FFB1AFD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF_UI;


namespace WPF_UI
{


    /// <summary>
    /// Add_Product
    /// </summary>
    public partial class Add_Product : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_UI;component/add%20product.xaml", System.UriKind.Relative);

#line 1 "..\..\Add Product.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox add_Prod_ID_TextBox;
        internal System.Windows.Controls.TextBox add_Prod_Name_TextBox;
        internal System.Windows.Controls.TextBox add_Prod_Inventory_TextBox;
        internal System.Windows.Controls.TextBox add_Prod_Price_TextBox;
        internal System.Windows.Controls.TextBox add_Prod_Max_TextBox;
        internal System.Windows.Controls.TextBox add_Prod_Min_TextBox;
        internal System.Windows.Controls.DataGrid all_Parts_DataGrid;
        internal System.Windows.Controls.DataGridTextColumn all_Part_ID;
        internal System.Windows.Controls.DataGridTextColumn all_Part_Name;
        internal System.Windows.Controls.DataGridTextColumn all_Part_Inventory;
        internal System.Windows.Controls.DataGridTextColumn all_Part_Price;
        internal System.Windows.Controls.DataGridTextColumn all_Part_Price_Min;
        internal System.Windows.Controls.DataGridTextColumn all_Part_Price_Max;
        internal System.Windows.Controls.DataGrid product_DataGrid;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_ID;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_Name;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_Inventory;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_Price;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_Price_Min;
        internal System.Windows.Controls.DataGridTextColumn prod_Part_Price_Max;
        internal System.Windows.Controls.Button parts_Add_Button;
        internal System.Windows.Controls.Button add_Prod_Search_Button;
        internal System.Windows.Controls.TextBox add_Prod_Search_TextBox;
        internal System.Windows.Controls.Button product_Remove_Button;
        internal System.Windows.Controls.Button product_Save_Button;
        internal System.Windows.Controls.Button product_Cancel_Button;
    }
}

