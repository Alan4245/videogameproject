﻿#pragma checksum "..\..\AggiungiElementi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82BFE7CDEFF99D730D891B801561E94495416F9F79FC43D362584EB76843C3CA"
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
    /// AggiungiElementi
    /// </summary>
    public partial class AggiungiElementi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputCategoriaID;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputCategoriaNOME;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoria;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputRazzaID;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputRazzaNOME;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRazza;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputArmaDESCRIZIONE;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputArmaNOME;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AggiungiElementi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPanic;
        
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
            System.Uri resourceLocater = new System.Uri("/Esercizio_Videogioco;component/aggiungielementi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AggiungiElementi.xaml"
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
            this.inputCategoriaID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.inputCategoriaNOME = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnCategoria = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AggiungiElementi.xaml"
            this.btnCategoria.Click += new System.Windows.RoutedEventHandler(this.btnCategoria_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inputRazzaID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.inputRazzaNOME = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnRazza = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AggiungiElementi.xaml"
            this.btnRazza.Click += new System.Windows.RoutedEventHandler(this.btnRazza_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.inputArmaDESCRIZIONE = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.inputArmaNOME = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnPanic = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AggiungiElementi.xaml"
            this.btnPanic.Click += new System.Windows.RoutedEventHandler(this.btnPanic_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

