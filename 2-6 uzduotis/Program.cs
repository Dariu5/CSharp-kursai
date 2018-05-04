using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "Fiat";
            var modelis = "Mutipla";
            var metai = 1874;
            var rida = 1247412;
            Console.WriteLine("Automobilio {0} {1} ({2} m.) - {3} km.", marke, modelis, metai, rida);
            Console.ReadLine();
        }
    }
}
