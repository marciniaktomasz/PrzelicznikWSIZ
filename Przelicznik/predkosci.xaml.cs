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

namespace Przelicznik
{
    /// <summary>
    /// Logika interakcji dla klasy odleglosci.xaml
    /// </summary>
    public partial class predkosci: Window
    {
        String zJednostka_string = "centymetr";
        String naJednostka_string = "centymetr";

        public predkosci()
        {
            InitializeComponent();
            zInput.Text = "0";
        }

        private void bPrzelicz_Click(object sender, RoutedEventArgs e)
        {
            Aplication przelicznik = new Aplication();
            Double ilosc = Convert.ToDouble(zInput.Text);

            

            Double ilosc_po_konwersji = przelicznik.przelicz(zJednostka_string, naJednostka_string, ilosc);

            
            this.naInput.Text = ilosc_po_konwersji.ToString();
        }

       

        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow view = new MainWindow();
            view.Show();
            this.Close();
        }

        private void metryH_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "metry/s";
        }

        private void kilometryH_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "kilometry/h";
        }

        private void mileH_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "mile/h";
        }

        private void metryH_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "metry/s";
        }

        private void kilometryH_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "kilometry/h";
        }

        private void mileH_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "mile/h";
        }
    }
    
}
