using System;
using System.Collections.Generic;
using System.Text;

using System.Text.Json;

namespace JuegoRPG_trabajo
{
    public class DatosPartida
    {
       
        public string Nombre { get; set; } = "";
        public int Vida { get; set; }
        public int VidaMaxima { get; set; }
        public int Ataque { get; set; }
        public int Dinero { get; set; }
        public int PocionesVida { get; set; }
        public int PocionesVeneno { get; set; }

        
        public bool HayEnemigo { get; set; }
        public string EnemigoNombre { get; set; } = "";
        public int EnemigoVida { get; set; }
        public int EnemigoVidaMaxima { get; set; }
        public int EnemigoAtaque { get; set; }
        public int EnemigoRecompensa { get; set; }
        public int EnemigoTurnosVeneno { get; set; }

        
        public bool TurnoJugador { get; set; } = true;
        public bool RecompensaReclamada { get; set; }
        public bool MejoraUsada { get; set; }
    }

    public static class Guardado
    {
        private static readonly string Ruta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "JuegoRPG_trabajo", "partida.json");

        public static bool Existe() => File.Exists(Ruta);

        public static void Guardar(DatosPartida datos)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Ruta)!);
            string json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Ruta, json);
        }

        public static DatosPartida? Cargar()
        {
            try
            {
                if (!File.Exists(Ruta)) return null;
                return JsonSerializer.Deserialize<DatosPartida>(File.ReadAllText(Ruta));
            }
            catch
            {
                return null;  
            }
        }
    }
}