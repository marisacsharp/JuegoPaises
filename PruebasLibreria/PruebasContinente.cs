using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinente
    {
        [TestMethod]
        public void TestEspa�a_capital()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");

        }

        public void TestEuropa_nombre()
        {
            /*
            Pais espa�a = null;
            */
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");           
            Assert.AreEqual(europa.nombre, "Europa");

        }

        public void TestEuropa_espa�a()
        {
            
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;            
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais espa�a = europa.getPais("Espa�a");
            Assert.IsNotNull(espa�a);
        }

        public void TestEuropa_Nueva_Zelanda()
        {

            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.IsNotNull(nuevaZelanda);
        }
    }
}
