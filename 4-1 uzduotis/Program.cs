using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite vardą ir amžių");

            var vardas = Console.ReadLine();
            var amzius = Console.ReadLine();

            Console.WriteLine("Jūsų vardas {0}, o amžius {1}",vardas, amzius);

            Console.ReadLine();
        }
    }
}
