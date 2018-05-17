using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klientas
{
    class Silver :Client
    {
        public Silver(int ID, string FullName) : base(ID, FullName)
        {

        }


        public override void PaskaiciuotiSuma()
        {

            Moketina_suma = 10 * 0.9;

        }
    }
}
