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
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       
         private void solvequadratic(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(abox.Text);
                double b = double.Parse(bbox.Text);
                double c = double.Parse(cbox.Text);

                double squareroot = b * b - 4 * a * c;
                double x, x1, x2;

                if (squareroot > 0)
                {
                    x1 = (-b + Math.Sqrt(squareroot)) / (2 * a);
                    x2 = (-b - Math.Sqrt(squareroot)) / (2 * a);
                    MessageBox.Show("Two Solutions!");
                    answer1.Text = x1.ToString();
                    answer2.Text = x2.ToString();
                }
                else if (squareroot < 0)
                {
                    MessageBox.Show("Imiginary Solution");
                }
                else
                {
                    x = (-b + Math.Sqrt(squareroot)) / (2 * a);
                    answer1.Text = x.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Only input integers!");
            }
        }
    }

}
