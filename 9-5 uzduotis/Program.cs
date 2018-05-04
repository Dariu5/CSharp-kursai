using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            var skaicius = 0;

            Console.Write("Įveskite skaičių:  ");

            skaicius = Convert.ToInt16( Console.ReadLine());

            while (!(skaicius%9==0))

            {
                Console.WriteLine("");

                Console.Write("Įveskite skaičių:  ");
                skaicius = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Skaicius dalinasi is 9 ");
        }
    }
}
