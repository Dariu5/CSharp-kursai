using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbo_valandos = 8;

            Console.WriteLine("Iveskite info apie kepyklą:");
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą:");
            var kepalai_h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Darbuotojų skaičius:");
            var darbuotojai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kepalo savikaina:");
            var savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pardavimo kaina:");
            var kaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Užsakymai per dieną:");
            var uzsakymai = Convert.ToDouble(Console.ReadLine());


            var kepalai_dienai = darbo_valandos * kepalai_h * darbuotojai;

            Console.WriteLine("Kepalai per dieną:" + kepalai_dienai);

            var iskeptu_kepalu_savikaina = savikaina * kepalai_dienai;

            Console.WriteLine("Islaidos:" + iskeptu_kepalu_savikaina);

            if (uzsakymai > kepalai_dienai)
            {
                uzsakymai = kepalai_dienai;
            }

            var pajamos = uzsakymai * kaina;

            Console.WriteLine("Pajamos:" + pajamos);

            var pelnas = pajamos - iskeptu_kepalu_savikaina;

            Console.WriteLine("Pelnas:" + pelnas);


            if (kepalai_dienai >= uzsakymai)
            {
                Console.WriteLine("Spes ivykdyti uzakymus");
            }
            else Console.WriteLine("Pritruks {0} kepalu", uzsakymai-kepalai_dienai);


        }
    }
}
