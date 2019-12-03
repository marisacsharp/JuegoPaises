using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Partida:IPartida
    {

        static Random generadorAleatorio = new Random();

        internal Partida(IJugador jugador, IContinente continente)
        {
            this.Jugador = jugador;
            this.Continente = continente;
            this.HistoricoPreguntas = new List<IPregunta>();
        }

        public IJugador Jugador { get; }
        public IContinente Continente { get; }
        public IList<IPregunta> HistoricoPreguntas { get; }

        public IPregunta nuevaPregunta()
        {
            IPais pais = null;
            int total = this.Continente.paises.Count;
            double numeritoAleatorio = Partida.generadorAleatorio.NextDouble();
            int elElegido = (int)(numeritoAleatorio*total);
            pais = this.Continente.paises[elElegido];

            IPregunta p = new Pregunta(this, pais);
            HistoricoPreguntas.Add(p);
            return p;
        }


    }
}
