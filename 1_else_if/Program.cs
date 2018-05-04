using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_else_if
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 3 skaicius:");

            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());


            if (a > b)
            {

                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            else if (b > a)
            {
                Console.WriteLine("Antras skaicius didesnis uz pirma");
            }
            else if (a == b)
            {
                Console.WriteLine("Pirmas skaicius lygus antram");
            }

            if (c > a)

            {
                Console.WriteLine("Trecias skaicius didesnis uz pirma");

            }

            Console.ReadLine();



        }
    }
}
