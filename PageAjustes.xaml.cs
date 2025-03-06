using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1;

namespace AprendeJugando
{
    public partial class PageAjustes : Page
    {

        public PageAjustes()
        {
            InitializeComponent();
        }

        #region Eventos de UI

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double volumen = VolumeSlider.Value;
            SonidoManager.Instance.AjustarVolumen(volumen);

            // Cambiar el icono según el volumen
            CambiarIconoVolumen(volumen);
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = null;
            }
        }

    

        private void BtnPantallaCompleta_Click(object sender, RoutedEventArgs e)
        {
            CambiarModoPantalla(WindowState.Maximized, WindowStyle.None, true);
        }

        private void BtnPantallaVentana_Click(object sender, RoutedEventArgs e)
        {
            CambiarModoPantalla(WindowState.Normal, WindowStyle.SingleBorderWindow, false);
        }

        private void Btn_AcercaDeMi(object sender, RoutedEventArgs e)
        {
            string acercaDeMi = "Este es el Proyecto Aprende Jugando\n" +
                               "Versión 1.0\n" +
                               "Desarrollado por Eduardo Roque Viera Santana\n" +
                               "Fecha: 09-05-2025\n\n" +
                               "Este proyecto tiene como objetivo enseñar de manera divertida a los niños.\n" +
                               "Gracias por utilizarlo.";

            MessageBox.Show(acercaDeMi, "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion

        #region Métodos auxiliares

        // Método para cambiar el icono del volumen basado en el valor del slider
        private void CambiarIconoVolumen(double volumen)
        {
            if (volumen == 0)
            {
                VolumenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeOff;
            }
            else if (volumen <= 30)
            {
                VolumenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeLow;
            }
            else if (volumen <= 70)
            {
                VolumenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMedium;
            }
            else
            {
                VolumenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeHigh;
            }
        }

        // Método para cambiar el modo de la pantalla (completa o ventana)
        private void CambiarModoPantalla(WindowState estadoVentana, WindowStyle estiloVentana, bool topmost)
        {
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                parentWindow.WindowState = estadoVentana;
                parentWindow.WindowStyle = estiloVentana;
                parentWindow.Topmost = topmost;
            }
        }

        private void ReproducirSonidoHover()
        {
            SonidoManager.Instance.ReproducirSonidoHover(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\pasarporEncima.mp3");

        }

        private void BtnHover(object sender, MouseEventArgs e)
        {
            ReproducirSonidoHover();
        }

        #endregion
    }
}
