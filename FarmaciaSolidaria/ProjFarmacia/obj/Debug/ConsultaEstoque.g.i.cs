﻿#pragma checksum "..\..\ConsultaEstoque.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1278168B70C811B42853B186D4145828031A15DE2848A70CBA7209E1D4BBCB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace ProjFarmacia {
    
    
    /// <summary>
    /// ConsultaEstoque
    /// </summary>
    public partial class ConsultaEstoque : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid btnSair;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRemedio;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miDoador;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miInstituicao;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miConsultar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgTudo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPesquisar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPesquisar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ConsultaEstoque.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSair1;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjFarmacia;component/consultaestoque.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConsultaEstoque.xaml"
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
            this.btnSair = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.miRemedio = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\ConsultaEstoque.xaml"
            this.miRemedio.Click += new System.Windows.RoutedEventHandler(this.miRemedio_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.miDoador = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\ConsultaEstoque.xaml"
            this.miDoador.Click += new System.Windows.RoutedEventHandler(this.miDoador_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.miInstituicao = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\ConsultaEstoque.xaml"
            this.miInstituicao.Click += new System.Windows.RoutedEventHandler(this.miInstituicao_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.miConsultar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\ConsultaEstoque.xaml"
            this.miConsultar.Click += new System.Windows.RoutedEventHandler(this.miConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 20 "..\..\ConsultaEstoque.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dtgTudo = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.txtPesquisar = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\ConsultaEstoque.xaml"
            this.txtPesquisar.GotFocus += new System.Windows.RoutedEventHandler(this.txtPesquisar_GotFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.btnPesquisar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ConsultaEstoque.xaml"
            this.btnPesquisar.Click += new System.Windows.RoutedEventHandler(this.btnPesquisar_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnSair1 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ConsultaEstoque.xaml"
            this.btnSair1.Click += new System.Windows.RoutedEventHandler(this.btnSair_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
