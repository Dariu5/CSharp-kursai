using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_22_uzduotis
{
    class Ivykis
    {

        public delegate void IvikisEventHandler(object sender, EventArgs eventArgs); /*Kontraktas*/
        public event IvikisEventHandler IvikisDone;


        public void Procesas()

        {

            Console.WriteLine("Procesas done");
            OnIvikisDone();

        }
        



        protected virtual void OnIvikisDone()
        {

            if (IvikisDone != null)
            {

                IvikisDone(this, EventArgs.Empty);

            }

        }

    }
}
