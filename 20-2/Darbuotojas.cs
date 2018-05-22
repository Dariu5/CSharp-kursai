using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2
{
    class Darbuotojas
    {
        public string ID { get; set; }
        public string Vardas { get; set; }
        public string  Pavarde { get; set; }
        public DateTime Giminodata { get; set; }
        public double Alga { get; set; }
        public int Dirbalaiko { get; set; }


        public Darbuotojas(string ID, string Vardas, string Pavarde, DateTime Gimimodata, double Alga,int Dirbalaiko)
        {
            this.ID = ID;
            this.Vardas = Vardas;
            this.Pavarde = Pavarde;
            this.Giminodata = Gimimodata;
            this.Alga = Alga;
            this.Dirbalaiko = Dirbalaiko;
            
            
            
        }


    }
}
