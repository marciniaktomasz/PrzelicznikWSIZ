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
    public partial class powierzchnia : Window
    {
        String zJednostka_string = "centymetr";
        String naJednostka_string = "centymetr";

        public powierzchnia()
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

        private void mm2_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "mm2";
        }

        private void cm2_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "cm2";
        }

        private void m2_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "m2";
        }

        private void ar_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "ar";
        }

        private void ha_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "ha";
        }

        private void mm2_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "mm2";
        }

        private void cm2_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "cm2";
        }

        private void m2_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "m2";
        }

        private void ar_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "ar";
        }

        private void ha_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "ha";
        }
    }
    
}
