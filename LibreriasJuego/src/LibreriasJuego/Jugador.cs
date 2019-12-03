using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Jugador: IJugador
    {
        internal Jugador(string nombre)
        {
            this.nombre = nombre;
            this.HistoricoPartidas = new List<IPartida>();

        }
        public string nombre { get; }

        public List<IPartida> HistoricoPartidas { get; }

        public IPartida nuevaPartida(IContinente continenteElegido)
        {
            Partida p = new Partida(this, continenteElegido);
            this.HistoricoPartidas.Add(p);
            return p;
        }
        
    }
}
