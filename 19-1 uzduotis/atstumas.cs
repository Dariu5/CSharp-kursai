using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_uzduotis
{
    class atstumas
    {





        static public double Skaiciuoti_atstuma(int x1, int x2, int y1, int y2)

        {

            return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
            
        }



        static public bool  Ar_patenka(int x1, int x2, int y1, int y2, int r)

        {



            if (r > Skaiciuoti_atstuma(x1,x2, y1, y2))
            {
                return true;
            }
            else return false;

        }



    }
}
