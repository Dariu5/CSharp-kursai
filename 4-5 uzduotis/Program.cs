using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Įveskite sveiką skaičių daugybos lentelei gauti");

            var skaicius = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("{0} * {1} = {2}", skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 5, skaicius * 5);
           

            Console.ReadLine();

        }
    }
}
