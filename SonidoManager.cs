using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

public class SonidoManager
{
    private static SonidoManager _instance;
    private MediaPlayer _mediaPlayer;
    private MediaPlayer _mediaPlayerExplicacion;
    private MediaPlayer _mediaPlayerHover;

    // Constructor privado para el patrón Singleton
    private SonidoManager()
    {
        _mediaPlayer = new MediaPlayer();
        _mediaPlayerExplicacion = new MediaPlayer();
        _mediaPlayerHover = new MediaPlayer();
    }

    // Instancia única de la clase (Singleton)
    public static SonidoManager Instance => _instance ??= new SonidoManager();

    // Reproducir música de fondo
    public void ReproducirMusicaDeFondo(string rutaSonido)
    {
        if (_mediaPlayer.Source == null)
        {
            try
            {
                // Usar la URI correcta para recursos empaquetados
                Uri soundUri = new Uri(rutaSonido,UriKind.Relative);
                _mediaPlayer.Open(soundUri);
                _mediaPlayer.Volume = 0.5;
                _mediaPlayer.Play();

                // Reproducir música en bucle
                _mediaPlayer.MediaEnded += (sender, e) =>
                {
                    _mediaPlayer.Position = TimeSpan.Zero;
                    _mediaPlayer.Play();
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al reproducir música de fondo: {ex.Message}");
                MessageBox.Show("Error al reproducir música de fondo: " + ex.Message);
            }
        }
    }

    public void ReproducirSonidoDeInicio()
    {
        SonidoManager.Instance.ReproducirMusicaDeFondo("Sounds/sonidoPrincipal.wav");
    }


    // Reproducir sonido de explicación
    public void ReproducirSonidoDeExplicacion(string rutaSonido)
    {
        try
        {
            _mediaPlayerExplicacion.Stop();
            _mediaPlayerExplicacion.Open(new Uri(rutaSonido, UriKind.Relative));
            _mediaPlayerExplicacion.Volume = 0.7;
            _mediaPlayerExplicacion.Play();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al reproducir el sonido de explicación: " + ex.Message);
        }
    }

    // Reproducir sonido de hover (cuando se pasa el cursor por encima)
    public void ReproducirSonidoHover(string rutaSonidoHover)
    {
        try
        {
            _mediaPlayerHover.Stop();
            _mediaPlayerHover.Open(new Uri(rutaSonidoHover, UriKind.Relative));
            _mediaPlayerHover.Volume = 0.5;
            _mediaPlayerHover.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al reproducir el sonido de hover: {ex.Message}");
        }
    }

    // Detener el sonido de explicación
    public void PararSonidoExplicacion()
    {
        try
        {
            _mediaPlayerExplicacion.Stop();
            _mediaPlayerExplicacion.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al parar el sonido de explicación: {ex.Message}");
            MessageBox.Show("Error al parar el sonido de explicación: " + ex.Message);
        }
    }

    // Ajustar volumen de la música de fondo
    public void AjustarVolumen(double volumen)
    {
        if (_mediaPlayer != null)
        {
            try
            {
                _mediaPlayer.Volume = volumen / 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ajustar el volumen: {ex.Message}");
                MessageBox.Show("Error al ajustar el volumen: " + ex.Message);

            }
        }
    }

    // Detener todos los sonidos al cerrar la aplicación
    public void DetenerTodosLosSonidos()
    {
        try
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();

            _mediaPlayerExplicacion.Stop();
            _mediaPlayerExplicacion.Close();

            _mediaPlayerHover.Stop();
            _mediaPlayerHover.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al detener todos los sonidos: {ex.Message}");
            MessageBox.Show("Error al detener todos los sonidos: " + ex.Message);
        }
    }
}
