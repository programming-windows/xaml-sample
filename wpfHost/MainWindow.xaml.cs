using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowsXamlHost_AutoSuggestChanged(object sender, EventArgs e)
        {
            // Hook up x:Bind source.
            global::Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost windowsXamlHost =
                sender as global::Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost;
            global::uwpLib.AutoSuggestEditBox userControl =
                windowsXamlHost.GetUwpInternalObject() as global::uwpLib.AutoSuggestEditBox;

            if (userControl != null)
            {
                userControl.XamlIslandMessage = this.WPFMessage;
            }
        }

        public string WPFMessage
        {
            get
            {
                return "Binding from WPF to UWP XAML";
            }
        }
    }
}
