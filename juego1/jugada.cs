using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego1
{
    internal interface jugada
    {
        //Almacenado de las imagenes
        public string url { get; set; }
        String ataque(String contricante);
        

        
    }
}
