using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JuegoRPG_trabajo
{
    public partial class Form2 : Form
    {
        private readonly Guerrero _jugador;
        private const int PrecioVida = 30;
        private const int PrecioVeneno = 40;

        
        public event Action? CompraRealizada;

        public Form2(Guerrero jugador)
        {
            InitializeComponent();
            _jugador = jugador;
        }

        private void button_comprarvida(object sender, EventArgs e)
        {
            if (_jugador.Dinero < PrecioVida)
            {
                MessageBox.Show("No tienes suficiente dinero.");
                return;
            }
            _jugador.Dinero -= PrecioVida;
            _jugador.PocionesVida++;
            CompraRealizada?.Invoke();
        }

        private void button_comprarveneno(object sender, EventArgs e)
        {
            if (_jugador.Dinero < PrecioVeneno)
            {
                MessageBox.Show("No tienes suficiente dinero.");
                return;
            }
            _jugador.Dinero -= PrecioVeneno;
            _jugador.PocionesVeneno++;
            CompraRealizada?.Invoke();
        }

        private void button_cerrartienda(object sender, EventArgs e) => Close();

    }
}