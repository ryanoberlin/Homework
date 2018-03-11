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
using System.Windows.Shapes;

namespace BigMath
{
    // Add checks for non intergers & random shit
    // TODO: declare PI a static public variable against Math.PI in MainWindow (is it worth it?)
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void circlearea()
        {
            double r = double.Parse(radius.Text);
            circresultarea.Text = (Math.PI * (r * r)).ToString();
        }

        private void circlecircumference()
        {
            double r = double.Parse(radius.Text);
            circumference.Text = ((2 * Math.PI) * r).ToString();
        }

        private void doCirc(object sender, RoutedEventArgs e)
        {
            try
            {
                circlearea();
                circlecircumference();
            }
            catch(FormatException)
            {
                MessageBox.Show("Input only Integers.");
            }
        }

        private void quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

