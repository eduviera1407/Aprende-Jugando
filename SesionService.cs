using AprendeJugando.Database;
using System;
using System.Collections.Generic;

namespace AprendeJugando.Services
{
    public class SesionService
    {
        private static SesionService _instancia;
        private CredencialesPadres _usuarioActual;
        private LiteDbService _dbService;

        private SesionService()
        {
            _dbService = new LiteDbService();
        }

        public static SesionService Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new SesionService();
                return _instancia;
            }
        }

        public bool SesionIniciada => _usuarioActual != null;
        public event Action<string> OnEstadoSesionActualizado;
        public event Action<Progreso> OnProgresoActualizado; // Evento para progreso

        public bool IniciarSesion(string usuario, string contrasena)
        {
            OnEstadoSesionActualizado?.Invoke("Verificando credenciales...");
            var usuarioEncontrado = _dbService.BuscarPadre(usuario);

            if (usuarioEncontrado != null && usuarioEncontrado.Contrasena == contrasena)
            {
                _usuarioActual = usuarioEncontrado;
                OnEstadoSesionActualizado?.Invoke($"Sesión iniciada para {usuario}");

                // Obtener todos los registros de progreso del usuario
                var progresos = _dbService.ObtenerProgresoPorPadre(_usuarioActual.Id);
                foreach (var progreso in progresos)
                {
                    OnProgresoActualizado?.Invoke(progreso);
                }

                return true;
            }

            OnEstadoSesionActualizado?.Invoke("Credenciales incorrectas.");
            return false;
        }

        public void CerrarSesion()
        {
            if (_usuarioActual != null)
            {
                string usuario = _usuarioActual.Usuario;
                _usuarioActual = null;
                OnEstadoSesionActualizado?.Invoke($"Sesión cerrada para {usuario}");
            }
        }

        public CredencialesPadres ObtenerUsuarioActual()
        {
            return _usuarioActual;
        }
    }
}
