using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleloto
{
    class Generatorius
    {

       public List<Eilute> Eilutes;

        int[] apatinis_rezis = new int[] { 1, 16, 31, 46, 61 };
        int[] virsutinis_rezis = new int[] { 15, 30, 45, 60, 75 };


        public Generatorius()
        {
             Eilutes = Generuoti();


        }
     

        int temp_m;
        int temp_j;
        int temp_r;
        int temp_g;
        int temp_z;

        public List<Eilute> Generuoti()

        {
            var rnd = new Random();
            List<Eilute> skaiciai = new List<Eilute>();

          

            for (int ii = 0; ii < 5; ii++)
            {



                for (int i = 0; i < apatinis_rezis.Length; i++)
                {

                    switch (i)
                    {

                        case 0:
                            temp_m = rnd.Next(apatinis_rezis[i], virsutinis_rezis[i]);
                            break;
                        case 1:
                            temp_j = rnd.Next(apatinis_rezis[i], virsutinis_rezis[i]);
                            break;
                        case 2:
                            temp_r = rnd.Next(apatinis_rezis[i], virsutinis_rezis[i]);
                            break;
                        case 3:
                            temp_g = rnd.Next(apatinis_rezis[i], virsutinis_rezis[i]);
                            break;
                        case 4:
                            temp_z = rnd.Next(apatinis_rezis[i], virsutinis_rezis[i]);
                            break;
                        default:
                            break;
                    }


                   

                }

                Eilute eile = new Eilute(temp_m, temp_j, temp_r, temp_g, temp_z);

                skaiciai.Add(eile);

            }
            return skaiciai;
        }

    }
}
