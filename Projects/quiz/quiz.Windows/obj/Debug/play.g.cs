﻿

#pragma checksum "C:\Users\Ayman\Documents\Visual Studio 2013\Projects\quiz\quiz.Windows\play.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1BB33D6A9BD412FA4EC263C6588636CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quiz
{
    partial class play : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 23 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.Grid_Loaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 27 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBlock)(target)).ContextMenuOpening += this.testq;
                 #line default
                 #line hidden
                #line 27 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).DataContextChanged += this.tesstq;
                 #line default
                 #line hidden
                #line 27 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBlock)(target)).SelectionChanged += this.testqq_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 28 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.answer1_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 29 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.answer2_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 31 "..\..\play.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.Grid_Loaded;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

