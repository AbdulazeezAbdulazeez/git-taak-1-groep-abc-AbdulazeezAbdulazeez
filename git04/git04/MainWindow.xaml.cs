using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace git04
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

        private void roodPNG_MouseEnter(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.Red;
        }

        private void geelPng_MouseEnter(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.Yellow;
        }

        private void groenPNG_MouseEnter(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.Green;
        }

        private void blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.Blue;
        }

        private void roodPNG_MouseLeave(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.LightGray;

        }

        private void geelPng_MouseLeave(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.LightGray;

        }

        private void groenPNG_MouseLeave(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.LightGray;

        }

        private void blauw_MouseLeave(object sender, MouseEventArgs e)
        {
            Mainwindow.Background = Brushes.LightGray;

        }

        private void roodPNG_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = ("#FF0000");

        }

        private void geelPng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = ("#FFFF00");

        }

        private void groenPNG_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = ("#008000");

        }

        private void blauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = ("#0000FF");

        }
    }

    

}





      
