using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_Sarase
{
    class Program
    {
        static void Main(string[] args)
        {

            var prieglauda = new Prieglauda("Penkta koja", "aaa bbb 5",
                new List<Suo>
                {
                    new Suo ("pirmas",25,"Vokietis"),
                    new Suo ("antras",5,"amsas"),
                    new Suo ("trecias",2,"pemsas"),




                });

            prieglauda.Isvedimas();
                

        }
    }
}
