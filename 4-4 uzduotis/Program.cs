﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite 3 skaičius");

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,a+b+c);
            Console.WriteLine("{0} - {1} - {2} = {3}", a, b, c, a - b - c);
            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);
            Console.WriteLine("{0} / {1} / {2} = {3}", a, b, c, a / b / c);

            Console.ReadLine();


        }
    }
}
