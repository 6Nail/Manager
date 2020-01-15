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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PageForCall PageForCall { get; set;}
        public Calling Calling { get; set;}
        public MainWindow()
        {
            PageForCall = new PageForCall(this);
            Calling = new Calling(this);
            InitializeComponent();
            mainFrame.Navigate(PageForCall);
        }
    }
}
