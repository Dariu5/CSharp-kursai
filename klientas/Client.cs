using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klientas
{
    class Client
    {


        public int ID { get;}
        public string Full_name { get; set; }
        public double Pradine_suma { get; protected set; }
        public double Moketina_suma { get; protected set; }



        public Client( int ID, String FullName )
        {
            this.ID = ID;
            this.Full_name = Full_name;
        }



        public  virtual void PaskaiciuotiSuma()

        {

            Moketina_suma  = 10*1;
        }

    }
}
