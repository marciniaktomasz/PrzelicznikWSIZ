﻿using System;
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

namespace Przelicznik
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Otwiera okno przeliczania jednostek odległości
        /// </summary>
        private void bOdleglosci(object sender, RoutedEventArgs e)
        {
            odleglosci view = new odleglosci();
            view.Show();
            this.Close();
        }

        /// <summary>
        /// Otwiera okno przeliczania jednostek masy
        /// </summary>
        private void bMasa(object sender, RoutedEventArgs e)
        {
            masa view = new masa();
            view.Show();
            this.Close();
        }

        /// <summary>
        /// Otwiera okno przeliczania jednostek prędkości
        /// </summary>
        private void bPredkosc(object sender, RoutedEventArgs e)
        {
            predkosci view = new predkosci();
            view.Show();
            this.Close();
        }

        /// <summary>
        /// Otwiera okno przeliczania jednostek powierzchni
        /// </summary>
        private void bPowierzchnia(object sender, RoutedEventArgs e)
        {
            powierzchnia view = new powierzchnia();
            view.Show();
            this.Close();
        }

        /// <summary>
        /// Otwiera okno z informacjami o autorze
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           autor view = new autor();
            view.Show();
            this.Close();
        }

        /// <summary>
        /// Zamyka aplikacje
        /// </summary>
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
