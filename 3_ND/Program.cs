using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ND
{


    class Irasas

    {

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public Int64  Tel_numeris { get; set; }

        public Irasas(string Vardas, string Pavarde, Int64 Tel_numeris)
        {
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.Tel_numeris = Tel_numeris;

        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> Vardai = new List<string>();
            List<string> Pavardes = new List<string>();

            List<Irasas> Telefonu_knyga = new List<Irasas>();
            
            /* https://github.com/dominictarr/random-name */
            using (StreamReader reader = new StreamReader(@"C:\Users\darius.vainilavicius\Downloads\vardai\vard.txt"))


            {
                string line;

                while ((line = reader.ReadLine())!= null)
                {

                    Vardai.Add(line);

                }
                
            }

            /* https://github.com/dominictarr/random-name */
            using (StreamReader reader = new StreamReader(@"C:\Users\darius.vainilavicius\Downloads\vardai\pavard.txt"))


            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    Pavardes.Add(line);

                }

            }

            Random rnd = new Random();

            for (int i = 0; i < 100000; )
            {

                var temp_vardas = Vardai[rnd.Next(Vardai.Count)];
                var temp_pavarde = Pavardes[rnd.Next(Pavardes.Count)];

                Int64 temp_numeris = 5550000000 + rnd.Next(10000000);

                bool dublicate_found = false;

                foreach (var irasas in Telefonu_knyga)
                {
                    if ((temp_vardas == irasas.Vardas) &&
                            (temp_pavarde == irasas.Pavarde) &&
                            (temp_numeris == irasas.Tel_numeris))
                    {
                        dublicate_found = true;
                            break;
                    }                     


                }

                if (!dublicate_found)

                {

                    Telefonu_knyga.Add(new Irasas(temp_vardas, temp_pavarde, temp_numeris));
                    i++;


                }


            }


            Telefonu_knyga.Sort((x, y) => x.Pavarde.CompareTo(y.Pavarde));


            using (StreamWriter writer = new StreamWriter(@"C:\Users\darius.vainilavicius\Downloads\vardai\knyga.txt"))

            {

                foreach (var item in Telefonu_knyga)
                {

                    writer.WriteLine(item.Pavarde + " " + item.Vardas + " " + item.Tel_numeris);
                    writer.Flush();
                }



            }



        }
    }
}
