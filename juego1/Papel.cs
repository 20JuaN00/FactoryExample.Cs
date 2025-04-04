using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego1
{
    internal class Papel : jugada

    {
        public string url { get; set; }

        public string ataque(string contricante)
        {
            if (contricante == "Papel")
            {
                return "EMPATO";
            }

            else if (contricante == "Piedra")
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

