using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1__uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite skaičių teigiamą");

            var var = Convert.ToInt16(Console.ReadLine());


            while (var > 0)

            {

                Console.WriteLine(var);
                var--;


            }


        }
    }
}
