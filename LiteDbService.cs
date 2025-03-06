using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AprendeJugando.Database
{
    public class LiteDbService
    {
        private static string DatabasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AprendeJugando.db");

        public LiteDbService()
        {
            CrearBaseDatos();
        }

        private LiteDatabase GetDatabase()
        {
            return new LiteDatabase($"Filename={DatabasePath}; Connection=Shared;");
        }

        public void CrearBaseDatos()
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var padres = db.GetCollection<CredencialesPadres>("Padres");
                    var progreso = db.GetCollection<Progreso>("Progreso");

                    padres.EnsureIndex(p => p.Usuario, unique: true);
                    progreso.EnsureIndex(p => new { p.PadreId, p.TipoJuego, p.Nivel }, unique: true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la base de datos: {ex.Message}");
            }
        }

        public bool InsertarPadre(CredencialesPadres padre)
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var padres = db.GetCollection<CredencialesPadres>("Padres");
                    if (padres.Exists(p => p.Usuario == padre.Usuario))
                    {
                        Console.WriteLine("El usuario ya existe en la base de datos.");
                        return false;
                    }
                    padres.Insert(padre);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el padre: {ex.Message}");
                return false;
            }
        }

        // Busca a un padre por su usuario.
        public CredencialesPadres BuscarPadre(string usuario)
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var padres = db.GetCollection<CredencialesPadres>("Padres");
                    return padres.FindOne(p => p.Usuario == usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar el padre: {ex.Message}");
                return null;
            }
        }

        // Obtiene el progreso de un niño en un tipo de juego y nivel específico.
        public Progreso ObtenerProgreso(int padreId, string tipoJuego, int nivel)
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var progreso = db.GetCollection<Progreso>("Progreso");
                    return progreso.FindOne(p => p.PadreId == padreId && p.TipoJuego == tipoJuego && p.Nivel == nivel)
                           ?? new Progreso
                           {
                               PadreId = padreId,
                               TipoJuego = tipoJuego,
                               Nivel = nivel,
                               Estrellas = 0,
                               NombreNino = "" // Inicialmente vacío
                           };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el progreso: {ex.Message}");
                return null;
            }
        }

        // Registra un acierto y actualiza el progreso del niño, incluyendo el nombre del niño.
        public void RegistrarAcierto(int padreId, string nombreNino, string tipoJuego, int nivel, int estrellasGanadas = 1)
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var progresoCol = db.GetCollection<Progreso>("Progreso");
                    var registro = progresoCol.FindOne(p => p.PadreId == padreId && p.TipoJuego == tipoJuego && p.Nivel == nivel);

                    if (registro == null)
                    {
                        registro = new Progreso
                        {
                            PadreId = padreId,
                            NombreNino = nombreNino,
                            TipoJuego = tipoJuego,
                            Nivel = nivel,
                            Estrellas = estrellasGanadas
                        };
                        progresoCol.Insert(registro);
                    }
                    else
                    {
                        registro.Estrellas += estrellasGanadas;
                        progresoCol.Update(registro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar acierto: {ex.Message}");
            }
        }

        // Obtiene todo el progreso de un niño asociado a un padre.
        public List<Progreso> ObtenerProgresoPorPadre(int padreId)
        {
            try
            {
                using (var db = GetDatabase())
                {
                    var progresoCol = db.GetCollection<Progreso>("Progreso");
                    return progresoCol.Find(p => p.PadreId == padreId).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el progreso del usuario: {ex.Message}");
                return new List<Progreso>(); // Devuelve una lista vacía en caso de error
            }
        }
    }

    // Modelo de credenciales de los padres.
    public class CredencialesPadres
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string NombreNino { get; set; }
    }

    // Modelo de progreso de los niños en los juegos.
    public class Progreso
    {
        public int Id { get; set; }
        public int PadreId { get; set; }  // Relación con el padre registrado.
        public string NombreNino { get; set; }  // Nuevo campo para el nombre del niño.
        public string TipoJuego { get; set; }  // Ejemplo: "Cartas", "Mates", "Lengua", "Animales".
        public int Nivel { get; set; }  // Nivel del juego (1, 2, 3, ...).
        public int Estrellas { get; set; }  // Puntuación acumulada (cada acierto suma estrellas).
    }
}
