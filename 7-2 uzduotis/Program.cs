using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("pasirinkite;");
            Console.WriteLine("1- stacionarus");
            Console.WriteLine("2- nesiojamas");
            Console.WriteLine("3- plansete");

            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("Didelis ir sunkus");
                    break;
                case "2":
                    Console.WriteLine("Ištikrųjų tai pernešamas");
                    break;
                case "3":
                    Console.WriteLine("Tinka kaip pagrindas pjaustyti lašinius");
                    break;

                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }
        }
    }
}
