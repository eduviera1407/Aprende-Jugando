﻿using AprendeJugando.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AprendeJugando
{
    public partial class PageJuegoCartas : Page
    {
        private int cartasClicadas = 0;
        private int puntos = 0;
        private int contadorPuntos = 0;
        private int nivel = 1; // Nivel inicial
        private const int PUNTOS_PARA_NIVEL_2 = 5; // Aciertos para subir de nivel
        private const int CARTAS_NIVEL_1 = 4;
        private const int CARTAS_NIVEL_2 = 6;

        private List<string> cartasAleatorias;
        private List<Button> botonesCartas = new List<Button>();
        private List<Button> cartasSeleccionadas = new List<Button>();
        private List<string> imagenesSeleccionadas = new List<string>();

        public PageJuegoCartas()
        {
            InitializeComponent();
            CargarNuevasCartas();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageJugar());
        }

        private void BotonVolver_Hover(object sender, RoutedEventArgs e)
        {
            SonidoManager.Instance.ReproducirSonidoHover(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\pasarporEncima.mp3");
        }

        private void CambiarCarta(Button cartaBoton, string cartaImagen)
        {
            cartaBoton.Content = new Image
            {
                Source = new BitmapImage(new Uri(cartaImagen, UriKind.Absolute)),
                Stretch = Stretch.UniformToFill
            };
            cartaBoton.IsEnabled = false;
        }

        private void Carta_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button cartaBoton && int.TryParse(cartaBoton.Tag.ToString(), out int indice))
            {
                cartasClicadas++;
                cartasSeleccionadas.Add(cartaBoton);
                imagenesSeleccionadas.Add(cartasAleatorias[indice]);

                CambiarCarta(cartaBoton, cartasAleatorias[indice]);

                SonidoManager.Instance.ReproducirSonidoHover(@"D:\CLASES\PROYECTO DAM\Proyecto\AprendeJugando\Sounds\SonidoCartas.mp3");

                // En nivel 1 se comparan 2 cartas, en niveles superiores 3 cartas
                if ((nivel == 1 && cartasClicadas == 2) || (nivel >= 2 && cartasClicadas == 3))
                {
                    CompararCartas();
                }
            }
        }

        private void CompararCartas()
        {
            try
            {
                bool todasIguales = imagenesSeleccionadas.All(img => img == imagenesSeleccionadas[0]);

                if (todasIguales)
                {
                    puntos++;
                    contadorPuntos++;

                    int padreId = SesionActual.PadreId; // Asegúrate de que este valor se asigna correctamente al iniciar sesión.
                    string tipoJuego = "Cartas"; // Tipo de juego
                    string nombreNino = SesionActual.NombreNino; // Nombre del niño
                    LiteDbService lite = new LiteDbService();
                    lite.RegistrarAcierto(padreId, nombreNino, tipoJuego, nivel);


                    NotificacionHandler.MostrarNotificacion("¡Punto! Total de puntos: " + puntos);

                    if (contadorPuntos >= PUNTOS_PARA_NIVEL_2 && nivel == 1)
                    {
                        nivel++;

                        NotificacionHandler.MostrarNotificacion("¡Felicidades! Has avanzado al nivel 2. Ahora hay más cartas y debes encontrar 3 iguales.");
                    }

                    CargarNuevasCartas();
                }
                else
                {
                    RevertirCartas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CompararCartas: " + ex.Message);
            }
        }

        private void configurarPosicionCartas()
        {
            Canvas.SetLeft(CartaVacia1, 402);
            Canvas.SetTop(CartaVacia1, 136);
            Canvas.SetLeft(CartaVacia2, 402);
            Canvas.SetTop(CartaVacia2, 545);
            Canvas.SetLeft(CartaVacia3, 825);
            Canvas.SetTop(CartaVacia3, 136);
            Canvas.SetLeft(CartaVacia4, 825);
            Canvas.SetTop(CartaVacia4, 545);
        }
        private void CargarNuevasCartas()
        {
            cartasAleatorias = Cartas.ObtenerCartasAleatorias(nivel);
            int cantidadCartas = (nivel == 1) ? CARTAS_NIVEL_1 : CARTAS_NIVEL_2;

            botonesCartas = new List<Button> { CartaVacia1, CartaVacia2, CartaVacia3, CartaVacia4 };

            if (nivel >= 2)
            {
                botonesCartas.Add(CartaVacia5);
                botonesCartas.Add(CartaVacia6);
                configurarPosicionCartas();
                CartaVacia5.Visibility = Visibility.Visible;
                CartaVacia6.Visibility = Visibility.Visible;

            }

            for (int i = 0; i < cantidadCartas; i++)
            {
                botonesCartas[i].Tag = i.ToString();
                botonesCartas[i].Content = new Image
                {
                    Source = new BitmapImage(new Uri("D:\\CLASES\\PROYECTO DAM\\Proyecto\\AprendeJugando\\Images\\Imagenes\\Cartas\\cartaVacia.png", UriKind.Absolute)),
                    Stretch = Stretch.UniformToFill
                };
                botonesCartas[i].IsEnabled = true;
            }

            cartasClicadas = 0;
            cartasSeleccionadas.Clear();
            imagenesSeleccionadas.Clear();
        }

        private void ReproducirSonidoHover()
        {
            SonidoManager.Instance.ReproducirSonidoHover(@"D:\CLASES\PROYECTO DAM\Proyecto\\AprendeJugando\\Sounds\\pasarporEncima.mp3");
        }

        private void Btn_hover(object sender, MouseEventArgs e)
        {
            ReproducirSonidoHover();
        }

        private void RevertirCartas()
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += (sender, args) =>
            {
                foreach (var boton in cartasSeleccionadas)
                {
                    boton.Content = new Image
                    {
                        Source = new BitmapImage(new Uri("D:\\CLASES\\PROYECTO DAM\\Proyecto\\AprendeJugando\\Images\\Imagenes\\Cartas\\cartaVacia.png", UriKind.Absolute)),
                        Stretch = Stretch.UniformToFill
                    };
                    boton.IsEnabled = true;
                }

                cartasClicadas = 0;
                cartasSeleccionadas.Clear();
                imagenesSeleccionadas.Clear();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromSeconds(0.35);
            timer.Start();
        }
    }
}
