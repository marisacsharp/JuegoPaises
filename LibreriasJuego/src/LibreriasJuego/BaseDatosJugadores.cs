﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    interface BaseDatosJugadores
    {
        public Jugador nuevoJugador(string nombreJugador);

        public Jugador getJugador(string nombreJugador);

        public Jugador getOrCreateJugador(string nombreJugador);

        public List<Jugador> Jugadores { get; }


    }
}
