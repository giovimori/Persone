using morelli.giovanni._4h.persone.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace morelli.giovanni._4h.persone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
            ATA a = new ATA ();
            Console.WriteLine(a);
        }

        private void dgDati_LoadingRow (object sender, RoutedEventArgs e)
        {

        }
        private void btnApriFile(object sender, RoutedEventArgs e)
        {

        }


    }
}
