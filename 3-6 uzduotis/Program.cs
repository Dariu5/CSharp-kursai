using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 56;
            var pirmas_skaicius = skaicius / 10;
            var antras_skaicius = skaicius - pirmas_skaicius * 10;
            var sandauga = pirmas_skaicius * antras_skaicius;

            Console.WriteLine(sandauga);
            Console.ReadLine();


        }
    }
}
