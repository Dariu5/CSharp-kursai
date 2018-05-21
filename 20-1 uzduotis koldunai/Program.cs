using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_1_uzduotis_koldunai
{

    public class Dalyvis

    {
        public string Vardas { get; }
        public int Kiekis { get; }
        public int Riba { get; }
        public int Diskvalifikuotas { get; set; }

        public Dalyvis(string Vardas, int Kiekis, int Riba)
        {
            this.Vardas = Vardas;
            this.Kiekis = Kiekis;
            this.Riba = Riba;
        }

     }



    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {


            int laikas = 1;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath;

            }

            System.IO.StreamReader reader = new System.IO.StreamReader(path + "//dalyviai.csv");

            string line;


            List<Dalyvis> dalyviai = new List<Dalyvis>();



            while ((line = reader.ReadLine()) != null)
            {

                try
                {
                    string[] data = line.Split(';');

                    Dalyvis dalyvis = new Dalyvis(data[0], int.Parse(data[1]), int.Parse(data[2]));


                    if (dalyvis.Kiekis > dalyvis.Riba)
                        throw new PersivalgeKodunuException(dalyvis.Kiekis);
                    dalyviai.Add(new Dalyvis(data[0], int.Parse(data[1]), int.Parse(data[2])));

                }
                catch (Exception)
                {
                    Console.WriteLine("Persivalge");
                }




            }


            double max = double.MinValue;

            Dalyvis max_dalyvis = new Dalyvis(null, 0, 0);

            foreach (var item in dalyviai)
            {

                Console.WriteLine("{0} valgymo greitis: {1}", item.Vardas, ((double)item.Kiekis / laikas).ToString());

                if (item.Kiekis > max)
                {
                    max = item.Kiekis;
                    max_dalyvis = item;

                }



            }
            Console.WriteLine("laimejo {0}, suvalges {1}", max_dalyvis.Vardas, max_dalyvis.Kiekis.ToString());




        }


    }       

        class PersivalgeKodunuException : Exception

        {

            public int KiekSuvalge { get; set; }

            public PersivalgeKodunuException(int KiekSuvalge)
            {

                this.KiekSuvalge = KiekSuvalge;
            }
        }

   
}