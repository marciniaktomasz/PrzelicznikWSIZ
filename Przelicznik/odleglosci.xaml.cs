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
    public partial class odleglosci : Window
    {
        String zJednostka_string = "centymetr";
        String naJednostka_string = "centymetr";

        public odleglosci()
        {
            InitializeComponent();
            zInput.Text = "0";
        }
        /// <summary>
        /// Wykonuje konwersję odległości
        /// </summary>
        private void bPrzelicz_Click(object sender, RoutedEventArgs e)
        {
            Aplication przelicznik = new Aplication();
            Double ilosc = Convert.ToDouble(zInput.Text);

            

            Double ilosc_po_konwersji = przelicznik.przelicz(zJednostka_string, naJednostka_string, ilosc);

            
            this.naInput.Text = ilosc_po_konwersji.ToString();
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - centymetr
        /// </summary>
        private void centymetr_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "centymetr";
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - cal
        /// </summary>
        private void cal_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "cal";
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - metr
        /// </summary>
        private void metr_Checked(object sender, RoutedEventArgs e)
        {
            zJednostka_string = "metr";
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - centymetr
        /// </summary>
        private void centymetr_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "centymetr";
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - cal
        /// </summary>
        private void cal_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "cal";
        }
        /// <summary>
        /// Ustawia jednostkę po kliknięciu na checkbox - metr
        /// </summary>
        private void metr_Copy_Checked(object sender, RoutedEventArgs e)
        {
            naJednostka_string = "metr";
        }
        /// <summary>
        /// powrót do menu głównego
        /// </summary>
        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow view = new MainWindow();
            view.Show();
            this.Close();
        }
    }
    
}
