using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_testavimas
{
    public class Siuntimas : ISiuntimas

    {
        public bool IsShipped { get; }
        public int SiuntosSkaiciuotuvas()

        {
            if (IsShipped == false)
                throw new Exception("Siunta jau išsiųsta");
            //Do something

            return 20;
        }

        public Siuntimas(bool IsShipped)
        {
            this.IsShipped = IsShipped;
        }
    }

    public interface ISiuntimas
    {
        bool IsShipped { get; }
        int SiuntosSkaiciuotuvas();


    }

   public class Uzsakymas
    {
        public int Kaina { get; set; }
        public ISiuntimas Siunta { get; set; }
        public string Klientas { get; set; }

        public void ProcessOrder()

        {
            Kaina = Siunta.SiuntosSkaiciuotuvas() + 20;



        }

        public Uzsakymas(ISiuntimas Siunta)
        {
            this.Siunta = Siunta;
        }
    }
}
