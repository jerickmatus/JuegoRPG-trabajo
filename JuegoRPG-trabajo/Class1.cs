using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRPG_trabajo
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int VidaMaxima { get; set; }
        public int Ataque { get; set; }
        public bool EstaVivo => Vida > 0;

        public Personaje(string nombre, int vida, int ataque)
        {
            Nombre = nombre;
            Vida = vida;
            VidaMaxima = vida;
            Ataque = ataque;
        }

        public int Atacar() => Ataque;

        public void RecibirDanio(int cantidad)
        {
            Vida = Math.Max(0, Vida - cantidad);  
        }

        public void Curar(int cantidad)
        {
            Vida = Math.Min(VidaMaxima, Vida + cantidad);   
        }
    }

    public class Guerrero : Personaje
    {
        public int Dinero { get; set; } = 50;
        public int PocionesVida { get; set; } = 3;
        public int PocionesVeneno { get; set; } = 3;
        public string Mejorar(Random azar)
        {
            if (azar.Next(1, 4) < 2)
            {
                Ataque += 10;
                return "Acaba de mejorar tu ataque 10 puntos";
            }
            VidaMaxima += 10;
            Vida += 10;
            return "Acaba de mejorar tu vida 10 puntos";
        }
        public Guerrero(string nombre, int vida, int ataque) : base(nombre, vida, ataque) 
        {

        }
    }

    public class Enemigo : Personaje
    {
        public int Recompensa { get; }

        public int TurnosVeneno { get; set; }

        public Enemigo(string nombre, int vida, int ataque, int recompensa)
            : base(nombre, vida, ataque)
        {
            Recompensa = recompensa;
        }
    }
}