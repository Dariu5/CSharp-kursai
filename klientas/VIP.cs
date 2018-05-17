using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klientas
{
    class VIP: Client
    {



        public VIP(int ID, string FullName): base(ID, FullName)
        {

        }



        public override void PaskaiciuotiSuma()
        {

            Moketina_suma = 10 * 0.7;

        }

    }
}
