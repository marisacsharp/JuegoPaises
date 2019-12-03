using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IJugador
    {
        public string nombre { get; }

        public List<IPartida> HistoricoPartidas { get; }

        public IPartida nuevaPartida(IContinente continenteElegido);
        
    }
}
