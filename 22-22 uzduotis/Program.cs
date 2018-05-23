using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_22_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            Ivykis ivikis = new Ivykis();

            ivikis.IvikisDone += consoleprint;
            ivikis.IvikisDone += txtprint;

            ivikis.Procesas();





             void consoleprint (object sender, EventArgs eventArgs)

            {

                Console.WriteLine("Spausdinu");

            }


            void txtprint(object sender, EventArgs eventArgs)

            {

                StreamWriter sw = new StreamWriter("test.txt");

                sw.WriteLine("Ivykis buvo");
                sw.Flush();



            }




        }
    }
}
