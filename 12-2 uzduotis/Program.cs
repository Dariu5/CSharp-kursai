using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Iveskite pazymiu kieki: ");

            Random rnd = new Random(0);

            var kiekis = Convert.ToInt16(Console.ReadLine());


            List <int> sarasas = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("Laukiu skaiciaus:");
                sarasas.Add(Convert.ToInt16(Console.ReadLine()));
            }

            var max = sarasas[0];
            var min = sarasas[0];

            var vidurkis = 0.0;

            foreach (var pazimys in sarasas)
            {
                if (pazimys > max)
                    max = pazimys;

                if (pazimys<min)
                {
                    min = pazimys;
                }

                vidurkis += (double)pazimys / (double)sarasas.Count;
                
            }

            Console.WriteLine("max balas " + max);
            Console.WriteLine("min balas " + min);
            Console.WriteLine("Vidurkis " + vidurkis);

            Console.WriteLine("Atsitiktinis balas " + sarasas[rnd.Next(sarasas.Count-1)]);


        }
    }
}
