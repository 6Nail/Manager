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

namespace Telephone
{
    /// <summary>
    /// Interaction logic for PageForCall.xaml
    /// </summary>
    public partial class PageForCall : Page
    {
        public MainWindow MainWindow { get; set;}
        public PageForCall(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.mainFrame.Navigate(MainWindow.Calling);
            }
        }

        private void CallInterlocutor(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(MainWindow.Calling);
        }

        private void IpOnlyDigit(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789.".IndexOf(e.Text) < 0;
        }
    }
}
