using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> zodynas = new List<string> { "alus", "bala", "debesis", "pokstas", "transformatorius", "yla" };

            string max = zodynas[0];
            string min = zodynas[0];


            foreach (var zodis in zodynas)
            {
                if (zodis.Length > max.Length)
                    max = zodis;

                if (zodis.Length < min.Length)
                    min = zodis;

            }


            Console.WriteLine("Ilgiausias zodis yra {0}, jo ilgis yra {1}", max, max.Length);
            Console.WriteLine("Ilgiausias zodis yra {0}, jo ilgis yra {1}", min, min.Length);





        }
    }
}
