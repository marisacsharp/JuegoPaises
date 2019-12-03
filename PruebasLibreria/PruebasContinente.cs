using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinente
    {
        [TestMethod]
        public void TestEspaña_capital()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");

        }

        public void TestEuropa_nombre()
        {
            /*
            Pais españa = null;
            */
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");           
            Assert.AreEqual(europa.nombre, "Europa");

        }

        public void TestEuropa_españa()
        {
            
            IBaseDatosGeografica miBaseDatosGeografica =
               Juego.dameElJuego().baseDatosGeografica;            
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
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
