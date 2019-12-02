using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    interface BaseDatosGeografica
    {
       

        public Jugador getContinente(string nombreContinente);

        

        public List<Continente> getContinentes();


    }
}
