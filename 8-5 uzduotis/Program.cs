using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite rezius");

           var  a = Convert.ToInt64(Console.ReadLine());
           var  b = Convert.ToInt64(Console.ReadLine());

            if (b>a)
            {
                for (var i = a; i < b; i++)
                {
                    Console.WriteLine("{0} - {1}" , i,Math.Pow(i,2) );
                }

            }
          
           



        }
    }
}
