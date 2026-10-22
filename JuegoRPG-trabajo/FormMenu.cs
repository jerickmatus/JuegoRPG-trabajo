using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoRPG_trabajo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
           
            button2.Enabled = Guardado.Existe();
        }

        private void button_iniciarpartida(object sender, EventArgs e)
        {
            IniciarJuego(null);
        }

        private void button_cargarpartida(object sender, EventArgs e)
        {
            var datos = Guardado.Cargar();
            if (datos == null)
            {
                MessageBox.Show("No se pudo leer la partida guardada.");
                return;
            }
            IniciarJuego(datos);
        }

        private void IniciarJuego(DatosPartida? datos)
        {
            var juego = new Form1(datos);
            juego.FormClosed += (s, e) => Close();
            Hide();
            juego.Show();
        }
    }
}