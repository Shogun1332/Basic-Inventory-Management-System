#pragma checksum "..\..\Modify Part.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F1462BC8B4B15C60831A9896C4E35E2E21BB942FAB4ECCF5532B9CF623A284FA"
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


namespace WPF_UI {
    
    
    /// <summary>
    /// Modify_Part
    /// </summary>
    public partial class Modify_Part : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mod_Part_IH_Radio;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mod_Part_Out_Radio;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IHorOS;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Part_ID_TextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Name_TextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Inventory_TextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Price_TextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Min_TextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_Max_TextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mod_CompanyName_TextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mod_Part_Save_Button;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Modify Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mod_Part_Cancel_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_UI;component/modify%20part.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Modify Part.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mod_Part_IH_Radio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\Modify Part.xaml"
            this.mod_Part_IH_Radio.Checked += new System.Windows.RoutedEventHandler(this.mod_Part_Radio_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mod_Part_Out_Radio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\Modify Part.xaml"
            this.mod_Part_Out_Radio.Checked += new System.Windows.RoutedEventHandler(this.mod_Part_Radio_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IHorOS = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.mod_Part_ID_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.mod_Name_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.mod_Inventory_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mod_Price_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.mod_Min_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.mod_Max_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.mod_CompanyName_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.mod_Part_Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Modify Part.xaml"
            this.mod_Part_Save_Button.Click += new System.Windows.RoutedEventHandler(this.mod_Part_Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.mod_Part_Cancel_Button = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Modify Part.xaml"
            this.mod_Part_Cancel_Button.Click += new System.Windows.RoutedEventHandler(this.mod_Part_Cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

