﻿#pragma checksum "..\..\CreaPersonaggio.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13B7B4F57E3807A2AC41CC0DC08965C6207B7B4611DF7C4A5103BD2513C971AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Esercizio_Videogioco;
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


namespace Esercizio_Videogioco {
    
    
    /// <summary>
    /// CreaPersonaggio
    /// </summary>
    public partial class CreaPersonaggio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_Tipo_Personaggio;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstAltriPersonaggi;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Img_Personaggio;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRazza;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNome;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CreaPersonaggio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPersonaggi;
        
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
            System.Uri resourceLocater = new System.Uri("/Esercizio_Videogioco;component/creapersonaggio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreaPersonaggio.xaml"
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
            this.Combo_Tipo_Personaggio = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\CreaPersonaggio.xaml"
            this.Combo_Tipo_Personaggio.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Combo_Tipo_Personaggio_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 20 "..\..\CreaPersonaggio.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstAltriPersonaggi = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CreaPersonaggio.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Img_Personaggio = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.lblRazza = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblNome = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblPersonaggi = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

