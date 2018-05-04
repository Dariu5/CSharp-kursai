using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {


            var masyvas = new int[] { 10, 5, 10, 10, 10, 5, 11, 10, 5 };

            var suma = 0;
            var suma2 = masyvas.Sum();
            var max = masyvas[0];

            foreach (var skaicius in masyvas)
            {
                suma += skaicius;
            }


            foreach (var skaicius in masyvas)
            {
                if (skaicius > max)
                    max = skaicius;
            }


            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Suma: " + suma2);

            Console.WriteLine("Max: " + max);
        }
    }
}
