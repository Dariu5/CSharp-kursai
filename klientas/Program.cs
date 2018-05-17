using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klientas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Client> clients = new List<Client>

            {
                new VIP(1,"Jurgis Jurgaitis"),
                new Silver(2,"Petras Petraitis"),
                new Base(3,"Jonas Jonaitis")
            };


            foreach (var item in clients)
            {

                item.PaskaiciuotiSuma();
                Console.WriteLine(item.Full_name + " moketi reikia " + item.Moketina_suma);


            }



        }
    }
}
