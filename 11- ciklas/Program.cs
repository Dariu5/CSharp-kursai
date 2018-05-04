using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__ciklas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kiek norėsite kartų įvesti?");

            var kartai = Convert.ToInt64(Console.ReadLine());

            string[] tekstas = new string[kartai];

            for (int i = 0; i < tekstas.Length;i++)
            {
                Console.WriteLine("Iveskite teksta:");
                tekstas[i] = Console.ReadLine();
            }


            for (int i = 0; i < tekstas.Length; i++)
            {
                Console.WriteLine(tekstas[i]);
            
            }


        }
    }
}
