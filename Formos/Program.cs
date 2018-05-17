using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formos
{
    public abstract class Figura
    {

        public abstract double Plotas();

    }

   

class Trikampis: Figura

{

        public int A { get; set; }
        public int B { get; set; }

    public override double Plotas()
    {

        return (A * B * 0.5);
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
}