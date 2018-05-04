using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite simbolį:");
            var simbolis = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");
            Console.WriteLine("{0}{0}{0}",simbolis);
            Console.WriteLine("{0} {0}",simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);

            Console.ReadLine();

        }
    }
}
