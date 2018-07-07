using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    /// <summary>
    /// Klasa przechowująca informację o jednostkach
    /// </summary>
    class jednostki
    {
        public string kategoria;
        public string nazwa;
        public string jednostka_podstawowa;
        public double ilosc_w_jednostce_podstawowej;
        
        public jednostki(string kategoria, string nazwa, string jednostka_podstawowa, double ilosc_w_jednostce_podstawowej)
        {
            this.kategoria = kategoria;
            this.nazwa = nazwa;
            this.jednostka_podstawowa = jednostka_podstawowa;
            this.ilosc_w_jednostce_podstawowej = ilosc_w_jednostce_podstawowej;
        }



    }
}
