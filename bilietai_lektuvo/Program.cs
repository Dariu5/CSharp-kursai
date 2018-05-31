using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilietai_lektuvo
{
    class Program
    {

        struct Bilietas

        {
            public string From;
            public string To;

        }





        static void Main(string[] args)
        {

            var reader = new StreamReader("C-large-practice.in");

         //   string data = reader.ReadToEnd();

            int kiekKartoti = int.Parse(reader.ReadLine());

            for (int i = 0; i < kiekKartoti; i++)
            {

                int kiekBilietuyra = int.Parse(reader.ReadLine());

                Bilietas[] bilietu = new Bilietas[kiekBilietuyra];

                for (int j = 0; j< kiekBilietuyra; j++)
                {
                    bilietu[j].From = reader.ReadLine();
                    bilietu[j].To = reader.ReadLine();
                }

                Bilietas first = new Bilietas();


                for (int j = 0; j < kiekBilietuyra; j++)
                {
                    bool flag = true;

                    for (int k =0; k < kiekBilietuyra; k++)
                    {
                        if (bilietu[j].From == bilietu[k].To)
                        {
                            flag = false;
                            break;
                        }

                        if (flag)
                        {

                            first = bilietu[j];
                            break;
                        }
                    }

                    IList<Bilietas> bilietaiDarbinis = bilietu.ToList();
                    List<Bilietas> atsakymas = new List<Bilietas>();

                    bilietaiDarbinis.Remove(first);
                    while (bilietaiDarbinis.Count != 0)
                    {

                        foreach (var item in bilietaiDarbinis)
                        {

                            if (item.From == first.To)

                            {
                                first = item;
                                bilietaiDarbinis.Remove(first);
                                atsakymas.Add(first);
                                break;

                            }


                        }

                    }

                    foreach (var item in atsakymas)
                    {
                        Console.Write($" is {item.From} i {item.To} ");
                    }

                }

            }

        }
    }
}
