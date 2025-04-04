using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego1
{
    internal class gameFactory
    {
        public static jugada CrearGame(string eleccion)
        {
            switch (eleccion)
            {
                case "Piedra":return new Piedra { url = "C:\\Users\\Juan Gómez\\Downloads\\juego\\piedra.gif" }; //Creacion de objeto 
                    

                case "Tijera":return new Tijera { url = "C:\\Users\\Juan Gómez\\Downloads\\juego\\tijera.gif" };
                    //No se usa el break porque el return finaliza esa accion

                case "Papel":return new Papel { url = "C:\\Users\\Juan Gómez\\Downloads\\juego\\papel.gif" };
                    

                default:
                     throw new ArgumentException("Error en la jugada"); //Traer una excepcion
                

            }
        }
    }
}

