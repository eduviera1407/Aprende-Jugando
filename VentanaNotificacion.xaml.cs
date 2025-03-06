using System;
using System.Threading.Tasks;
using System.Windows;

namespace AprendeJugando
{
    public partial class VentanaNotificacion : Window
    {
        public VentanaNotificacion(string mensaje)
        {
            InitializeComponent();
            txtNotificacion.Text = mensaje;
        }

        public void CambiarTextoNotificacion(string nuevoMensaje)
        {
            txtNotificacion.Text = nuevoMensaje;
            txtNotificacion.TextAlignment = TextAlignment.Center;
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public static class NotificacionHandler
    {
        public static async void MostrarNotificacion(string mensajeInicial, string mensajeNuevo = "", int retrasoMs = 2000)
        {
            try
            {
                VentanaNotificacion ventanaNotificacion = new VentanaNotificacion(mensajeInicial)
                {
                    Topmost = true
                };

                ventanaNotificacion.Show();
                ventanaNotificacion.UpdateLayout(); // Asegurar que tenga tamaño correcto

                // Centrar la ventana en la pantalla
                ventanaNotificacion.Left = (SystemParameters.PrimaryScreenWidth - ventanaNotificacion.ActualWidth) / 2;
                ventanaNotificacion.Top = (SystemParameters.PrimaryScreenHeight - ventanaNotificacion.ActualHeight) / 2;

                // Si hay un mensaje nuevo, esperar un poco y cambiarlo
                if (!string.IsNullOrEmpty(mensajeNuevo))
                {
                    await Task.Delay(retrasoMs);
                    ventanaNotificacion.CambiarTextoNotificacion(mensajeNuevo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la notificación: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
