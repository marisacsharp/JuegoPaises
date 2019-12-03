using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspaña_capital()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");

        }

        public void TestEspaña_nombre()
        {
            /*
            Pais españa = null;
            */
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
           
            Assert.AreEqual(españa.nombre, "España");

        }

        public void TestEspaña_continente()
        {
            IPais españa = null;
            IContinente europa = null;

            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            españa = miBaseDatosGeografica.getPais("España");
            europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.AreEqual(españa.continente, europa);

        }
    }
}
