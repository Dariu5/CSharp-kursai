using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_2_uzduotis
{
    class SkirtingiTipai<T, K,A> where T:IEnumerable<int> where A:Program
    {

   public List<T> vienasTipas { get; set; }
   public List<T> antrasTipas { get; set; }
   public List<T> treciasTipas { get; set; }
    }



    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            string path = null;

            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath;

            }

            System.IO.StreamReader reader = new System.IO.StreamReader(path + "//data.csv");

            string line;

            List<List<int>> sarasas = new List<List<int>>();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(';');
                List<int> tempData = new List<int>();

                foreach (var item in data)

                {
                    tempData.Add(int.Parse(item));

                }

                sarasas.Add(tempData);
            }


            foreach (var item in sarasas)

            {
                Console.WriteLine("mokinio vidurkis yra{0:0.00}" , item.Average());


            }


            var laikinoji_kopija = sarasas.ToArray();

            for (int i = 0; i < laikinoji_kopija[0].Count; i++)
            {


                int suma = 0;
                for (int j = 0; j < laikinoji_kopija.Length; j++)
                {
                    if (laikinoji_kopija[j].Count > i)
                        suma += laikinoji_kopija[j].ElementAt(i);
                   
                }

                Console.WriteLine("Kontrolinio vidurkis yra {0:0.00}", (double)suma / laikinoji_kopija.Length);
            }


            /*
        for (int i = 0; i < sarasas.Count; i++)
        {
            int suma = 0;
            foreach (var item in sarasas)

            {
                suma += item.ElementAt(i);

            }

            Console.WriteLine("Kontrolinio vidurkis yra {0:0.00}" , (double)suma / sarasas.Count());

        }

*/



            List<List<int>> surikiuotaInformacija = new List<List<int>>();
            while (sarasas.Count != 0)
            {
                double max = double.MinValue;
                List<int> maxMember = new List<int>();

                foreach (var item in sarasas)
                {

                    if (max < item.Average())
                    {

                        max = item.Average();
                        maxMember = item;

                    }

                }
                surikiuotaInformacija.Add(maxMember);
                sarasas.Remove(maxMember);

            }


            foreach (var item in surikiuotaInformacija)
            {
                Console.WriteLine("Mokinio vidurkis {0} ", item.Average());
            }



            List<SkirtingiTipai<IEnumerable<int>, string,Program>> kazkas = new List<SkirtingiTipai<IEnumerable<int>, string, Program>>();

        }
    }
}
