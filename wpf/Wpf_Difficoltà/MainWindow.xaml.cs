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

namespace Wpf_Difficoltà
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

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtNumber.Clear();
            TxtRandom.Clear();
        }

        private void Btn_Calcola_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(TxtNumber.Text);
            if (n > 100 || n < 1)
            {
                MessageBox.Show("il numero inserito non è valido", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
