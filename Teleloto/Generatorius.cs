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

        int temp_index;

        public List<Eilute> Generuoti()

        {
            var rnd = new Random();
            List<Eilute> skaiciai = new List<Eilute>();


            var sar_M = generate_list(apatinis_rezis[0], virsutinis_rezis[0]);
            var sar_J = generate_list(apatinis_rezis[1], virsutinis_rezis[1]);
            var sar_R = generate_list(apatinis_rezis[2], virsutinis_rezis[2]);
            var sar_G = generate_list(apatinis_rezis[3], virsutinis_rezis[3]);
            var sar_Z = generate_list(apatinis_rezis[4], virsutinis_rezis[4]);

            
            for (int ii = 0; ii < 5; ii++)
            {



                for (int i = 0; i < apatinis_rezis.Length; i++)
                {

                    switch (i)
                    {

                        case 0:
                            temp_index = rnd.Next(0, sar_M.Count - 1);
                            temp_m = sar_M[temp_index];
                            sar_M.RemoveAt(temp_index);
                            break;
                        case 1:
                            temp_index = rnd.Next(0, sar_J.Count - 1);
                            temp_j = sar_J[temp_index];
                            sar_J.RemoveAt(temp_index);
                            break;
                        case 2:
                            temp_index = rnd.Next(0, sar_R.Count - 1);
                            temp_r = sar_R[temp_index];
                            sar_R.RemoveAt(temp_index);
                            break;
                        case 3:
                            temp_index = rnd.Next(0, sar_G.Count - 1);
                            temp_g = sar_G[temp_index];
                            sar_G.RemoveAt(temp_index);
                            break;
                        case 4:
                            temp_index = rnd.Next(0, sar_Z.Count - 1);
                            temp_z = sar_Z[temp_index];
                            sar_Z.RemoveAt(temp_index);
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



        List<int> generate_list(int start, int end)

        {
            List<int> sar = new List<int>();

            for (int i = start; i < end+1; i++)
            {

                sar.Add(i);


            }


            return sar;

        }

    }
}
