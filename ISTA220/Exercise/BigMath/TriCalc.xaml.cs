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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void heronsformula(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(sidea.Text);
                double b = double.Parse(sideb.Text);
                double c = double.Parse(sidec.Text);
                double allsides = (a + b + c) / 2;
                double area = Math.Sqrt(allsides * (allsides - a) * (allsides - b) * (allsides - c));

                answer.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Input only Integers.");
            }
        }
    }
}
