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
using System.Data;

namespace calculator_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void Calculate ()
        {
            DataTable dt = new DataTable();
            try
            {
                result.Text = Convert.ToString(dt.Compute(result.Text, "")).Replace(",", ".");
            }
            catch { }
        }

        private void ValidInput (object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789./*-+()".IndexOf(e.Text) < 0;
        }

        private void EnterPressed (object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.Enter))
            {
                Calculate();
                result.SelectionStart = result.Text.Length;
            }
        }

        private void Button_Click_Clear (object sender, RoutedEventArgs e)
        {
            result.Text = "";
        }

        private void Button_Click_1 (object sender, RoutedEventArgs e)
        {
            result.Text += "1";
        }

        private void Button_Click_2 (object sender, RoutedEventArgs e)
        {
            result.Text += "2";
        }

        private void Button_Click_3 (object sender, RoutedEventArgs e)
        {
            result.Text += "3";
        }

        private void Button_Click_4 (object sender, RoutedEventArgs e)
        {
            result.Text += "4";
        }

        private void Button_Click_5 (object sender, RoutedEventArgs e)
        {
            result.Text += "5";
        }

        private void Button_Click_6 (object sender, RoutedEventArgs e)
        {
            result.Text += "6";
        }

        private void Button_Click_7 (object sender, RoutedEventArgs e)
        {
            result.Text += "7";
        }

        private void Button_Click_8 (object sender, RoutedEventArgs e)
        {
            result.Text += "8";
        }

        private void Button_Click_9 (object sender, RoutedEventArgs e)
        {
            result.Text += "9";
        }

        private void Button_Click_0 (object sender, RoutedEventArgs e)
        {
            result.Text += "0";
        }

        private void Button_Click_Point (object sender, RoutedEventArgs e)
        {
            result.Text += ".";
        }

        private void Button_Click_Division (object sender, RoutedEventArgs e)
        {
            result.Text += "/";
        }

        private void Button_Click_Multiplication (object sender, RoutedEventArgs e)
        {
            result.Text += "*";
        }

        private void Button_Click_Minus (object sender, RoutedEventArgs e)
        {
            result.Text += "-";
        }

        private void Button_Click_Plus (object sender, RoutedEventArgs e)
        {
            result.Text += "+";
        }

        private void Button_Click_Calculate (object sender, RoutedEventArgs e)
        {
            Calculate();
        }
    }
}
