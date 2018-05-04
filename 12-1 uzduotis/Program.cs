using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var rnd = new Random();

            List<int> skaiciai = new List<int>();


           var  size = rnd.Next(10000);


            for (int i = 0; i < size; i++)
            {
                skaiciai.Add(rnd.Next(100));
            }

            var max = skaiciai[0];
            var min = skaiciai[0];

            var vidurkis = 0.0;
            var lyg_suma = 0;
            var zemiau_vid = 0;

            foreach (var skaicius in skaiciai)
            {
                if (skaicius > max)
                {
                    max = skaicius;
                }

                if (skaicius < min)
                {
                    min = skaicius;
                }

                if (skaicius%2==0)
                {
                    lyg_suma += skaicius;
                }

                vidurkis += (double)skaicius / (double)skaiciai.Count;


            }

            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    zemiau_vid++;
                }
            }


            Console.WriteLine("masymas su dydziu: " + skaiciai.Count);

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine("Max " + max);
            Console.WriteLine("Min " + min);
            Console.WriteLine("Vidurkis " + vidurkis);
            Console.WriteLine("Zemiau uz vidurki " + zemiau_vid);
            Console.WriteLine("Lyginiu skaiciu suma:" + lyg_suma);



        }
    }
}
