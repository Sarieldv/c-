﻿#pragma checksum "..\..\NumberUpDown.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "165A87A1D7078CE9F8743463A7A84EF1"
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
    /// NumberUpDown
    /// </summary>
    public partial class NumberUpDown : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\NumberUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdDown;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\NumberUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNum;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NumberUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdUp;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_UI;component/numberupdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NumberUpDown.xaml"
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
            this.cmdDown = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\NumberUpDown.xaml"
            this.cmdDown.Click += new System.Windows.RoutedEventHandler(this.cmdDown_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNum = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\NumberUpDown.xaml"
            this.txtNum.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNum_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmdUp = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\NumberUpDown.xaml"
            this.cmdUp.Click += new System.Windows.RoutedEventHandler(this.cmdUp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

