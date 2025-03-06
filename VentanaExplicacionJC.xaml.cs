using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1;

namespace AprendeJugando
{
    /// <summary>
    /// Lógica de interacción para VentanaExplicacionJC.xaml
    /// </summary>
    public partial class VentanaExplicacionJC : Window
    {
        public VentanaExplicacionJC()
        {
            InitializeComponent();
            vozenOff();
        
        }

        public void vozenOff()
        {

             SonidoManager.Instance.ReproducirSonidoDeExplicacion(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\vozExplicacionJC.mp3");
            //parar el sonido si se cierra la ventana
            this.Closing += (sender, e) =>
            {
                SonidoManager.Instance.PararSonidoExplicacion();
            };


        }
        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana actual

            // Obtiene la ventana principal y cambia la página
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.MainFrame.Content = new PageJuegoCartas();
                mainWindow.WindowState= WindowState.Maximized;
            }
        }

    }
}
