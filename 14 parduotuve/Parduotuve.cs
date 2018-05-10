using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_parduotuve
{
    class Parduotuve
    {

        public string Pavadinimas;
        public string Adresas;
        public string Plotas;
        public List<Preke> Prekes;

        public string Populiariausia_preke()

        {
            var max_kiekis = Prekes.First().Kiekis;
            var pavadinimas = Prekes.First().Pavadinimas;

            foreach (var Preke in Prekes)
            {
                if (Preke.Kiekis> max_kiekis)
                {
                    max_kiekis = Preke.Kiekis;
                    pavadinimas = Preke.Pavadinimas;
                }


            }

            return pavadinimas;
        }



        public 



    }



   


}
