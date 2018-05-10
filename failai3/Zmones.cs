using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace failai3
{
    class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde{ get; set; }
        public int Amzius { get; set; }

        public Zmogus(string vardas, string pavarde, int amzius)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;

        }


        public Zmogus(string eilute)
        {
            var duomenys = eilute.Split(';');
            Vardas = duomenys[0];
            Pavarde = duomenys[1];
            Amzius = Convert.ToInt16(duomenys[2]);          
        }
    }
}
