﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] masyvas = new int[10];


            masyvas[0] = 0;
            masyvas[1] = 1;

            var suma = 0;


            for (int i = 2; i < masyvas.Length; i++)
            {

                masyvas[i] = masyvas[i - 1] + masyvas[i - 2];

            }

            foreach (var elementras in masyvas)
            {
                Console.WriteLine(elementras);

                suma += elementras;
            }

            Console.WriteLine("Suma: " + suma);

        }

    }

}
