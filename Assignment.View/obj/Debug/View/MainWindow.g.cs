// Updated by XamlIntelliSenseFileGenerator 1/9/2023 6:45:01 PM
#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C33C95BAF83AF1766E9A1C268F3DD29D2E0A5605C652B26F9E2E7CB8FCAFFA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assignment.View;
using Assignment.View.ViewModel;
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


namespace Assignment.View
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment.View;component/view/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock textBlockHeading;
        internal System.Windows.Controls.TextBlock errormessage;
        internal System.Windows.Controls.TextBlock textBlockUsername;
        internal System.Windows.Controls.TextBlock textBlockLastname;
        internal System.Windows.Controls.TextBlock textBlockGender;
        internal System.Windows.Controls.TextBlock textBlockDob;
        internal System.Windows.Controls.TextBlock textBlockEmail;
        internal System.Windows.Controls.TextBlock textBlockPassword;
        internal System.Windows.Controls.TextBlock textBlockConformpass;
        internal System.Windows.Controls.TextBox textBoxUsername;
        internal System.Windows.Controls.TextBox textBoxLastname;
        internal System.Windows.Controls.ComboBox textcomboBoxGender;
        internal System.Windows.Controls.Calendar textBoxDob;
        internal System.Windows.Controls.TextBox textBoxEmail;
        internal System.Windows.Controls.PasswordBox textBoxPassword;
        internal System.Windows.Controls.PasswordBox textBoxConformpass;
        internal System.Windows.Controls.Button Submit;
        internal System.Windows.Controls.Button button2;
        internal System.Windows.Controls.Button button3;
    }
}

