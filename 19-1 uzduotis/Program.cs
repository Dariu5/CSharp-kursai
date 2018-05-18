using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_uzduotis
{

    class Point

    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    

    class Program
    {




        static void Main(string[] args)
        {

           int x1 = 0;
           int y1 = 0;
           int r= 5;

            List<Point> masyvas = new List<Point>();

            Random rng = new Random();

            for (int i = 0; i < 10; i++)
            {
                masyvas.Add(new Point(rng.Next(-10,10), rng.Next(-10, 10)));
            }




            foreach (var item in masyvas)
            {


                if  ( atstumas.Ar_patenka(x1, item.Key, y1, item.Value, r))

                {

                    Console.WriteLine("Patenka nors vienas");
                    break;
                        }

            }

            Console.WriteLine("Nepatenka nei vienas");
        }
    }
}
