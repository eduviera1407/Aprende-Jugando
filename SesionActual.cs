using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendeJugando
{
public static class SesionActual
{
    public static int PadreId { get; set; }
    public static int NinoId { get; set; }
    public static string Usuario { get; set; }
    public static string NombreNino { get; set; }
    public static string JuegoActual { get; set; } = "N/A";  // Se actualiza al jugar
    public static int NivelActual { get; set; } = 1; // Nivel por defecto
    public static int Estrellas { get; set; } = 0; // Estrellas obtenidas
    public static bool PadreAutenticado { get; set; } = false;
}

}
