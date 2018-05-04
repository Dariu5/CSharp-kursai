using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var keliones = new int[] {147,142,254,10,10,25,36,14,21,124 };


            var max = keliones[ 0];
            var min = keliones[0];

            var suma_kelioniu = 0;

            var degalu_kieks = 60;


            foreach (var kelione in keliones)
            {

                if (kelione > max)
                {
                    max = kelione;
                }

                if (kelione<min)
                {
                    min = kelione;
                }

                suma_kelioniu += kelione;


            }

            var sanaudos = (double)degalu_kieks / (double)suma_kelioniu * 100;

            Console.WriteLine("Trumpiausia kelione: " + min);
            Console.WriteLine("Ilgiausia kelione: " + max);

            Console.WriteLine("Sanaudos: " + sanaudos + " l/100km");


        }
    }
}
