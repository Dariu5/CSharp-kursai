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
                    new Suo ("pirmas",25,"Petras"),
                    new Suo ("antras",5,"Vokietis"),
                    new Suo ("trecias",2,"Vokietis"),
                    new Suo ("penktas",2,"Antanas"),
                });

            prieglauda.Isvedimas();
            prieglauda.Checkin();
            prieglauda.Isvedimas();

            Console.WriteLine("vyriausas suo: ");
            prieglauda.VyriausiasSuo().Isvedimas();


            Console.WriteLine("jauniausias suo: ");
            prieglauda.JauniausiasSuo().Isvedimas();


            Console.WriteLine("Populairiausia veisle: " + prieglauda.Populiariausia_veisle());

        }
    }
}
