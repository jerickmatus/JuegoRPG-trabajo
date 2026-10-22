using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JuegoRPG_trabajo
{
    public partial class Form1 : Form
    {
        Guerrero? jugador;
        Enemigo? enemigo;
        bool turnoJugador = true;
        bool recompensaReclamada = false;
        bool mejoraUsada = false;

        Random aleatorio = new Random();


        private void ActualizarPantalla()
        {
            if (jugador != null)
            {
                nombreguerrero.Text = jugador.Nombre;
                vidaguerrero.Text = jugador.Vida.ToString();
                ataqueguerrero.Text = jugador.Ataque.ToString();
                pocionesvida.Text = jugador.PocionesVida.ToString();
                pocionesveneno.Text = jugador.PocionesVeneno.ToString();
                cantidaddinero.Text = jugador.Dinero.ToString();
            }
            if (enemigo != null)
            {
                nombre_enemigo.Text = enemigo.Nombre;
                vida_enemigo.Text = enemigo.Vida.ToString();
                ataque_enemigo.Text = enemigo.Ataque.ToString();
            }
        }
        private DatosPartida CrearDatos()
        {
            var d = new DatosPartida
            {
                TurnoJugador = turnoJugador,
                RecompensaReclamada = recompensaReclamada,
                MejoraUsada = mejoraUsada
            };

            if (jugador != null)
            {
                d.Nombre = jugador.Nombre;
                d.Vida = jugador.Vida;
                d.VidaMaxima = jugador.VidaMaxima;
                d.Ataque = jugador.Ataque;
                d.Dinero = jugador.Dinero;
                d.PocionesVida = jugador.PocionesVida;
                d.PocionesVeneno = jugador.PocionesVeneno;
            }

            if (enemigo != null)
            {
                d.HayEnemigo = true;
                d.EnemigoNombre = enemigo.Nombre;
                d.EnemigoVida = enemigo.Vida;
                d.EnemigoVidaMaxima = enemigo.VidaMaxima;
                d.EnemigoAtaque = enemigo.Ataque;
                d.EnemigoRecompensa = enemigo.Recompensa;
                d.EnemigoTurnosVeneno = enemigo.TurnosVeneno;
            }
            return d;
        }

        private void AplicarDatos(DatosPartida d)
        {
            jugador = new Guerrero(d.Nombre, d.VidaMaxima, d.Ataque)
            {
                Vida = d.Vida,
                Dinero = d.Dinero,
                PocionesVida = d.PocionesVida,
                PocionesVeneno = d.PocionesVeneno
            };

            if (d.HayEnemigo)
            {
                enemigo = new Enemigo(d.EnemigoNombre, d.EnemigoVidaMaxima, d.EnemigoAtaque, d.EnemigoRecompensa)
                {
                    Vida = d.EnemigoVida,
                    TurnosVeneno = d.EnemigoTurnosVeneno
                };

            }

            turnoJugador = d.TurnoJugador;
            recompensaReclamada = d.RecompensaReclamada;
            mejoraUsada = d.MejoraUsada;
            ActualizarPantalla();
        }

        public Form1() : this(null) { }

        public Form1(DatosPartida? datos)
        {
            InitializeComponent();
            if (datos != null) AplicarDatos(datos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void buttoncrearpersonaje(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxNombre.Text) ||
                !int.TryParse(textboxAtaque.Text, out int ataque) ||
                !int.TryParse(textboxVida.Text, out int vida))
            {
                MessageBox.Show("Por favor, complete todos los campos con valores válidos.");
                return;
            }
            if (textboxNombre.Text.Length > 15) { MessageBox.Show("El nombre no puede tener más de 15 caracteres."); 
                return; 
            }
            if (ataque < 1 || ataque > 20) { MessageBox.Show("El ataque debe estar entre 1 y 20."); 
                return;
            }
            if (vida < 1 || vida > 100) { MessageBox.Show("La vida debe estar entre 1 y 100."); 
                return; 
            }

            jugador = new Guerrero(textboxNombre.Text, vida, ataque);
            ActualizarPantalla();
        }

        private void button_orco(object sender, EventArgs e) => NuevoEnemigo(new Enemigo("orco", 100, 14, 40));
        private void button_goblin(object sender, EventArgs e) => NuevoEnemigo(new Enemigo("goblin", 60, 8, 20));
        private void button_asesino(object sender, EventArgs e) => NuevoEnemigo(new Enemigo("asesino", 85, 20, 60));

        private void NuevoEnemigo(Enemigo nuevo)
        {
            enemigo = nuevo;
            turnoJugador = true;
            recompensaReclamada = false;
            ActualizarPantalla();

            bool mejoraUsada = false;
        }

        private bool CombateListo()
        {
            if (jugador == null) 
            {   MessageBox.Show("Primero crea tu personaje."); 
                return false; 
            }
            if (enemigo == null) 
            {   MessageBox.Show("Primero selecciona un enemigo."); 
                return false; 
            }
            if (!jugador.EstaVivo || !enemigo.EstaVivo) 
            { 
                MessageBox.Show("El combate ha terminado."); 
                return false; 
            }
            if (jugador.Vida <= 0)
            {
                MessageBox.Show("El guerrero ha muerto. Crea un nuevo personaje.");
                return false;
            }
            if (enemigo.Vida <= 0)
            {
                MessageBox.Show("El enemigo ha muerto. Selecciona un nuevo enemigo.");
                return false;
            }
            if (mejoraUsada && !enemigo.EstaVivo)
            {
                MessageBox.Show("Ya has usado la mejora del guerrero.");
                mejoraUsada = false;
                return false;
            }

            return true;
        }

        private void button_atacar_guerrero(object sender, EventArgs e)
        {
            if (!CombateListo()) return;
            if (!turnoJugador) 
            { 
                MessageBox.Show("Es el turno del enemigo."); 
                return; 
            }

            enemigo!.RecibirDanio(jugador!.Atacar());
            turnoJugador = false;
            ActualizarPantalla();
        }

        private void button_atacar_enemigo(object sender, EventArgs e)
        {
            if (!CombateListo()) return;
            if (turnoJugador) { MessageBox.Show("Es el turno del guerrero."); return; }

            if (enemigo!.TurnosVeneno > 0)
            {
                enemigo.RecibirDanio(5);
                enemigo.TurnosVeneno--;
                if (!enemigo.EstaVivo)
                {
                    turnoJugador = true;
                    ActualizarPantalla();
                    MessageBox.Show("¡El veneno derrotó al enemigo!");
                    return;
                }
            }

            jugador!.RecibirDanio(enemigo.Atacar());
            turnoJugador = true;
            ActualizarPantalla();
        }

        private void button_pocion_vida(object sender, EventArgs e)
        {
            if (jugador == null) { MessageBox.Show("Primero crea tu personaje."); return; }
            if (!turnoJugador) { MessageBox.Show("No puedes usar la poción ahora."); return; }
            if (jugador.PocionesVida == 0) { MessageBox.Show("No tienes más pociones de vida."); return; }

            jugador.PocionesVida--;
            jugador.Curar(40);
            turnoJugador = false;
            ActualizarPantalla();
        }
        private void button_pocion_veneno(object sender, EventArgs e)
        {
            if (!CombateListo()) return;
            if (!turnoJugador) { MessageBox.Show("No puedes usar la poción ahora."); return; }
            if (jugador!.PocionesVeneno == 0) { MessageBox.Show("No tienes más pociones de veneno."); return; }

            jugador.PocionesVeneno--;
            enemigo!.TurnosVeneno = 3;      // el veneno dura 3 turnos del enemigo
            turnoJugador = false;
            ActualizarPantalla();
        }
        private void button_recompensa(object sender, EventArgs e)
        {
            if (jugador == null || enemigo == null || enemigo.EstaVivo || recompensaReclamada)
            {
                MessageBox.Show("No puedes reclamar la recompensa ahora.");
                return;
            }
            jugador.Dinero += enemigo.Recompensa;
            recompensaReclamada = true;
            ActualizarPantalla();
        }

        private void button_tienda(object sender, EventArgs e)
        {
            if (jugador == null) { MessageBox.Show("Primero crea tu personaje."); return; }

            var tienda = new Form2(jugador);
            tienda.CompraRealizada += ActualizarPantalla;

            tienda.Show();
        }
        private void button_mejorarguerrero(object sender, EventArgs e)
        {
            if (jugador == null || enemigo == null || enemigo.EstaVivo || mejoraUsada)
            {
                MessageBox.Show("No puedes mejorar el guerrero ahora.");
                return;
            }

            MessageBox.Show(jugador.Mejorar(aleatorio));

            mejoraUsada = true;

            ActualizarPantalla();
        }

        private void button_guardar(object sender, EventArgs e)
        {
            if (jugador == null)
            {
                MessageBox.Show("Primero crea tu personaje.");
                return;
            }
            Guardado.Guardar(CrearDatos());
            MessageBox.Show("Partida guardada.");
        }
    }
}       