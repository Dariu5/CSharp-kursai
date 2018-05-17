using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _18_2_testavimas;

namespace Unit_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof(Exception))]
        public void ProcessOrder_SiuntaJauIsiusta_Throwexception()
        {
            Uzsakymas uzsakymas = new Uzsakymas(
                new Siuntimas(false)
                );
             uzsakymas.ProcessOrder();
        }

        [TestMethod]
        public void ProcessOrder_siunta_darnesiusta_gausime4()

        {

            Uzsakymas uzsakymas = new Uzsakymas(new FakeSiunta());
            uzsakymas.ProcessOrder();
            Assert.AreEqual(uzsakymas.Kaina, 24);


        }
    }

    class FakeSiunta : ISiuntimas

    {

        public bool IsShipped { get; }
        public int SiuntosSkaiciuotuvas()

        {

            return 4;

        }
    }

}
