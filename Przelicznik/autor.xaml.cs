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
    public partial class autor: Window
    {

        public autor()
        {
            InitializeComponent();

        }

       

       

        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow view = new MainWindow();
            view.Show();
            this.Close();
        }

       
    }
    
}
