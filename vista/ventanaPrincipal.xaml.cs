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
    /// Lógica de interacción para ventanaPrincipal.xaml
    /// </summary>
    public partial class ventanaPrincipal : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public ventanaPrincipal()
        {
            InitializeComponent();
            TextBlock_InfoUsuario.Text = "Conectado como: " + controlador.getLoggedUsername();
            ListBox_Preguntas.ItemsSource = controlador.GetPreguntas();
        }

        private void Button_Logout_Click(object sender, RoutedEventArgs e)
        {
            controlador.Logout();
            VentanaInicial ventanaInicial = new VentanaInicial();
            ventanaInicial.Show();
            this.Close();
        }

        private void ListBox_Preguntas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int indice = ListBox_Preguntas.Items.IndexOf(ListBox_Preguntas.SelectedItem);
            //MessageBox.Show("Indice de lo seleccionado = " + indice);
            ventanaPreguntaRespuesta ventanaPreguntaRespuesta = new ventanaPreguntaRespuesta(indice);
            ventanaPreguntaRespuesta.Show();
            this.Close();
        }
    }
}
