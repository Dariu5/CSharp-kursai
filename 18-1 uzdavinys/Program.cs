using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_uzdavinys
{
    public interface Ipoint

    {
        int x { get; }
        int y { get; }

        void Draw();

    }


    class Taskas : Ipoint

    {
        public int x { get; }
        public int y { get; }

        public void Draw()

        {

            Console.WriteLine("Brezia apskritima");

        }
        

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
