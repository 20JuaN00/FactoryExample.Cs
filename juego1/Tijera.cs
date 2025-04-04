using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego1
{
    internal class Tijera : jugada
    {

        public string url { get; set; }

        public string ataque(string contricante)
        {
            if (contricante == "Tijera")
            {
                return "EMPATO";
            }

            else if (contricante == "Papel")
            {
                return "GANO";
            }

            else
            {
                return "PERDIO";
            }
        }
    }
}

