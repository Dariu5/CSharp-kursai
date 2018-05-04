using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_pvz
{
    class Program
    {
        static void Main(string[] args)
        {


            var programa = new Program();

            programa.atsisveikinti();
            programa.pasisveikinti();

            atsisveikinti2();
            pasisveikinti2();



        }


        public static void pasisveikinti2()

        {

            Console.WriteLine("labas");

        }

        public static void atsisveikinti2()

        {

            Console.WriteLine("Viso");

        }



        public void pasisveikinti()
            {


                Console.WriteLine("Labas");

            }


            public void atsisveikinti()

            {

                Console.WriteLine("Viso gero, sakiau VISO GERO!");

            }


        
    }
}
