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

namespace przykladowyForm
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int obwod;
            int bok;
            if(int.TryParse(bok_textbox.Text, out bok))
            {
                MessageBox.Show(bok.ToString());
                string figura = figura_ComboBox.Text;
                if(figura == "Kwadrat")
                {
                    obwod = bok * 4;
                    MessageBox.Show("Obwód kwadratu wynosi " + obwod.ToString());
                }
                else if(figura == "Trójkąt prostokątny")
                {
                    obwod = bok * 3;
                    MessageBox.Show("Obwód trójkąta prostokątnego wynosi " + obwod.ToString());
                }
                else if(figura == "Pięciokąt")
                {
                    obwod = bok * 5;
                    MessageBox.Show("Obwód pięciokąta wynosi " + bok.ToString());
                }
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float wynik = 0;
            int waluta = 0;

            if(int.TryParse(waluta_textbox.Text, out waluta))
            {
                if(euro_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.26);
                }
                else if(dolar_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.24);
                }
                else if(frank_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.22);
                }
                MessageBox.Show("Dostaniesz około " + wynik.ToString());
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int liczba = 0;
            if(int.TryParse(liczba1_textbox.Text, out liczba))
            {
                if (liczba < 0)
                {
                    MessageBox.Show("Musi być liczba dodatnia");
                }
                else
                {
                    long wartoscsilni = 1;
                    for(int i = 1; i <= liczba; i++)
                    {
                        wartoscsilni = wartoscsilni * i;
                    }
                    MessageBox.Show(wartoscsilni.ToString(),"Silnia");
                }
            }
            else
            {
                MessageBox.Show("oczekuję liczby w pierwszym polu edycyjnym");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int liczba1 = 0;
            int liczba2 = 0;
            if(int.TryParse(liczba1_textbox.Text, out liczba1) && int.TryParse(liczba2_textbox.Text, out liczba2))
            {
                MessageBox.Show(nwd2(liczba1, liczba2).ToString(), "nwd");
            }
            else
            {
                MessageBox.Show("To muszą być liczby całkowite");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
;           int n;
            int k;
            if(int.TryParse(liczba1_textbox.Text,out n) && int.TryParse(liczba2_textbox.Text,out k))
            {
                int potega = 1;
                //k razy mnoże przez n
                for(int i = 1; i <= k; i++)
                {
                    potega = potega * n;
                }
                MessageBox.Show(potega.ToString(), "Potęga n do k");
            }
            else
            {
                MessageBox.Show("To muszą być liczby całkowite");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            if(int.TryParse(liczba1_textbox.Text,out a) && int.TryParse(liczba2_textbox.Text,out b))
            {
                int suma = 0;
                for(int i = a; i<=b;i++)
                {
                    suma = suma + i;
                }
                MessageBox.Show(suma.ToString());
            }
            else
            {
                MessageBox.Show("To muszą być liczby całkowite");
            }
        }

        private int nwd1(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        private int nwd2(int a, int b)
        {
            while (b != 0)
            {
                int reszta = a % b;
                a = b;
                b = reszta;
            }
            return a;
        }
    }
}
