using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaDeCafeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class VasoTests
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);
            bool resultado = vasosPequenos.hasVasos(1);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);
            bool resultado = vasosPequenos.hasVasos(2);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCantidadDeVaso()
        {
            Vaso vasosPequenos = new Vaso(5, 10);
            vasosPequenos.giveVasos(1);
            Assert.AreEqual(4, vasosPequenos.getCantidadVasos());
        }
    }
} 