using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Skaicius");

            Int64 skaicius = Int64.Parse(Console.ReadLine());




            for ( Int64 i = skaicius; i > 0; i--)
            {

                if (Artvarkingas(skaicius))
                {
                    Console.WriteLine(skaicius.ToString());
                    break;
                }
                    





            }


            


        }

        static bool Artvarkingas(Int64 sk)

        {

            Int64 sk1 = sk % 10;
            Int64 sk2 = sk % 100 / 10;

            if (sk1 >= sk2)

            {


                sk /= 10;

                if (sk != 0)
                {

                    return Artvarkingas(sk);

                }
                return true;
            }

            else
            {

                return false;

            }


        }

    }
}
