﻿#pragma checksum "..\..\Order.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E7FDBB84A2CF230D70DD19BF26D21CFA651C303A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// Order
    /// </summary>
    public partial class Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid guests;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox north;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox south;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox jerusalem;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox center;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid orders;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Order.xaml"
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
            this.num = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\Order.xaml"
            this.num.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.guests = ((System.Windows.Controls.DataGrid)(target));
            
            #line 41 "..\..\Order.xaml"
            this.guests.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.guests_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.north = ((System.Windows.Controls.CheckBox)(target));
            
            #line 57 "..\..\Order.xaml"
            this.north.Click += new System.Windows.RoutedEventHandler(this.north_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.south = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\Order.xaml"
            this.south.Click += new System.Windows.RoutedEventHandler(this.south_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.jerusalem = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\Order.xaml"
            this.jerusalem.Click += new System.Windows.RoutedEventHandler(this.jerusalem_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.center = ((System.Windows.Controls.CheckBox)(target));
            
            #line 60 "..\..\Order.xaml"
            this.center.Click += new System.Windows.RoutedEventHandler(this.center_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.orders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\Order.xaml"
            this.orders.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.orders_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 87 "..\..\Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
