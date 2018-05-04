using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Int64 skaicius = 0;
            int radau = 0;



            while (radau == 0)

            {
                skaicius++;

                radau =0;

                for (int i = 1; i < 21; i++)
                {

                    if ((skaicius % i) == 0)
                        radau++;


                }

                if (radau != 20)
                    radau = 0;

            }

            Console.WriteLine(skaicius);


        }
    }
}
