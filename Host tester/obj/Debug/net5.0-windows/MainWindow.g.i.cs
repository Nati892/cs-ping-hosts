﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E8A8E80A4517DD6FE76130B3A2D26AECC3631C7"
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
using System.Windows.Controls.Ribbon;
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


namespace Host_tester {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainDataGrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimerTB;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStopPing;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStartPing;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNewHostName;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNewHostIp;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddNewHost;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveToXml;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Host tester;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TimerTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.TimerTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimerTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnStopPing = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\MainWindow.xaml"
            this.BtnStopPing.Click += new System.Windows.RoutedEventHandler(this.BtnStopPing_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnStartPing = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.BtnStartPing.Click += new System.Windows.RoutedEventHandler(this.BtnStartPing_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBNewHostName = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.TBNewHostName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimerTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBNewHostIp = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\..\MainWindow.xaml"
            this.TBNewHostIp.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimerTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAddNewHost = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\MainWindow.xaml"
            this.BtnAddNewHost.Click += new System.Windows.RoutedEventHandler(this.BtnAddNewHost_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnSaveToXml = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\MainWindow.xaml"
            this.BtnSaveToXml.Click += new System.Windows.RoutedEventHandler(this.BtnSaveToXml_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

