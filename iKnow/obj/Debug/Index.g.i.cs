﻿#pragma checksum "C:\Users\Balaji\Documents\Visual Studio 2010\Projects\iKnow\iKnow\Index.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8D6CB8676800AB0580F9B11B362408A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace iKnow {
    
    
    public partial class Index : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock requestTextBlock;
        
        internal System.Windows.Controls.TextBox requestTextBox;
        
        internal System.Windows.Controls.TextBlock questionTextBlock;
        
        internal System.Windows.Controls.Button clearButton;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.TextBox questionTextBox;
        
        internal System.Windows.Controls.Button okButton;
        
        internal System.Windows.Controls.TextBlock answerTexBlock;
        
        internal System.Windows.Controls.ProgressBar MyProgress;
        
        internal System.Windows.Controls.Button tryAgainButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/iKnow;component/Index.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.requestTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("requestTextBlock")));
            this.requestTextBox = ((System.Windows.Controls.TextBox)(this.FindName("requestTextBox")));
            this.questionTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("questionTextBlock")));
            this.clearButton = ((System.Windows.Controls.Button)(this.FindName("clearButton")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.questionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("questionTextBox")));
            this.okButton = ((System.Windows.Controls.Button)(this.FindName("okButton")));
            this.answerTexBlock = ((System.Windows.Controls.TextBlock)(this.FindName("answerTexBlock")));
            this.MyProgress = ((System.Windows.Controls.ProgressBar)(this.FindName("MyProgress")));
            this.tryAgainButton = ((System.Windows.Controls.Button)(this.FindName("tryAgainButton")));
        }
    }
}
