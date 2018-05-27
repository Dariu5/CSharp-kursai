using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_nd
{
    class Mokykla
    {
        public int Klases_skaicius { get; set; }
        public char Klases_raide { get; set; }
        public int Mokiniu_skaicius { get; set; }
        public int Mokymosi_pradzios_metai { get; set; }


        public int Mokosi_metu()

        {

            return DateTime.Today.Year - Mokymosi_pradzios_metai;

        }
    }


    class Klase : Mokykla
    {

        public List<string> Mokiniu_vardai { get; set; }
        public Double[] Pazymiu_vidurkis { get; set; }
                
    }
}
