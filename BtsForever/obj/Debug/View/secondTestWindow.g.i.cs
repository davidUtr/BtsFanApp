﻿#pragma checksum "..\..\..\View\secondTestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ACD926B5606B2F3FD24420F310D334D6F47BEDCA6143873396217CDB907EC051"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BtsForever.View;
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


namespace BtsForever.View {
    
    
    /// <summary>
    /// secondTestWindow
    /// </summary>
    public partial class secondTestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image questionImg;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton answer1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton answer2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton answer3;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton answer4;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image returnMaiNWindow;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image closeImage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\secondTestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle MinimizedRec;
        
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
            System.Uri resourceLocater = new System.Uri("/BtsForever;component/view/secondtestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\secondTestWindow.xaml"
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
            
            #line 10 "..\..\..\View\secondTestWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.questionImg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.answer1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.answer2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.answer3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\secondTestWindow.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.answer4 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.returnMaiNWindow = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\..\View\secondTestWindow.xaml"
            this.returnMaiNWindow.MouseEnter += new System.Windows.Input.MouseEventHandler(this.returnMaiNWindow_MouseEnter);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\View\secondTestWindow.xaml"
            this.returnMaiNWindow.MouseLeave += new System.Windows.Input.MouseEventHandler(this.returnMaiNWindow_MouseLeave);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\View\secondTestWindow.xaml"
            this.returnMaiNWindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.returnMaiNWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.closeImage = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\..\View\secondTestWindow.xaml"
            this.closeImage.MouseEnter += new System.Windows.Input.MouseEventHandler(this.closeImage_MouseEnter);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\View\secondTestWindow.xaml"
            this.closeImage.MouseLeave += new System.Windows.Input.MouseEventHandler(this.closeImage_MouseLeave);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\View\secondTestWindow.xaml"
            this.closeImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.closeImage_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MinimizedRec = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 20 "..\..\..\View\secondTestWindow.xaml"
            this.MinimizedRec.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MinimizedRec_MouseEnter);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\View\secondTestWindow.xaml"
            this.MinimizedRec.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MinimizedRec_MouseLeave);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\View\secondTestWindow.xaml"
            this.MinimizedRec.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizedRec_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

