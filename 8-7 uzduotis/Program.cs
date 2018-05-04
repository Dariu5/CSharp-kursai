using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite du skaicius dauginimui:");

            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());

            var rezultatas = 0;


            for (int i = 0; i < b; i++)
            {
                rezultatas += a;
            }

            Console.WriteLine("{0} * {1} = {2}", a,b,rezultatas);
        }
    }
}
