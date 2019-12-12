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

namespace Lancio_Dado
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

        private void BtnRandom_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int NumeroRandom = random.Next(1, 6);
            int n = Convert.ToInt32(Txt1.Text);
            int puntata = int.Parse(TxtPuntata.Text);
            int crediti = int.Parse(TxtCredits.Text);
            if(crediti <= 0)
            {
                MessageBox.Show("inserisci solo numeri positivi");
            }
            if (n < 1 || n > 6)
            {
                MessageBox.Show("il numero inserito non è valido", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (n == NumeroRandom)
            {
                TxtResult.Text = NumeroRandom + " Hai vinto";
                crediti = crediti + puntata ;
                TxtCredits.Text = Convert.ToString(crediti);
            }
            else
            {
                TxtResult.Text = NumeroRandom + " Hai perso";
                crediti = crediti - puntata;
                TxtCredits.Text = Convert.ToString(crediti);
                dado.Source = new BitmapImage(new Uri($@"dadi/dado{NumeroRandom}.png", UriKind.Relative));
            }
            if (crediti == 0)
            {
                MessageBox.Show("Hai esaurito i crediti", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Txt1.Clear();
            TxtResult.Clear();
            TxtCredits.Clear();
            TxtPuntata.Clear();
        }
    }
}