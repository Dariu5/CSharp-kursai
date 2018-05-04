using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1__uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = {-10.1,-5.0,-0.1, 5, 10.4,20.8,32.1 };


            var min = temperaturos[0];
            var max = temperaturos[0];
            var suma = 0.0;

            var zemiau_min = 0;
            var auksciau_max = 0;

            foreach (var temperatura in temperaturos)
            {
                if (temperatura < min)
                {
                    min = temperatura;
                }
                if (temperatura>max)
                {
                    max = temperatura;
                }

                suma += temperatura;

            }

            var vidurkis = suma / temperaturos.Length;


            foreach (var temperatura in temperaturos)
            {
                if (temperatura>vidurkis)
                {
                    auksciau_max++;
                }
                if (temperatura<vidurkis)
                {
                    zemiau_min++;
                }
            }

            Console.WriteLine("Zemiausia temperatura " + min);
            Console.WriteLine("Auksciausia temperatura " + max);
            Console.WriteLine("Vidutine temperatura " + vidurkis);
            Console.WriteLine("Temperaturu zemesniu uz vidurki skaicius " + zemiau_min);
            Console.WriteLine("Temperaturu aukstesniu uz vidurki skaicius " + auksciau_max);

        }
    }
}
