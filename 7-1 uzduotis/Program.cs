using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pasirinkite;");
            Console.WriteLine("1- vanduo");
            Console.WriteLine("2- kava");
            Console.WriteLine("3- arbata");

            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("Vanduo");
                    break;
                case "2":
                    Console.WriteLine("Kava");
                    break;
                case "3":
                    Console.WriteLine("Arbata");
                    break;

                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }

        }
    }
}
