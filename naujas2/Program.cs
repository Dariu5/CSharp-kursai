using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naujas2
{
    class Program
    {

        

        static void Main(string[] args)
        {

            var prog = new Program();

            prog.uzklausa();           

        }



        public void uzklausa()

        {

            Console.WriteLine("Iveskite du skaicius");           

            Console.WriteLine(sudedu_skaicius(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        
        }



        public int sudedu_skaicius(int a, int b)


        {

            return a + b;

        }
    }
}
