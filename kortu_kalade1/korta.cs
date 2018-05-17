using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortu_kalade1
{
    class korta
    {

        public string Zenklas { get; }
        public string Skaicius { get; }
        
        

        public korta(string zenklas, string skaicius)
        {

            Zenklas = zenklas;
            Skaicius = skaicius;

        }


        public void Isvesti()

        {

            Console.WriteLine(Zenklas + Skaicius);


        }




    }
}
