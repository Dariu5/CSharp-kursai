using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();



            var balai2016 = programa.Ivedimas();
            var balai2017 = programa.Ivedimas();
            Console.WriteLine("---------------------------------");


            programa.Isvedimas(balai2016);
            Console.WriteLine("---------------------------------");
            programa.Isvedimas(balai2017);
            Console.WriteLine("---------------------------------");
            var Suma2016 = programa.Suma(balai2016);
            Console.WriteLine("---------------------------------");
            var Suma2017 = programa.Suma(balai2017);
            Console.WriteLine("---------------------------------");
            programa.Palyginimas_vidurkiu(balai2016, balai2017);
            Console.WriteLine("---------------------------------");
            programa.Palyginimas_maziausio(balai2016, balai2017);
            Console.WriteLine("---------------------------------");

        }



        public int Aukstenis_uz_vidurki_skaicius(Dictionary<string, int> balai)


        {

            var didesni = 0;

            foreach (var balas in balai)
            {

                if (balas.Value > Vidurkis(balai))
                    {
                    didesni++;

                    }
            }


            return didesni;


        }


        public int  Maziausiasbalas(Dictionary<string,int> balai)

            {
                    var indeksas = 0;
            var maziausias = balai.ElementAt(0).Value;

            for (int i = 0; i < balai.Count; i++)
            {

                if (balai.ElementAt(i).Value < maziausias)
                    indeksas = i;
                maziausias = balai.ElementAt(i).Value;


            }


            return indeksas;
            
            }
        
        public int  Didziausiasbalas(Dictionary<string,int> balai)

            {
                    var indeksas = 0;
            var didziausias = balai.ElementAt(0).Value;

            for (int i = 0; i < balai.Count; i++)
            {

                if (balai.ElementAt(i).Value > didziausias)
                    indeksas = i;
                didziausias = balai.ElementAt(i).Value;


            }


            return indeksas;
            
            }
            public double  Vidurkis (Dictionary<string,int> balai)

            {

            var vidurkis = 0.0;

            foreach (var balas in balai)
            {

                vidurkis += (double)balas.Value / balai.Count;

            }


          


            return vidurkis;
            
            }



        public int Suma(Dictionary<string, int> balai)



        {
            int suma = 0;

            foreach (var balas in balai)
            {

                suma += balas.Value;

            }
            
            return suma;
        }



        public void Isvedimas(Dictionary<string, int> balai)


        {
            foreach (var balas in balai)
            {
                Console.WriteLine(balas.Key + " " + balas.Value);

            }


            Console.WriteLine("Suma " + Suma(balai));
            Console.WriteLine("Vidurkis " + Vidurkis(balai));
            Console.WriteLine("Didesni uz vidurki " + Aukstenis_uz_vidurki_skaicius(balai));

            Console.WriteLine("Maziausas balas: " + balai.ElementAt(Maziausiasbalas(balai)).Key + " " + balai.ElementAt(Maziausiasbalas(balai)).Value);
            Console.WriteLine("Didziausias balas: " + balai.ElementAt(Didziausiasbalas(balai)).Key + " " + balai.ElementAt(Didziausiasbalas(balai)).Value);
                       
        }


        public void Palyginimas_vidurkiu(Dictionary<string,int> balai1, Dictionary<string, int> balai2)


        {

            if (Vidurkis(balai1) > Vidurkis(balai2))
            {
                Console.WriteLine("Didesnis vidurkis 2016");
            }
            else if ((Vidurkis(balai1) < Vidurkis(balai2)))
                Console.WriteLine("Didesnis vidurkis 2017");
            else Console.WriteLine("Vidurkiai lygūs");


        }

        public void Palyginimas_maziausio(Dictionary<string,int> balai1, Dictionary<string, int> balai2)


        {

            if (Maziausiasbalas(balai1) < Maziausiasbalas(balai2))
            {
                Console.WriteLine("Mažesnis mažiausias balas 2016");
            }
            else if ((Maziausiasbalas(balai1) > Maziausiasbalas(balai2)))
                Console.WriteLine("Mažesnis mažiausias balas 2017");
            else Console.WriteLine("Maziausi balai lygūs");
        }
        

        public Dictionary<string, int> Ivedimas()

        {

            var balai = new Dictionary<string, int>();
            //kiek duomenu
            // gauti atsakyma is vartojo
            //sukti cikla

            Console.WriteLine("Kiek duomenų norite įvesti:?");

            var kiekis = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < kiekis; i++)
            {

                Console.WriteLine("Šalies pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.WriteLine("Balai: ");
                var gautibalai = Convert.ToInt16(Console.ReadLine());
                balai.Add(pavadinimas, gautibalai);                

            }


            return balai;
        }
    }
}
