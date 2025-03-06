using AprendeJugando.Database;
using System.Windows;

namespace AprendeJugando
{
    public partial class VentanaEntrada : Window
    {
        private int Resultado;
        public string UsuarioIngresado { get; set; }
        public string ContrasenaIngresada { get; set; }

        public VentanaEntrada()
        {
            InitializeComponent();
            GenerarSuma();
        }

        private void GenerarSuma()
        {
            Random random = new Random();
            int num1 = random.Next(1, 2);
            int num2 = random.Next(1, 2);
            Resultado = num1 + num2;
            Pregunta.Text = $"{num1} + {num2} = ?";
        }

        private void BtnValidar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RespuestaTextBox.Text, out int respuestaNumerica) && respuestaNumerica == Resultado)
            {
           
                Pregunta.Visibility = Visibility.Collapsed;
                BtnValidar.Visibility = Visibility.Collapsed;
                TextoPregunta.Visibility = Visibility.Collapsed;
                RespuestaTextBox.Visibility = Visibility.Collapsed;
                BorderName.Visibility=Visibility.Collapsed;
                LoginPanel.Visibility = Visibility.Visible;
            }
            else
            {

                NotificacionHandler.MostrarNotificacion("Respuesta incorrecta, intenta de nuevo. Validación de Padre",2000);
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            UsuarioIngresado = UsuarioTextBox.Text;
             ContrasenaIngresada = PasswordBox.Password;

            var dbService = new LiteDbService();
            var padre = dbService.BuscarPadre(UsuarioIngresado);

            if (padre != null && padre.Contrasena == ContrasenaIngresada)
            {
                NotificacionHandler.MostrarNotificacion($"¡Bienvenido, {padre.NombreNino}! Acceso exitoso", 3000);

                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password) ||
                string.IsNullOrWhiteSpace(NameNino.Text)) // Se valida que el nombre del niño no esté vacío
            {
                MessageBox.Show("Por favor ingrese un usuario, una contraseña y el nombre del niño.");
                return;
            }

            var nuevoPadre = new CredencialesPadres
            {
                Usuario = UsuarioTextBox.Text,
                Contrasena = PasswordBox.Password,
                NombreNino = NameNino.Text // Se guarda el nombre del niño
            };

            var dbService = new LiteDbService();
            dbService.InsertarPadre(nuevoPadre);

            MessageBox.Show($"Usuario {nuevoPadre.Usuario} registrado correctamente.\nNiño: {nuevoPadre.NombreNino}");
        }

    }
}