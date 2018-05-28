using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_1_pvz
{

    class Zmogus
    {

        public int Ugis { get; set; }
        public double Svoris { get; set; }
        public string  Vardas { get; set; }

        public Zmogus(int Ugis, double Svoris, string Vardas)
        {
            this.Ugis = Ugis;
            this.Svoris = Svoris;
            this.Vardas = Vardas;

        }

        public double KMIskaiciavimas()

        {

            return (Svoris / Math.Pow((double)Ugis / 100, 2));

        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Zmogus> zmones = new List<Zmogus>()

            { new Zmogus(180,55,"Antanas"),
            new Zmogus(140,101,"Jonas"),
            new Zmogus(160,150,"Petras"),
            new Zmogus(170,87,"Linas"),
            new Zmogus(189,85,"Rokas"),
                        };


            IEnumerable<Zmogus> KMIDaugiau25 =
                from zmogus in zmones
                where zmogus.KMIskaiciavimas() > 25
                select zmogus;


            foreach (var item in KMIDaugiau25)
            {
                Console.WriteLine(item.Vardas);
            }

            IEnumerable<Zmogus> KMIGeras = zmones.Where(x => x.KMIskaiciavimas() > 20 && x.KMIskaiciavimas() < 25).
                OrderBy(x => x.Vardas);

            Console.WriteLine("*******************");

            foreach (var item in KMIGeras)
            {
                Console.WriteLine(item.Vardas);
            }


        }
    }
}
