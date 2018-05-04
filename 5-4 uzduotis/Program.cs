using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Įveskite 5 pažymius:");

            var suma = 0.0;
            var vidurkis = 0.0;

            suma += Convert.ToInt32(Console.ReadLine());
            suma += Convert.ToInt32(Console.ReadLine());
            suma += Convert.ToInt32(Console.ReadLine());
            suma += Convert.ToInt32(Console.ReadLine());
            suma += Convert.ToInt32(Console.ReadLine());

            vidurkis = suma / 5.0;

            Console.WriteLine("Vidurkis: {0}",vidurkis);

            if (vidurkis > 5)
            {
                Console.WriteLine("Vidurkis didesnis už 5");
            }

            if (vidurkis < 5)
            {
                Console.WriteLine("VIDURKIS MAZESNIS UZ 5!!!!!!");
            }

            Console.ReadLine();


        }
    }
}
