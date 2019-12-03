using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPre
    {
        [TestMethod]                
        
        public void TestRecuperarListaPartidas()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.nuevoJugador("ivan");
            Assert.IsNotNull(ivan.HistoricoPartidas);

        }

        public void TestNuevaPartida1()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");
            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            Assert.IsNotNull(partida);
        }
        public void TestNuevaPartida2()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");

            int cuantasLlevaba = ivan.HistoricoPartidas.Count;
            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);

            int cuantasLleva = ivan.HistoricoPartidas.Count;

            Assert.AreEqual(cuantasLlevaba+1, cuantasLleva);
            Assert.AreEqual(ivan.HistoricoPartidas[ivan.HistoricoPartidas.Count - 1], partida);


        }


    }
}
