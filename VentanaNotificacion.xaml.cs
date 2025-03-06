using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

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
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public  void CambiarImagenPersonaje(string ruta)
        {
            BitmapImage nuevaImagen = new BitmapImage(new Uri(ruta));

            // Asignar la nueva imagen a la propiedad Source del Image
            personajeSonriente.Source = nuevaImagen;
        }
    }

    public static class NotificacionHandler
    {
        public static async Task MostrarNotificacion(string mensajeInicial, int retrasoMs = 0)
        {
            try
            {
                // Crear la ventana de notificación con el mensaje inicial
                VentanaNotificacion ventanaNotificacion = new VentanaNotificacion(mensajeInicial)
                {
                    Topmost = true
                };

                // Esperar el retraso antes de mostrar la ventana
                await Task.Delay(retrasoMs);

                // Mostrar la ventana
                ventanaNotificacion.Show();
                ventanaNotificacion.UpdateLayout(); // Asegurar que tenga tamaño correcto

                // Centrar la ventana en la pantalla después del retraso
                ventanaNotificacion.Left = (SystemParameters.PrimaryScreenWidth - ventanaNotificacion.ActualWidth) / 2;
                ventanaNotificacion.Top = (SystemParameters.PrimaryScreenHeight - ventanaNotificacion.ActualHeight) / 2;
            }
            catch (Exception ex)
            {
                // Manejar excepciones mostrando un mensaje de error
                MessageBox.Show($"Error al mostrar la notificación: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



    }
}
