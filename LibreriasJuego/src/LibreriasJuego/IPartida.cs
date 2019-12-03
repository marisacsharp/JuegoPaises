using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IPartida
    {

        public IJugador Jugador{get; }
        public IContinente Continente { get; }
        public IList<IPregunta> HistoricoPreguntas { get; }

        public IPregunta nuevaPregunta();


    }
}
