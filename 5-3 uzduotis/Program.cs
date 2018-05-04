using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite teigiama skaiciu");

            var skaicius = Convert.ToInt16(Console.ReadLine());

            if (skaicius < 0)
            {


                Console.WriteLine("SAKIAU GI VESTI TEIGIAMA!!!!!!!!");

            }

            if (skaicius >= 0)
            {
                Console.WriteLine("Sveikinimai, ivestas teigiamas skaicius!");
            }

            if ((skaicius % 2) == 0)
            {
                Console.WriteLine("Lyginis skaicius");
            }

            if ((skaicius % 4) == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

            if ((skaicius % 4) == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

            if (skaicius > 10)
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }

            Console.ReadLine();
        }
    }
    
}
