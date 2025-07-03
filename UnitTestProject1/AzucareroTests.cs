using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaDeCafeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class AzucareroTests
    {
        private Azucarero azucarero;

        [TestInitialize]
        public void Setup()
        {
            azucarero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzucarero()
        {
            bool resultado = azucarero.hasAzucar(5);
            Assert.IsTrue(resultado);
            resultado = azucarero.hasAzucar(10);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzucarero()
        {
            bool resultado = azucarero.hasAzucar(15);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azucarero.giveAzucar(5);
            Assert.AreEqual(5, azucarero.getCantidadDeAzucar());
            azucarero.giveAzucar(2);
            Assert.AreEqual(3, azucarero.getCantidadDeAzucar());
        }
    }
} 