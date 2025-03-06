using AprendeJugando;
using AprendeJugando.Database;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ReproducirSonidoDeInicio();
            AjustarEscala();
            LiteDbService liteDbService = new LiteDbService();
            

            // Llamar al método CrearBaseDatos para verificar y crear la base de datos
            liteDbService.CrearBaseDatos();



        }

        private void ReproducirSonidoDeInicio()
        {
            SonidoManager.Instance.ReproducirMusicaDeFondo(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\sonidoPrincipal.wav");
           
        }


        private void AjustarEscala()
        {
            double dpiScale = VisualTreeHelper.GetDpi(this).DpiScaleX;
            MainScaleTransform.ScaleX = 1 / dpiScale;
            MainScaleTransform.ScaleY = 1 / dpiScale;
        }

        private void botonIniciar_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("PageJugar.xaml", UriKind.Relative));

        }

        private void botonAjustes_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Navigate(new Uri("PageAjustes.xaml", UriKind.Relative));

        }






        private void ReproducirSonidoHover()
        {
            SonidoManager.Instance.ReproducirSonidoHover(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\pasarporEncima.mp3");

        }

        private void BtnHover(object sender, MouseEventArgs e)
        {
            ReproducirSonidoHover();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Storyboard sbLogo = (Storyboard)FindResource("EscalarLogo");
                Storyboard sbIniciar = (Storyboard)FindResource("Flotar");
                Storyboard sbAjustes = (Storyboard)FindResource("Flotar");
                Storyboard sSalir = (Storyboard)FindResource("Flotar2");

                Storyboard.SetTarget(sbIniciar, botonIniciar);
                sbIniciar.Begin();

                Storyboard.SetTarget(sbAjustes, botonAjustes);
                sbAjustes.Begin();

                Storyboard.SetTarget(sSalir, botonSalir);
                sSalir.Begin();

                Storyboard.SetTarget(sbLogo, logo);
                sbLogo.Begin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las animaciones: " + ex.Message);
            }
        }

        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
