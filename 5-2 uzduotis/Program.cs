using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite amžių");


            if (Convert.ToInt16(Console.ReadLine()) >= 18)

            {
                Console.WriteLine("Galite balsuoti!");
            }
            Console.ReadLine();
        }
    }
}
