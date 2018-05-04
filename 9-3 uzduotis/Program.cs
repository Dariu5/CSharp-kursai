using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 0.0;
            var b = 0.0;

            char instrukcija = 't';

            while (instrukcija == 't')


            {
                Console.WriteLine("");
                Console.WriteLine("Įveskite skaičius");

                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("{0} + {1} = {2}", a,b,a+b);
                Console.WriteLine("{0}- {1} = {2}", a,b,a-b);
                Console.WriteLine("{0} * {1} = {2}", a,b,a*b);
                Console.WriteLine("{0} / {1} = {2}", a,b,a/b);

                Console.WriteLine("Ar tęsti?");
                instrukcija = Console.ReadKey().KeyChar;

            }


            


        }
    }
}
