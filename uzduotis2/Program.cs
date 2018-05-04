using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis2
{
    class Program
    {
        static void Main(string[] args)
        {

            var program = new Program();

            Console.WriteLine("Iveskite skaicius");

            var sarasas = program.Sarasas();


            foreach (var skaicius in sarasas)
            {
                Console.WriteLine(skaicius);
            }


            Console.WriteLine("Rasti max: " + program.rasti_max(sarasas));

            Console.WriteLine("Rasta suma: " + program.rasti_suma(sarasas));
            Console.WriteLine("Rastas vidurkis : " + program.rasti_avg(sarasas));

        }
                
        public List<int> Sarasas()

        {


            List <int>  sarasas = new List<int>();


            for (int i = 0; i < 10; i++)
                
            {
                sarasas.Add(Convert.ToInt32(Console.ReadLine()));
            }


            return sarasas;
            

        }

        public  int rasti_max(List<int> petras)

        {

             return petras.Max();

        }


        public int rasti_suma(List<int> petras)

        {

            return petras.Sum();

        }


        public double rasti_avg(List<int> petras)

        {

            return (double)rasti_suma(petras) / petras.Count();

        }

    }
}
