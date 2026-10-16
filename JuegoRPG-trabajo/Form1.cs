using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JuegoRPG_trabajo
{
    public partial class Form1 : Form
    {
        public int turno = 0;

        Random aleatorio = new Random();


        public int pociones = 3;




        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            turno = 0;










        }

        private void buttoncrearpersonaje(object sender, EventArgs e)
        {

            int numero1 = 0;
            int numero2 = 0;


            numero1 = Convert.ToInt32(textboxAtaque.Text);
            numero2 = Convert.ToInt32(textboxVida.Text);


            nombreguerrero.Text = textboxNombre.Text;
            ataqueguerrero.Text = textboxAtaque.Text;
            vidaguerrero.Text = textboxVida.Text;

            if (nombreguerrero.Text == "-" || vidaguerrero.Text == "-" || ataqueguerrero.Text == "-")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de crear el personaje.");
                return;
            }

            if (textboxNombre.Text.Length > 15)
            {
                MessageBox.Show("El nombre del personaje no puede tener más de 15 caracteres.");
                nombreguerrero.Text = "";
                return;
            }

            if (numero1 < 1 || numero1 > 20)
            {
                MessageBox.Show("El valor de ataque debe estar entre 1 y 20.");
                ataqueguerrero.Text = "-";
                return;
            }

            if (numero2 < 1 || numero2 > 100)
            {
                MessageBox.Show("El valor de vida debe estar entre 1 y 100.");
                vidaguerrero.Text = "";
                return;
            }




        }

        private void button_orco(object sender, EventArgs e)
        {

            nombre_enemigo.Text = "orco";
            ataque_enemigo.Text = "9";
            vida_enemigo.Text = "100";





        }

        private void button_goblin(object sender, EventArgs e)
        {
            nombre_enemigo.Text = "goblin";
            ataque_enemigo.Text = "3";
            vida_enemigo.Text = "50";
        }

        private void button_asesino(object sender, EventArgs e)
        {
            nombre_enemigo.Text = "asesino";
            ataque_enemigo.Text = "12";
            vida_enemigo.Text = "75";
        }

        private void button_atacar_guerrero(object sender, EventArgs e)
        {
            if (vidaguerrero.Text == "0" || vida_enemigo.Text == "0")
            {
                MessageBox.Show("El combate ha terminado. No se puede atacar.");
                turno = 0;
                return;
            }

            if (nombreguerrero.Text == "-" && vidaguerrero.Text == "-" && ataqueguerrero.Text == "-")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de crear el personaje.");
                return;
            }


            if (nombre_enemigo.Text == "-" || vida_enemigo.Text == "-" || ataque_enemigo.Text == "-")
            {
                MessageBox.Show("Por favor, seleccione un enemigo antes de atacar.");
                return;
            }




            if (turno % 2 == 0 && nombre_enemigo.Text != "-" && nombreguerrero.Text != "-")
            {
                int vidaEnemigo = Convert.ToInt32(vida_enemigo.Text);
                int ataqueGuerrero = Convert.ToInt32(ataqueguerrero.Text);
                vidaEnemigo -= ataqueGuerrero;
                if (vidaEnemigo < 0)
                {
                    vidaEnemigo = 0;
                }
                vida_enemigo.Text = vidaEnemigo.ToString();
                turno = 1;
                return;
            }
            if (turno == 1)
            {
                MessageBox.Show("Es el turno del enemigo. No puedes atacar ahora.");
                return;
            }



        }

        private void button_atacar_enemigo(object sender, EventArgs e)
        {
            if (turno % 2 == 1 && vida_enemigo.Text != "0")
            {
                int ataqueEnemigo = Convert.ToInt32(ataque_enemigo.Text);
                int vidaGuerrero = Convert.ToInt32(vidaguerrero.Text);
                vidaGuerrero -= ataqueEnemigo;

                vidaguerrero.Text = vidaGuerrero.ToString();
                turno = 0;

                return;
            }

            if (nombre_enemigo.Text == "-" && vida_enemigo.Text == "-" && ataque_enemigo.Text == "-")
            {
                MessageBox.Show("Por favor, seleccione un enemigo antes de atacar.");
                return;
            }




            if (vidaguerrero.Text == "0" || vida_enemigo.Text == "0")
            {
                MessageBox.Show("El combate ha terminado. No se puede atacar.");
                turno = 0;
                return;
            }


            if (turno == 0)
            {
                MessageBox.Show("Es el turno del guerrero. No puedes atacar ahora.");
                return;
            }







        }

        private void button_mejorarguerrero(object sender, EventArgs e)
        {


            if (turno == 0 && vida_enemigo.Text == "0")
            {



                int opcion = aleatorio.Next(1, 4);


                int mejora = 10;

                if (opcion >= 2)
                {


                    int vidaGuerrero = Convert.ToInt32(vidaguerrero.Text);

                    vidaGuerrero = vidaGuerrero + mejora;

                    MessageBox.Show("Acaba de mejorar tu vida 10 puntos");

                    vidaguerrero.Text = vidaGuerrero.ToString();

                    turno = 1;

                    return;
                }
                if (opcion < 2)
                {

                    int ataqueGuerrero = Convert.ToInt32(ataqueguerrero.Text);
                    ataqueGuerrero = ataqueGuerrero + mejora;

                    MessageBox.Show("Acaba de mejorar tu ataque 10 puntos");

                    ataqueguerrero.Text = ataqueGuerrero.ToString();
                    turno = 1;

                    return;
                }

                return;


            }
            else
            {
                MessageBox.Show("No puedes mejorar el guerrero ahora.");
                return;
            }



        }

        private void button_posion_vida(object sender, EventArgs e)
        {

        }
    }
}
