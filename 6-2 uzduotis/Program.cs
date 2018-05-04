using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");

            var a = Convert.ToInt64(Console.ReadLine());
            var b = Convert.ToInt64(Console.ReadLine());
            var c = Convert.ToInt64(Console.ReadLine());


            if (a < b && a < c)
            {
                Console.WriteLine("Pirmas skaicius maziausias");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Antras skaicius maziausias");
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("Trecias skaicius maziausias");
            }

            Console.ReadLine();
        }
    }
}
