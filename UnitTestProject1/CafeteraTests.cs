using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaDeCafeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class CafeteraTests
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadDeCafe());
        }
    }
} 