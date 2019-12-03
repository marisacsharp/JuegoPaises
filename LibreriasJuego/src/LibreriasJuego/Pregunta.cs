using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Pregunta:IPregunta
    {

        internal Pregunta (IPartida partida, IPais pais)
        {
            this.Partida = partida;
            this.Pais = pais;
            this.IntentosRestantes = 3;
            this.RespuestasPropuestas = new List<string>();
            this.acierto = false;

        }
        public IPartida Partida { get; }
        public IPais Pais { get; }

        public bool proponerRespuesta(string capitalSugerida)
        {
            if (this.IntentosRestantes == 0)
            {
                throw new Exception("Ruinaca... NO te quedan intentos!");
            }
            this.RespuestasPropuestas.Add(capitalSugerida);
            this.IntentosRestantes--;
            this.acierto = (capitalSugerida == this.Pais.capital);
            return this.acierto;
            
        }

        public int IntentosRestantes { get; private set; }

        public List<string> RespuestasPropuestas { get; }

        public bool acierto { get; private set; }

    }
}
