using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komp_dalys
{
    class Kompiuteris
    {
        //prop
        //propg

        public string   Vaizduske { get; private set; }
        public string  Motinine { get; private set; }
        public int DiskoTalpa { get; private set; }

         public Kompiuteris(string vaizduske, string motinine, int diskotalpa)
        {
            Vaizduske = vaizduske;
            Motinine = motinine;
            DiskoTalpa = diskotalpa;

        }

        public Kompiuteris()
        {
                
        }
        
      
        public void Ivedimas()

        {
            Console.WriteLine("Vaizduske?");
            Vaizduske = Console.ReadLine();
            
            Console.WriteLine("Motinine?");
            Motinine = Console.ReadLine();

            Console.WriteLine("DiskoTalpa?");
            DiskoTalpa = Convert.ToInt16(Console.ReadLine());
            
        }


        public void Isvedimas()


        {
            Console.WriteLine("Vaizduske: " + Vaizduske);
            Console.WriteLine("Motinine: " + Motinine);
            Console.WriteLine("Disko talpa: " + DiskoTalpa);
        }


    }
}
