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

namespace Lab3_zad_1_w62952
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double wynik;
        double liczba1;
        double liczba2;
        string dzialanie;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(textBox1.Text);
            liczba2 = Convert.ToDouble(textBox2.Text);
            wynik = liczba1 + liczba2;
            dzialanie = "Suma";
            textBox3.Text = (Convert.ToString(dzialanie + textBox1.Text + "+" + textBox2.Text + "=" + wynik));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(textBox1.Text);
            liczba2 = Convert.ToDouble(textBox2.Text);
            wynik = liczba1 - liczba2;
            dzialanie = "Różnica";
            textBox3.Text = (Convert.ToString(dzialanie + textBox1.Text + "-" + textBox2.Text + "=" + wynik));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(textBox1.Text);
            liczba2 = Convert.ToDouble(textBox2.Text);
            wynik = liczba1 * liczba2;
            dzialanie = "Iloczyn";
            textBox3.Text = (Convert.ToString(dzialanie+"" + textBox1.Text + "*" + textBox2.Text + "=" + wynik));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = Convert.ToDouble(textBox1.Text);
            liczba2 = Convert.ToDouble(textBox2.Text);
            if (liczba2 == 0)
            {
                textBox3.Text = "Nie możesz dzielić przez 0 !";
                MessageBox.Show("Nie można dzielić przez 0!", "Uwaga");
            }
            else
            {
                wynik = liczba1 / liczba2;
                dzialanie = "Iloraz";
                textBox3.Text = (Convert.ToString(dzialanie + textBox1.Text + "/" + textBox2.Text + "=" + wynik));
            }
        }
    }
}
