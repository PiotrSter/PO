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

namespace Cw10
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double l1, l2, z;
        string li1, li2, wy;
        List<string> znaki = new List<string>() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0" }; 

        private void Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            double w;
            Konwertuj();
            w = l1 / l2;
            wy = w.ToString();
            wynik.Text = wy;
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            double w;
            Konwertuj();
            w = l1 * l2;
            wy = w.ToString();
            wynik.Text = wy;
        }

        private void Wynik_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            double w;
            Konwertuj();
            w = l1 - l2;
            wy = w.ToString();
            wynik.Text = wy;
        }

        private void Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            double w;
            w = l1 + l2;
            wy = w.ToString();
            wynik.Text = wy;
        }

        public void Konwertuj()
        {
            li1 = liczba1.Text;
            l1 = double.Parse(li1);
            li2 = liczba2.Text;
            l2 = double.Parse(li2);
        }


    }
}
