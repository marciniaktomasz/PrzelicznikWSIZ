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
    public partial class masa : Window
    {
        String zJednostka_string = "centymetr";
        String naJednostka_string = "centymetr";

        public masa()
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

        private void gram_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "gram";
        }

        private void funt_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "funt";
        }

        private void kilogram_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "kilogram";
        }

        private void kwintal_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "kwintal";
        }

        private void gram_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "gram";
        }

        private void funt_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "funt";
        }

        private void kilogram_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "kilogram";
        }

        private void kwintal_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "kwintal";
        }
    }
    
}
