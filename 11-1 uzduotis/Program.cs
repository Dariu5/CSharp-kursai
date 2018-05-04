using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] masyvas = { 10, 5, 10, 5, 10, 5, 10, 5, 10 };
            var marke = new string[] { "Volvo", "Lada", "BMW", "Toyota" };

            char[] raides = new char[5];

            raides[0] = 'a';
            raides[1] = 'b';
            raides[2] = 'c';
            raides[3] = 'd';
            raides[4] = 'e';

            Console.WriteLine("pirmas narys " + masyvas.First());
            Console.WriteLine("paskutinis narys " + masyvas.Last());
            Console.WriteLine("Masyvos dydis " + masyvas.Length);
            Console.WriteLine("Trečias narys " + masyvas[3]);



        }
    }
}
