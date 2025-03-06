using AprendeJugando.Database;
using System;
using System.Collections.Generic;
using System.Windows;

namespace AprendeJugando
{
    /// <summary>
    /// Lógica de interacción para VentanaProgreso.xaml
    /// </summary>
    public partial class VentanaProgreso : Window
    {
        public VentanaProgreso()
        {
            InitializeComponent();
            CargarProgreso();
        }

        private void CargarProgreso()
        {
            if (SesionActual.PadreAutenticado)
            {
                try
                {
                    LiteDbService dbService = new LiteDbService();
                    List<Progreso> progresos = dbService.ObtenerProgresoPorPadre(SesionActual.PadreId);

                    if (progresos != null && progresos.Count > 0)
                    {
                        dgProgreso.ItemsSource = progresos;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró progreso para el usuario actual.",
                                        "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el progreso: {ex.Message}",
                                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay sesión iniciada. Inicia sesión para ver el progreso.",
                                "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
