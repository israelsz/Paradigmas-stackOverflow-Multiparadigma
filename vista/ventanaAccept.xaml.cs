using controlador;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace vista
{
    /// <summary>
    /// Lógica de interacción para ventanaAccept.xaml
    /// </summary>
    public partial class ventanaAccept : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public ventanaAccept()
        {
            InitializeComponent();
            lb_PreguntasUsuario.ItemsSource = controlador.GetPreguntasByConnectedUser();
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
