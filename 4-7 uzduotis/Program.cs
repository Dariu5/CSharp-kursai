using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite celcius");

            var C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kelvinai: {0} , Fahrenheitai: {1}", C+ 273.15, C *1.8 +32);
            Console.ReadLine();

        }
    }
}
