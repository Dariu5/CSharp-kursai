using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_2_uzduotis
{
    class Zmogus
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }


        public Zmogus(string Vardas, int Amzius)
        {

            this.Vardas = Vardas;
            this.Amzius = Amzius;

        }




        public void AmziausGrupesNustatymas(Action<string, int> grupesNustatymoAction)

        {

            grupesNustatymoAction(Vardas, Amzius);


        }

    }
}
