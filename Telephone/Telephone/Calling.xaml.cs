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
    /// Interaction logic for Calling.xaml
    /// </summary>
    public partial class Calling : Page
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow MainWindow { get; set;}
        public Calling(MainWindow mainWindow)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 5, 0);
            dispatcherTimer.Start();
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // code goes here
        }

        private void CancelCall(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(MainWindow.PageForCall);
        }
    }
}
