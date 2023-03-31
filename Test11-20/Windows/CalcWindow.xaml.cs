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

namespace Test11_20.Windows
{
    /// <summary>
    /// Логика взаимодействия для CalcWindow.xaml
    /// </summary>
    public partial class CalcWindow : Window
    {
        public CalcWindow()
        {
            InitializeComponent();
        }

        private void Plus(object sender, RoutedEventArgs e)
        {
            if (TbComponent.Text != string.Empty)
            {
                TbResult.Text = Sum(Convert.ToDouble(TbResult.Text), Convert.ToDouble(TbComponent.Text));
                TbComponent.Text = "";
            }
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            if (TbComponent.Text != string.Empty)
            {
                TbResult.Text = Minus(Convert.ToDouble(TbResult.Text), Convert.ToDouble(TbComponent.Text));
                TbComponent.Text = "";
            }
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (TbComponent.Text != string.Empty)
            {
                TbResult.Text = Multiply(Convert.ToDouble(TbResult.Text), Convert.ToDouble(TbComponent.Text));
                TbComponent.Text = "";
            }
         } 

        private void Substract(object sender, RoutedEventArgs e)
        {
            if (TbComponent.Text != string.Empty)
            {
                TbResult.Text = Substract(Convert.ToDouble(TbResult.Text), Convert.ToDouble(TbComponent.Text));
                TbComponent.Text = "";
            }
        }

        private void Square(object sender, RoutedEventArgs e)
        {
            if (TbComponent.Text != string.Empty)
            {
                TbResult.Text = Square(Convert.ToDouble(TbComponent.Text));
                TbComponent.Text = "";
            }
            else
            {
                TbResult.Text = Square(Convert.ToDouble(TbResult.Text));
                TbComponent.Text = "";
            }
                
        }

        private void ToNull(object sender, RoutedEventArgs e)
        {
            TbResult.Text = "0";
        }

        public static string Sum(double first, double second) 
        {
            return Convert.ToString(first + second);
        }

        public static string Minus(double first, double second)
        {
            return Convert.ToString(first - second);
        }

        public static string Multiply(double first, double second)
        {
            return Convert.ToString(first * second);
        }

        public static string Substract(double first, double second)
        {
            return Convert.ToString(first / second);
        }

        public static string Square(double first)
        {
            return Convert.ToString((float)Math.Sqrt(first));
        }
    }
}
