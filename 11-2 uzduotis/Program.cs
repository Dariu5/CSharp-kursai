using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new int[] {10,2,2,2,2,2,2,2,2,2,2,2,2,2,2};

            var geriausias = 0;
            var desimtuku_skaicius = 0;
            var neigiamu_pazymiu_skaicius = 0;
            var vidurkis = 0.0;

            foreach (var pazimys in pazymiai)
            {

                if (pazimys > geriausias)
                {
                    geriausias = pazimys;
                }
                if (pazimys==10)
                {
                    desimtuku_skaicius++;

                }

                if (pazimys<4)
                {
                    neigiamu_pazymiu_skaicius++;
                }

                vidurkis += (double)pazimys / pazymiai.Length;
            }

            Console.WriteLine("Geriausias pazimys: " +geriausias);
            Console.WriteLine("Desimtuku skacius: " +desimtuku_skaicius);
            Console.WriteLine("Neigiamu balu skaicius: " +neigiamu_pazymiu_skaicius);
            Console.WriteLine("Pazymiu vidurkis: " +vidurkis);




        }
    }
}
