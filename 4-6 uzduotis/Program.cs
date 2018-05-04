using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var suma = 0.0;

            Console.WriteLine("Trys skaičiai vidurkiui įvesti?");

            suma += Convert.ToDouble(Console.ReadLine());
            suma += Convert.ToDouble(Console.ReadLine());
            suma += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaičių vidurkis yra: {0}", Math.Round(suma/3.0,1));

            Console.Read();

        }
    }
}
