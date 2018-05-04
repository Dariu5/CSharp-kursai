using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            int pasirinkimas = 0;



            do
            {
                Console.WriteLine("Iveskite pasirinkma 1,2,3");

                pasirinkimas = Convert.ToInt16(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 3)
                    Console.WriteLine("Blogas pasirinkimas");


            } while (pasirinkimas <1 || pasirinkimas >3);

            Console.WriteLine("Pasirinkimas: ",pasirinkimas);
        }
    }
}
