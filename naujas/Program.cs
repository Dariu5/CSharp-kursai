using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naujas
{
    class Program
    {
        static void Main(string[] args)
        {


            var programa = new Program(); // objektas

            

            programa.Pasisveikinti(programa.VartotojoVardas(),programa.VartotojoAmzius());

        }

        public void Pasisveikinti (string vardas, int amzius)


        {

            Console.WriteLine("Sveiki," + vardas + " " + amzius);



        }


        public string VartotojoVardas()

        {

            Console.WriteLine("Vardas?");

            return Console.ReadLine();


        }


        public int VartotojoAmzius()


        {
            Console.WriteLine("Amzius?");
            return Convert.ToInt32(Console.ReadLine());


        }







    }
}
