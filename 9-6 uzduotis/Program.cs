using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var tikras = rnd.Next(0, 10);

            var spejimas = 0;

            Console.WriteLine("Bandykite atspeti skaiciu 1 - 10: ");

            spejimas = Convert.ToInt16(Console.ReadLine());


            while (spejimas != tikras)

            {

                Console.WriteLine("Bandykite atspeti skaiciu 1 - 10: ");


                if (spejimas > tikras)
                    Console.WriteLine("Skaicius yra mazenis");
                else
                    Console.WriteLine("Skaicius yra didesnis");

                spejimas = Convert.ToInt16(Console.ReadLine());

            }

            Console.WriteLine("Atspejote!");
        }
    }
}
