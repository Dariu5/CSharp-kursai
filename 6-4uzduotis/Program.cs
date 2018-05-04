using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");

            var a = Convert.ToInt64(Console.ReadLine());
            var b = Convert.ToInt64(Console.ReadLine());

            if (a>b||a==0)
            {
                Console.WriteLine("Pirmas skaičius yra dideesnis uz antra arba lygus nuliui");
            }if (b>a||a==5)
            {
                Console.WriteLine("Pirmas antras skaicius yra dideesnis uz pirmą arba lygus 5");
            }if (a>b&&a==20)
            {
                Console.WriteLine("Pirmas skaičius yra dideesnis uz antra ir lygus 20");
            }if (b>a&&b<100)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma ir yra mazesnis uz 100");
            }
        }
    }
}
