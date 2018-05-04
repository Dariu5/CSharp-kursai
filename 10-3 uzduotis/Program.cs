using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            int patikra = 0;

            int suma_kvadratų = 0;

            while (skaicius <11)
            {
                patikra = 0;
                for (int i = 1; i < skaicius; i++)
                {
                    if ((skaicius % i) == 0)
                        patikra++;
                }
                if (patikra == 2)
                    suma_kvadratų += skaicius * skaicius;

                skaicius++;
                
            }


            Console.WriteLine(suma_kvadratų);


        }
    }
}
