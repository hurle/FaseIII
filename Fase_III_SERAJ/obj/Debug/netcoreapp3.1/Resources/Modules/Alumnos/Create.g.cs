﻿#pragma checksum "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA8F80D0A852FF2A8F3394B183228C0CFEFDF9BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Fase_III_SERAJ.Resources.Modules.Alumnos;
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


namespace Fase_III_SERAJ.Resources.Modules.Alumnos {
    
    
    /// <summary>
    /// Create
    /// </summary>
    public partial class Create : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_name;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker_dateofBird;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_idNum;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_direction;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_degree;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_program;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_cancel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_save;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Fase_III_SERAJ;component/resources/modules/alumnos/create.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textbox_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DatePicker_dateofBird = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.textbox_idNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textbox_direction = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textbox_degree = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox_program = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.button_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
            this.button_cancel.Click += new System.Windows.RoutedEventHandler(this.button_cancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_save = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\..\Resources\Modules\Alumnos\Create.xaml"
            this.button_save.Click += new System.Windows.RoutedEventHandler(this.button_save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
