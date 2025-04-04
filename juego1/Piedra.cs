using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego1
{

    internal class Piedra : jugada //hereda de la interfaz
    {
        public string url { get ; set ; } //Trae las imagenes

        public string ataque(string contricante) //Segun el parametro de contrincante se
        {
            if (contricante == "Piedra")
            {
                return "EMPATO";
            }

            else if (contricante == "Tijera")
            {
                return "GANA";
            }

            else
            {
                return "PIERDE";
            }
        }
    }
}
