using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> datos = new List<DateTime>()

            {   new DateTime(year: 1995, month: 12, day:02),
                new DateTime(year: 2000, month: 10, day: 02),
                new DateTime(year: 2018, month: 01, day: 02),
                new DateTime(year: 1996, month: 05, day: 15),
                new DateTime(year: 2018, month: 05, day: 23)
            };


            IEnumerable<DateTime> siandien = datos.Where(x => x == DateTime.Today);
            IEnumerable<DateTime> antraDiena = datos.Where(x => x.Day == 2);
            IEnumerable<DateTime> tarpas = datos.Where(x=> (x.Year>1990 && x.Year <2015)).OrderBy(x => x.Year);

        }
    }
}
