using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidurkis = 0.0;
            Console.WriteLine("Iveskite tris pazymius:");

            var a = Convert.ToInt64(Console.ReadLine());
            var b = Convert.ToInt64(Console.ReadLine());
            var c = Convert.ToInt64(Console.ReadLine());


            vidurkis = (double)(a + b + c) / 3;

            Console.WriteLine("Vidurkis: " + vidurkis);

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("Vidurkis yra [8-10]");
            }
            else if (vidurkis >= 5 && vidurkis < 8)
            {
                Console.WriteLine("Vidurkis yra [5-8)");
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("Vidurkis yra <5");
            }


        }
    }
}
