using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 3;
            var kvadratas = Math.Pow(skaicius, 2);
            var kubas = Math.Pow(skaicius, 3);

            Console.WriteLine("Skaicius: {0} kvadratas: {1} kubas: {2}", skaicius,kvadratas,kubas);
            Console.ReadLine();

        }
    }
}
