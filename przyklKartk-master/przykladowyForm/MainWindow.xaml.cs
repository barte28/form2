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
            int liczba1;
            int liczba2;
            long wynik;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int liczba1;
            int liczba2;
            int wynik;
            

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int liczba1;
            int liczba2;
            int wynik;
        }
    }
}
