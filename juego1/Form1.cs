using Microsoft.VisualBasic.ApplicationServices;

namespace juego1
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string> { "Piedra", "Papel", "Tijera" };    
        
        public  Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PAPEL

            //Se importa desde la carpeta de recursos del proyecto
            jugador1.Image = Properties.Resources.papel;

            //Creacion funcion random
            Random accion= new Random();
            //Que numero saca la funcion random
            int numero_Random= accion.Next(0,3);
            //Lo saca segun el indice de la lista
            jugada Papel = gameFactory.CrearGame(list.ElementAt(1)); //Se elije el elemento donde esta guardada la logica de ese objeto segun la lista
            //Logica del rival para la imagen
            jugada Rival = gameFactory.CrearGame(list.ElementAt(numero_Random));
            jugador2.ImageLocation=Rival.url;

            //Resultado
            MessageBox.Show(("entro " + list.ElementAt(numero_Random) + Papel.ataque(list.ElementAt(numero_Random)))); 
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            //PIEDRA

            //Se importa directamente desde el pc con el path
            jugador1.Image = Image.FromFile(@"C:\Users\Juan Gómez\Downloads\juego\piedra.gif");

            //juego
            Random accion = new Random();
            int numero_Random = accion.Next(0, 3);
            jugada Piedra = gameFactory.CrearGame(list.ElementAt(0));
            MessageBox.Show(("entro " + list.ElementAt(numero_Random) + Piedra.ataque(list.ElementAt(numero_Random))));

            jugada Rival = gameFactory.CrearGame(list.ElementAt(numero_Random));
            jugador2.ImageLocation = Rival.url;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Tijera
            jugador1.Image = Properties.Resources.tijera;

            //Juego
            Random accion = new Random();
            int numero_Random = accion.Next(0, 3);
            jugada Tijera = gameFactory.CrearGame(list.ElementAt(2));
            MessageBox.Show(("entro " + list.ElementAt(numero_Random) + Tijera.ataque(list.ElementAt(numero_Random))));

            jugada Rival = gameFactory.CrearGame(list.ElementAt(numero_Random));
            jugador2.ImageLocation = Rival.url;
        }
    }
}
