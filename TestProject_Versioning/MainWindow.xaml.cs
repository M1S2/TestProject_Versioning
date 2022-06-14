using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using MahApps.Metro.Controls;

namespace TestProject_Versioning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txt_version.Text = AssemblyInfoHelper.AssemblyInfoHelperClass.AssemblyVersion;

            object[] assemblyObjects = Assembly.GetEntryAssembly()?.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), true);
            if (assemblyObjects.Length > 0)
            {
                txt_infoversion.Text = ((AssemblyInformationalVersionAttribute)assemblyObjects[0]).InformationalVersion;
            }
        }
    }
}
