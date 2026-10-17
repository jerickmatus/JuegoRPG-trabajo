using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRPG_trabajo
{
    public class Personaje()
    {
        public string nombre { get; set; }
        public int vida { get; set; }
        public int vidamaxima { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }

        private Random aleatorio = new Random();

        public int atacar() => ataque;
        public void Recibirdaño(int cantidad)
        {
            vida -= cantidad;
        }

    }
}