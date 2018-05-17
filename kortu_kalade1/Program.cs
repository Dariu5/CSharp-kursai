using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortu_kalade1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<korta> kortos = new List<korta>();

            List<korta> kortos_ismaisytos = new List<korta>();

            Random rnd = new Random();

            string[] zenklai = { "K", "P", "S", "B" };
            string[] skaicius = { "A", "2", "3","4","5","6","7","8","9","10","J","Q","K" };


            for (int i = 0; i < zenklai.Length; i++)
            {

                for (int ii = 0; ii < skaicius.Length; ii++)
                {

                    kortos.Add(new korta(zenklai[i], skaicius[ii]));

                }
            }

            int indeksas = 0;


            while (kortos.Count > 0)
            {

               indeksas = rnd.Next(0, kortos.Count);


                Console.WriteLine(kortos.ElementAt(indeksas).Zenklas + kortos.ElementAt(indeksas).Skaicius); 

               // kortos.ElementAt(indeksas).Isvesti();
                kortos_ismaisytos.Add(kortos.ElementAt(indeksas));

               kortos.RemoveAt(indeksas);

            }

            Console.ReadLine();


        }
    }
}
