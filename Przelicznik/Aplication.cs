using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    class Aplication
    {
        public jednostki centymetr;
        public jednostki metr;
        public jednostki cal;

        public jednostki gram;
        public jednostki funt;
        public jednostki kilogram;
        public jednostki kwintal;

        public jednostki metrys;
        public jednostki kilometryh;
        public jednostki mileh;


        public Aplication()
        {
            //ODLEGŁOSCI
            centymetr = new jednostki ("odległości", "centymetr", "centymetr", 1.0 );  
            metr = new jednostki("odległości", "metr", "centymetr", 100.0);
            cal = new jednostki("odległości", "cal", "centymetr", 2.54);

            //MASA
            gram = new jednostki("masa", "gram", "kilogram", 0.001);
            funt = new jednostki("masa", "funt", "kilogram", 0.45359237);
            kilogram = new jednostki("masa", "kilogram", "kilogram", 1.0);
            kwintal = new jednostki("masa", "kwintal", "kilogram", 100.0);

            //predkosci
            metrys = new jednostki("predkosc", "metry/s", "metry/s", 1.0);
            kilometryh = new jednostki("predkosc", "kilometry/h", "metry/s", 0.2777777778);
            mileh = new jednostki("predkosc", "mile/h", "metry/s", 0.4470311111);

        }

        public jednostki jednostkaPodstawowa(string name) {
            if (name == "odległości") { return centymetr; }
            else { return centymetr; }
        }

        public jednostki klasaPoNazwie(string name)
        {
            if (name == "centymetr") { return centymetr; }
            else if (name == "metr") { return metr; }
            else if (name == "cal") { return cal; }
            else if (name == "gram") { return gram; }
            else if (name == "funt") { return funt; }
            else if (name == "kilogram") { return kilogram; }
            else if (name == "kwintal") { return kwintal; }
            else if (name == "metry/s") { return metrys; }
            else if (name == "kilometry/h") { return kilometryh; }
            else if (name == "mile/h") { return mileh; }
            else { return centymetr; }
        }

        public double przelicz(String z_, String na_, double wartosc)
        {
            jednostki z = this.klasaPoNazwie(z_);
            jednostki na = this.klasaPoNazwie(na_);
            double na_podstawowa = z.ilosc_w_jednostce_podstawowej;
            //double z_podstawowej_na_finalna = this.jednostkaPodstawowa(na.kategoria).ilosc_w_jednostce_podstawowej;
            double z_podstawowej_na_finalna = na.ilosc_w_jednostce_podstawowej;
            Debug.Write("z");

            return (wartosc*na_podstawowa)/z_podstawowej_na_finalna;
        }
    }
}
