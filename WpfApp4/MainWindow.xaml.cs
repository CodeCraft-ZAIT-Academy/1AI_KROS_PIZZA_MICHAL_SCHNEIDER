using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal cena = 4;
        public MainWindow()
        {
            InitializeComponent();
        }
            decimal Sunka = 2;
            decimal Huby = 3;
            decimal Syr = 2;
            decimal kukurica = 2;
            decimal olivy = 2;
          int pocetsurovin = 0;
        int velkost = 30;
        decimal zlava = 0;
         
        

        private void syr_btn_Click(object sender, RoutedEventArgs e)
        {
            cena = cena + Syr;
            okno_txt.Text += "Syr: " + Syr + "€" + Environment.NewLine;
            pocetsurovin = pocetsurovin + 1;
        }

        private void sunka_btn_Click(object sender, RoutedEventArgs e)
        {
            cena = cena + Sunka;
            okno_txt.Text += "Sunka: " + Sunka + "€" + Environment.NewLine;
            pocetsurovin = pocetsurovin + 1;

        }

        private void huby_btn_Click(object sender, RoutedEventArgs e)
        {
            cena = cena + Huby;
            okno_txt.Text += "Huby: " + Huby + "€" + Environment.NewLine;
            pocetsurovin = pocetsurovin + 1;
        }

        private void olivy_btn_Click(object sender, RoutedEventArgs e)
        {
            cena = cena + olivy;
            okno_txt.Text += "Olivy: " + olivy + "€" + Environment.NewLine;
            pocetsurovin = pocetsurovin + 1;
        }

        private void kukurica_btn_Click(object sender, RoutedEventArgs e)
        {
            cena = cena + kukurica;
            okno_txt.Text += "Kukurica: " + kukurica + "€" + Environment.NewLine;
            pocetsurovin = pocetsurovin + 1;
        }

        private void velkost_btn_Click(object sender, RoutedEventArgs e)
        {

            if (velkost == 30)
            {
                velkost = 40;
            }
            else if (velkost == 40)
            {
                velkost = 50;
            }
            else 
            {
                velkost = 30;
            }
            

            okno_txt.Text += Environment.NewLine;
            okno_txt.Text += "Velkost: " + velkost + "cm" + Environment.NewLine;
            
        }

        private void objdn_txt_Click(object sender, RoutedEventArgs e)
        {
            if (pocetsurovin > 4)
            {
                zlava = 2;
            }
            else
            {
                zlava = 0;
            }
            decimal koeficient = 1;
            if (velkost == 30)
            {
                koeficient = 1;
            }
            else if (velkost == 40)
            {
                koeficient = 1.5m;
            }
            else if (velkost == 50)
            {
                koeficient = 2;
            }




            decimal konecnaCena = (cena * koeficient) - zlava;

                okno_txt.Text += Environment.NewLine;
                okno_txt.Text += "Objednavka" + Environment.NewLine;
                okno_txt.Text += "Velkost: " + velkost + " cm" + Environment.NewLine;
                okno_txt.Text += "Zlava: " + zlava + " €" + Environment.NewLine;
                okno_txt.Text += "Konecna cena: " + konecnaCena + " €";

            }

       
       




    }
}
