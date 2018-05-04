using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("iveskite skaiciu kiek:");

            int kiekis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(1);
            Console.WriteLine(1);

            decimal pirmas = 1;
            decimal antras = 1;
            decimal trecias = 0;



            for (int i = 2; i < kiekis; i++)
            {
                trecias = pirmas + antras;

                Console.WriteLine(trecias);

                pirmas = antras;
                antras = trecias;
            }


        }
    }
}
