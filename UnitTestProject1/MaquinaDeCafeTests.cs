using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaDeCafeApp;

namespace UnitTestProject1
{
    [TestClass]
    public class MaquinaDeCafeTests
    {
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;
        private MaquinaDeCafeApp.MaquinaDeCafe maquinaDeCafe;

        [TestInitialize]
        public void Setup()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);
            maquinaDeCafe = new MaquinaDeCafeApp.MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasosPequeno);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            Assert.AreEqual(maquinaDeCafe.getVasosPequeno(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinaDeCafe.getVasosMediano(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinaDeCafe.getVasosGrande(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayCafe()
        {
            Cafetera cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay Cafe", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayAzucar()
        {
            Azucarero azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getCafetera().getCantidadDeCafe();
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getVasosPequeno().getCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
} 