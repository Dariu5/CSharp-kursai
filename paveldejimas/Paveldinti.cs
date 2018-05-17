using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paveldejimas
{
    class Paveldinti :Alkoholis
    {
        public string Rusis { get;}
        public string KilmesSalis { get;}

        public Paveldinti(double Laipsniai, int Turis, string Spalva, string Rusis, string KilmesSalis)
            :base(Laipsniai,Turis,Spalva)
        {
            this.Rusis = Rusis;
            this.KilmesSalis = KilmesSalis;


        }

        public Paveldinti()
        {

        }

    }
}
