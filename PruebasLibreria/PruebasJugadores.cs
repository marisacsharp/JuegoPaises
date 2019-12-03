using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugadores
    {
        [TestMethod]
        


        
        //Prueba de alta
        //Prueba de recuperacion
        //Prueba de nombre


        public void TestAltaJugador()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.nuevoJugador("ivan");
            Assert.IsNotNull(ivan);

        }

        public void TestAltaRecuperacionJugador()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");
            Assert.IsNotNull(ivan);
        }
        public void TestNombreJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("pepe");
            Assert.AreEqual(pepe.nombre, "pepe");
        }

    }
}
