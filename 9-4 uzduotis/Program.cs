using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            string zodis;
            string zodis_ilgas = "";
            Console.Write("Iveskite zodi arba exit:  ");


            zodis = Console.ReadLine();

            while (zodis != "exit")

            {
                Console.WriteLine("");

                zodis_ilgas += zodis;
                zodis_ilgas += " ";
                Console.Write("Iveskite zodi arba exit: ");
                zodis = Console.ReadLine();
            }

            Console.WriteLine(zodis_ilgas);


        }
    }
}
