using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    interface Pregunta
    {
        public Partida Partida { get; }
        public Pais Pais(get;)

        public bool proponerRespuesta(string capitalSugerida);

        public int IntentosRestantes { get; }

        public List<string> RespuestasPropuestas { get; }

        public bool acierto { get; }

    }
}
