using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Iveskite rezius");

            var a = Convert.ToInt64(Console.ReadLine());
            var b = Convert.ToInt64(Console.ReadLine());


            if (b>a)
            {
                for (var i = a; i < b; i++)
                {
                    if ((i%2 != 0)|| (i % 8 == 0))
                    {
                        Console.WriteLine(value: i);
                    }
                }
            }
        }
    }
}
