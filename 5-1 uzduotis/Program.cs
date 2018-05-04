using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite 3 sveikuosiu skaičius");

            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());

            if (a==b)
            {
                Console.WriteLine("Pirmas ir antras skaičius lygūs");
            }

            if (b == c)
            {
                Console.WriteLine("Antras ir trečias skaičius lygūs");
            }

            if (a > b)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antrą");
            }

            if (b > (2*c))
            {
                Console.WriteLine("Antras skaicius didesnis už dvibugą antrą");
            }

            if ((a%2) == 0)
            {
                Console.WriteLine("Pirmas skaičius yra lyginis");
            }

            if ((b%2) != 0)
            {
                Console.WriteLine("Antras  skaičius yra nelyginis");
            }

            if (c > 0)
            {
                Console.WriteLine("Trečias skaičius yra teigiamas");
            }

            if (c < 0)
            {
                Console.WriteLine("Trečias skaičius yra neiteigiamas");
            }

            Console.ReadLine();
        }
    }
}
