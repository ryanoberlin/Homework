using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MathsOperators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)circumference.IsChecked)
                {
                    circCalc();
                }
                else if ((bool)hemisphere.IsChecked)
                {
                    hemiVolume();
                }
                else if ((bool)triarea.IsChecked)
                {
                    triCalc();
                }
                else if ((bool)quadratic_equation.IsChecked)
                {
                    quadCompute();
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private void circCalc()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Add rhs to lhs and store the result in outcome
            outcome = lhs + rhs;
            expression.Text = $"{lhsOperand.Text} + {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void hemiVolume()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Subtract rhs from lhs and store the result in outcome
            outcome = lhs - rhs;
            expression.Text = $"{lhsOperand.Text} - {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void triCalc()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            // TODO: Multiply lhs by rhs and store the result in outcome
            outcome = lhs * rhs;
            expression.Text = $"{lhsOperand.Text} * {rhsOperand.Text}";
            result.Text = outcome.ToString();
        }

        private void quadCompute()
        {
            double a, b, c;


        }
    }
}
