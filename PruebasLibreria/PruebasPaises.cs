using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_capital()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");

        }

        public void TestEspa�a_nombre()
        {
            /*
            Pais espa�a = null;
            */
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
           
            Assert.AreEqual(espa�a.nombre, "Espa�a");

        }

        public void TestEspa�a_continente()
        {
            IPais espa�a = null;
            IContinente europa = null;

            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            espa�a = miBaseDatosGeografica.getPais("Espa�a");
            europa = miBaseDatosGeografica.getContinente("Europa");

            Assert.AreEqual(espa�a.continente, europa);

        }
    }
}
