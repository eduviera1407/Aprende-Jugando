using System.Windows.Media;

public class SonidoManager
{
    private static SonidoManager _instance;
    private MediaPlayer _mediaPlayer; 
    private MediaPlayer _mediaPlayerExplicacion; 
    private MediaPlayer _mediaPlayerHover; 

    private SonidoManager()
    {
        _mediaPlayer = new MediaPlayer();
        _mediaPlayerExplicacion = new MediaPlayer();
        _mediaPlayerHover = new MediaPlayer();
    }

    public static SonidoManager Instance => _instance ??= new SonidoManager();

    public void ReproducirMusicaDeFondo(string rutaSonido)
    {
        if (_mediaPlayer.Source == null) 
        {
            _mediaPlayer.Open(new Uri(rutaSonido, UriKind.Absolute));
            _mediaPlayer.Volume = 0.5;
            _mediaPlayer.Play();

            _mediaPlayer.MediaEnded += (sender, e) =>
            {
                _mediaPlayer.Position = TimeSpan.Zero;
                _mediaPlayer.Play();
            };
        }
    }

    public void ReproducirSonidoDeExplicacion(string rutaSonido)
    {
        _mediaPlayerExplicacion.Stop(); 
        _mediaPlayerExplicacion.Open(new Uri(rutaSonido, UriKind.Absolute));
        _mediaPlayerExplicacion.Volume = 0.7;
        _mediaPlayerExplicacion.Play();
    }

    public void ReproducirSonidoHover(string rutaSonidoHover)
    {
        _mediaPlayerHover.Stop();
        _mediaPlayerHover.Open(new Uri(rutaSonidoHover, UriKind.Absolute));
        _mediaPlayerHover.Volume = 0.5;
        _mediaPlayerHover.Play();
    }


    public void PararSonidoExplicacion()
    {
        _mediaPlayerExplicacion.Stop();
        _mediaPlayerExplicacion.Close();
    }


    public void AjustarVolumen(double volumen)
    {
        _mediaPlayer.Volume = volumen / 100;
    }

}
