using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_Sarase
{
    class Prieglauda
    {

        public string Pavadinimas;
        public string Adresas;
        //public List<Suo> Sunys = new List<Suo>();
        public List<Suo> Sunys;


        public Prieglauda(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;

            Sunys = new List<Suo>(); //tuscias sarasas

        }

        public Prieglauda(string pavadinimas, string adresas,List<Suo> sunys)
        {
            Adresas = adresas;
            Pavadinimas = pavadinimas;
            Sunys = sunys; // uzpildytas sarasas is parametru
        }


        public void Isvedimas()


        {
            Console.WriteLine("Prieglaudos pavadinimas: " + Pavadinimas);
            Console.WriteLine("Prieglaudos adresas: " + Adresas);

            foreach (var suo in Sunys)
            {
                suo.Isvedimas();
            }


        }

    }
}
