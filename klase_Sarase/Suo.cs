using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_Sarase
{
    class Suo
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;

        public Suo(string vardas, int amzius, string veisle)
        {

            Vardas = vardas;
            Amzius = amzius;
            Veisle = veisle;

        }

        public void Isvedimas()

        {


            Console.WriteLine("Vardas: {0} Veisle: {1} Amzius: {2}",Vardas,Veisle,Amzius);


        }



    }
}
