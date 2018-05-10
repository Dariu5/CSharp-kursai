using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_dalys
{
    class Program
    {
        static void Main(string[] args)
        {

            var kompas = new Kompiuteris();

            /// kompas.DiskoTalpa = 5; neveikia

            var kompas2 = new Kompiuteris("fff", "fff", 5);

            var kompas3 = new Kompiuteris();
            kompas3.Ivedimas();

        }
    }
}
