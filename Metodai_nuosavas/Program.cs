using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai_nuosavas
{
    class Program
    {
        static void Main(string[] args)
        {


            var  programa = new Program();


            var duom_kiek = programa.GautiDuomenuKieki();

            Console.WriteLine("Pirmo miesto pavadinimas");

            var miestas1_str = programa.GautiMiestoPavadinima();


            var miestas1 = programa.Duomenu_ivedimas(duom_kiek);


            Console.WriteLine("Antro miesto pavadinimas");

            var miestas2_str = programa.GautiMiestoPavadinima();

            var miestas2 = programa.Duomenu_ivedimas(duom_kiek);


            Console.WriteLine("Duomenys");

            Console.WriteLine(miestas1_str + " :");
            programa.IsvestiDuomenis(miestas1);

            Console.WriteLine(miestas2_str + " :");
            programa.IsvestiDuomenis(miestas2);





           Console.WriteLine(miestas1_str +  " vidutine temperatura "  + programa.Vidurkis(miestas1));

            Console.WriteLine(miestas2_str + " vidutine temperatura " + programa.Vidurkis(miestas2));




        }


        public double Vidurkis(List<double> masyvas)


        {

            var vidurkis = 0.0;

            foreach (var temperatura in masyvas)
            {

                vidurkis += (double)temperatura / masyvas.Count; 

            }


            return vidurkis;


        }






        public int GautiDuomenuKieki()


        {

            Console.WriteLine("Duomenu kiekis?");


            return Convert.ToInt16(Console.ReadLine());

        }




        public List<double> Duomenu_ivedimas(int kiek)

        {

            List<double> temperaturos = new List<double>();

            Console.WriteLine("Iveskite temperaturas");

            for (int i = 0; i < kiek; i++)
            {
                temperaturos.Add(Convert.ToDouble(Console.ReadLine()));

            }



            return temperaturos;
                
        }


        public string GautiMiestoPavadinima()

        {

            return Console.ReadLine();


        }


        public void IsvestiDuomenis(List<double> masyvas
            )


        {           

            foreach (var  temperatura in masyvas)
            {
                Console.WriteLine(temperatura + "°C");
            }



        }





    }
}
