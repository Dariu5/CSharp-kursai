using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4_ND
{

    class Zmogus

    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }

        public Zmogus(string Vardas, int Amzius)
        {
            this.Amzius = Amzius;
            this.Vardas = Vardas;
        }


       public  string Statusas()

        {

            if (Amzius < 18)
                return "Vaikas";
            else if (Amzius > 65)
                return "Pensininkas";
            else throw new System.ArgumentException(Vardas + " amzius yra ne ribose"); 

        }

    }



    class Program
    {
        static void Main(string[] args)
        {


            List<Zmogus> Zmogai = new List<Zmogus>();


            using (System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\darius.vainilavicius\Documents\sarasas_amzius.txt"))


            {
                string line;
                try

                {
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] data = line.Split(' ');

                        Zmogai.Add(new Zmogus(data[0], int.Parse(data[1])));

                    }
                }
                catch (Exception e)

                {
                    MessageBox.Show("Blogai pateikti duomenys, tikrinti txt");
                }

            }

            
                foreach (var item in Zmogai)
                {
                try
                {
                    Console.WriteLine(item.Vardas + " yra " + item.Statusas());
                }

                catch (Exception e)
                {


                    MessageBox.Show(e.Message);

                }


            }



        }
    }
}
