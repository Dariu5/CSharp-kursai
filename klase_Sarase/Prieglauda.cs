using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_Sarase
{
    class Prieglauda
    {

        public string Pavadinimas;
        public string Adresas;
        //public List<Suo> Sunys = new List<Suo>();
        public List<Suo> Sunys;


        public Prieglauda(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;

            Sunys = new List<Suo>(); //tuscias sarasas

        }

        public Prieglauda(string pavadinimas, string adresas,List<Suo> sunys)
        {
            Adresas = adresas;
            Pavadinimas = pavadinimas;
            Sunys = sunys; // uzpildytas sarasas is parametru
        }


        public void Isvedimas()


        {
            Console.WriteLine("Prieglaudos pavadinimas: " + Pavadinimas);
            Console.WriteLine("Prieglaudos adresas: " + Adresas);

            foreach (var suo in Sunys)
            {
                suo.Isvedimas();
            }


        }



        public void Checkin()


        {

            Console.Write("Kiek sunu?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i + 1 + " suns duomenys:");
                Sunys.Add(new Suo());
            }
        }

        public Suo VyriausiasSuo()

        {

            var vyriausias = Sunys.First();


            foreach (var suo in Sunys)
            {
                if (vyriausias.Amzius < suo.Amzius)
                {
                    vyriausias = suo;
                }
            }
            return vyriausias;
        }


        public Suo JauniausiasSuo()

        {
            var jauniausias = Sunys.First();


            foreach (var suo in Sunys)
            {
                if (jauniausias.Amzius > suo.Amzius)
                {
                    jauniausias = suo;
                }
            }
            return jauniausias;

            
        }


        public string Populiariausia_veisle()


        {
            Dictionary<string, int> veisles = SudarytiVeisliuDaznioSarasa();

            var populiariausia = 0;
            for (int i = 0; i < veisles.Count; i++)
            {

                if (veisles.ElementAt(i).Value > veisles.ElementAt(populiariausia).Value)
                {

                    populiariausia = i;
                }
                
            }
            
            return veisles.ElementAt(populiariausia).Key;

        }

        private Dictionary<string, int> SudarytiVeisliuDaznioSarasa()
        {
            var veisles = new Dictionary<string, Int32>();

            foreach (var suo in Sunys)
            {

                var veisles_kopija = new Dictionary<string, int>(veisles);

                int radau = 0;
                for (int i = 0; i < veisles.Count; i++)
                {
                    if (veisles.ElementAt(i).Key == suo.Veisle)
                    {
                        veisles_kopija[veisles_kopija.ElementAt(i).Key] = veisles.ElementAt(i).Value + 1;
                        radau = 1;
                    }

                }
                if (radau == 1)

                {

                    veisles = veisles_kopija;

                }
                else


                {
                    veisles.Add(suo.Veisle, 1);

                }


            }

            return veisles;
        }
    }
}
