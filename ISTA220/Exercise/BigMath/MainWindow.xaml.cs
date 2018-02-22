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

namespace BigMath
{
    //Autism
    //check for checkboxes
    //heron is named after hero look it up
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void circlearea(object sender, RoutedEventArgs e)
        {
            Circle.IsChecked = true;
        }

        private void hemivol(object sender, RoutedEventArgs e)
        {
            hemisphere.IsChecked = true;
        }

        private void heron(object sender, RoutedEventArgs e)
        {
            triangle.IsChecked = true;
        }
        private void quad(object sender, RoutedEventArgs e)
        {
            quadratic.IsChecked = true;
        }

        private void next(object sender, RoutedEventArgs e)
        {
            if ((bool)Circle.IsChecked)
            {
                Window1 win1 = new Window1();
                win1.Show();
                this.Close();
            }
            else if ((bool)hemisphere.IsChecked)
            {
                Window2 win2 = new Window2();
                win2.Show();
                this.Close();
            }
            else if ((bool)triangle.IsChecked)
            {
                Window3 win3 = new Window3();
                win3.Show();
                this.Close();
            }
            else if ((bool)quadratic.IsChecked)
            {
                Window4 win4 = new Window4();
                win4.Show();
                this.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
