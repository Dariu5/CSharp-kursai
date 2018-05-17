using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_uzduotis2
{
    class Program
    {
       
             [STAThread]
        static void Main(string[] args)
        {


            Console.WriteLine("Iveskite ID ir varda");

            string[] data = Console.ReadLine().Split(' ');
          

            DarbuotojasConsole zmog = new DarbuotojasConsole(int.Parse(data[0]),data[1]);
            zmog.PrintOutData();
        }
    }
}
