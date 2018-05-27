using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_nd
{

    class Klientas


    {
        public string Vardas { get; set; }
        public int Biudzetas { get; set; }

        public Klientas(string Vardas, int Biudzetas)
        {
            this.Vardas = Vardas;
            this.Biudzetas = Biudzetas;
        }


    }

    class Program
    {
       public static void Ar_siusti_zenkliukus(string vardas, int biudzetas)

        {

            if (biudzetas < 100)
                Console.WriteLine("{0} priklauso zenkliukai",vardas);

        }

        public static void Ar_siusti_tusinukus(string vardas, int biudzetas)

        {

            if (biudzetas > 100 && biudzetas < 1000)
                Console.WriteLine("{0} priklauso tusinukai", vardas);
        }

        public static void Ar_siusti_puodelius(string vardas, int biudzetas)

        {

            if (biudzetas > 1000)
                Console.WriteLine("{0} priklauso puodeliai", vardas);
        }



    static void Main(string[] args)
        {


            List<Klientas> Klientai = new List<Klientas>()

            {

                new Klientas("UAB Pušis", 15),
                new Klientas("UAB Dermava", 1500),
                new Klientas("UAB Gentis", 1),
                new Klientas("UAB Darbai", 147),
                new Klientas("UAB Poilsis", 100),



            };


            Action<string, int> rasti_dovana;

            rasti_dovana = Ar_siusti_zenkliukus;
            rasti_dovana += Ar_siusti_tusinukus;
            rasti_dovana += Ar_siusti_puodelius;

            foreach (var item in Klientai)
            {

                rasti_dovana(item.Vardas, item.Biudzetas);

            }

        }
    }
}
