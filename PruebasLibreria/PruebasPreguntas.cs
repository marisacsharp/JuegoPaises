using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {
        [TestMethod]
        


        
        
        public void TestNuevaPregunta()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.Pais);
            

        }


        public void TestRespuestaFallida()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);            

        }

        public void TestRespuestasFallidas()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            int intentos = pregunta.IntentosRestantes;
            Assert.AreEqual(intentos, 3);

            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");

            intentos = pregunta.IntentosRestantes;
            Assert.AreEqual(intentos, 0);
            
        }

        public void TestRespuestaCorrecta()
        {
            IBaseDatosJugadores miBbaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = miBbaseDatosJugadores.getOrCreateJugador("ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();

            bool resultado = pregunta.proponerRespuesta(pregunta.Pais.capital);
            Assert.IsTrue(resultado);

        }


    }
}
