using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    interface Jugador
    {
        public string nombre { get; }

        public List<Partida> HistoricoPartidas { get; }

        public Partida nuevaPartida(Continente continenteElegido);
        
    }
}
