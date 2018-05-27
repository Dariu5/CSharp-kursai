using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd
{

    public interface Gyvunas

    {

        string Vardas { get; set; }

        string Apibudinimas();

        


    }

    public class Suo : Gyvunas

    {
        public string Vardas { get; set; }

        public Suo(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public string Apibudinimas()

        {

            return this.Vardas + " yra šuo";

        }


    }



    public class Kate : Gyvunas

    {
        public string Vardas { get; set; }

        public Kate(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public string Apibudinimas()

        {

            return this.Vardas + " yra katė";

        }


    }


    public class Triusis : Gyvunas

    {
        public string Vardas { get; set; }

        public Triusis(string Vardas)
        {
            this.Vardas = Vardas;
        }

        public string Apibudinimas()

        {

            return this.Vardas + " yra triusis";

        }


    }

    class Program
    {
        static void Main(string[] args)
        {


            List<Gyvunas> Gyvunai = new List<Gyvunas>()


                { new Kate("Rainis"),
                new Suo("Reksas"),
                new Triusis("Antanas")
            };


            foreach (var Gyvunas in Gyvunai)
            {
                Console.WriteLine(Gyvunas.Apibudinimas());
            }

        }
    }
}
