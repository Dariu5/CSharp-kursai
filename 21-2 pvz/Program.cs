using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_pvz
{
    class Program
    {
        /*
        public delegate void Action();
        public delegate void Action<T>(T arg);

        public delegate T Func<T>();
        public delegate T Func<T, K>(K arg);
       */ 


        static void Main(string[] args)
        {
            Photo photo = new Photo();

            Action virt = RemoveRedeye;
            Action<int, int> math = Add;

            Func<string> pavyzdys = A;
            Func<int, string> pvz = B;

            string result = pavyzdys();
            string res = pvz(1);
            PhotoFiltras filtras = new PhotoFiltras();

            photo.ApplyFilter(filtras.GraysScale);
            photo.ApplyFilter(RemoveRedeye);
        }

        static string A()

        {


            return "A";

        }

        static string B(int K)

        {


            return "B";
        }




        static void Add(int a, int b)

        {


        }


        static void RemoveRedeye()

        {

            Console.WriteLine("Pridedamas red filtas");

        }
    }
}
