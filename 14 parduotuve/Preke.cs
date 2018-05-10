using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_parduotuve
{
    class Preke
    {

        public string Pavadinimas;
        public double Kaina;
        public double Savikaina;
        public Int32 Kiekis;


        public Preke(string pavadinimas, double kaina, double savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
        }

        public double Pelnas()
        {
            
            return Kaina - Savikaina;
        }

        public string ArPrekesPakanka()


        {
            if (Kiekis > 5)
            {
                return "Taip";
            }
            else return "Ne";


        }

    }
}
