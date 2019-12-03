using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPregunta
    {
        public IPartida Partida { get; }
        public IPais Pais { get; }

        public bool proponerRespuesta(string capitalSugerida);

        public int IntentosRestantes { get; }

        public List<string> RespuestasPropuestas { get; }

        public bool acierto { get; }

    }
}
