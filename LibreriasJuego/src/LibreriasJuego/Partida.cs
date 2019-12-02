using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    interface Partida
    {
        public Jugador Jugador{get; }
        public Continente Continente { get; }
        public List<Pregunta> HistoricoPreguntas { get; }

        public Pregunta nuevaPregunta();


    }
}
