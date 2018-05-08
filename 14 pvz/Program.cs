using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_pvz
{

    class Automobilis
    {
        //public AbcAbs -pascal case
        //private _abcAbc - camel case
        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string ValstybinisNumeris;
        
        //abcAbs
        public Automobilis(int gimimoMetai, string spalva, string marke, string vin, string valstybinisnumeris) //ctor
        {
            GimimoMetai = gimimoMetai;
            Spalva = spalva;
            Marke = marke;
            VIN = vin;
            ValstybinisNumeris = vin;
        }

        public Automobilis()
        {

        }



        public void isvedimas()

        {

            Console.WriteLine("Marke {0} Spalva {1} Metai {2} VIN {3} Numeris {4}",Marke,Spalva,GimimoMetai,VIN,ValstybinisNumeris);



        }
    }







    class Program
    {
        static void Main(string[] args)
        {

            var auto = new Automobilis(); //objektas
            auto.GimimoMetai = 1990;
            auto.Spalva = "Ruda";
            Console.WriteLine(auto.Spalva);

            var auto2 = new Automobilis()

            {

               GimimoMetai = 447,
               Spalva = "juoda",
               Marke = "Audi",
            };

            var auto3 = new Automobilis(1997, "juoda", "bb", "dfefefeff", "ABB132");

            var auto4 = new Automobilis(spalva: "aaaa" , gimimoMetai: 874, marke: "VVV", valstybinisnumeris: "AAA888", vin: "74414");


            auto4.isvedimas();
            auto2.isvedimas();
            auto3.isvedimas();
                

        }
    }
}
