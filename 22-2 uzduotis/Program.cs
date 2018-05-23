using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_2_uzduotis
{
    class Program
    {


       

        static void Main(string[] args)
        {

            

            List<Zmogus> Zmogai = new List<Zmogus>();


            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\darius.vainilavicius\Documents\zmogai.txt");

            string line;

            while ((line = reader.ReadLine())!= null)
            {

                string[] data = line.Split(' ');

                Zmogai.Add(new Zmogus(data[0], int.Parse(data[1])));

            }


            Action<string, int> sarasasmetodu = TikrnameArVaikas;
            sarasasmetodu += TikrnameArSenolis;
            sarasasmetodu += TikrnameArSuauges;




            foreach (var item in Zmogai)
            {
                item.AmziausGrupesNustatymas(sarasasmetodu);

            }


        }

        static void TikrnameArVaikas(string Name, int Age)

        {
            if (Age <18)
                Console.WriteLine(Name + " yra vaikas");

        }

        static void TikrnameArSenolis(string Name, int Age)

        {
            if (Age >= 65)
                Console.WriteLine(Name + " yra senolis");

        }

        static void TikrnameArSuauges(string Name, int Age)

        {
            if (Age >= 18 && Age <65)
                Console.WriteLine(Name + " yra suauges");

        }
    }
}
