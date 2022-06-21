﻿#pragma checksum "..\..\..\ConverterWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35C95CFD176E45D0DE5A1F723F030E3068073A77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LeviEpcUpcConverter.UIComponents;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LeviEpcUpcConverter {
    
    
    /// <summary>
    /// ConverterWindow
    /// </summary>
    public partial class ConverterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SummaryGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SummmaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseSummaryButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid EpcGrid;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LeviEpcUpcConverter.UIComponents.FileBrowser EpcBrowser;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMoreButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CheckDigit;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\ConverterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LeviEpcUpcConverter;V1.0.0.0;component/converterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConverterWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SummaryGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SummmaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BrowseSummaryButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\ConverterWindow.xaml"
            this.BrowseSummaryButton.Click += new System.Windows.RoutedEventHandler(this.BrowseSummaryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EpcGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.EpcBrowser = ((LeviEpcUpcConverter.UIComponents.FileBrowser)(target));
            return;
            case 6:
            this.AddMoreButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\ConverterWindow.xaml"
            this.AddMoreButton.Click += new System.Windows.RoutedEventHandler(this.AddMoreButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CheckDigit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.ConvertButton = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\ConverterWindow.xaml"
            this.ConvertButton.Click += new System.Windows.RoutedEventHandler(this.ConvertButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
