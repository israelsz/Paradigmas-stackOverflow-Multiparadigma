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
            FijarUsernameConectado();
            VerificarInvitado();
            ListBox_Preguntas.ItemsSource = controlador.GetPreguntas();
        }

        public void VerificarInvitado()
        {
            if(controlador.IsUserConnected() == false)
            {
                btn_HacerPregunta.IsEnabled = false;
            }
        }

        public void FijarUsernameConectado()
        {
            if(controlador.IsUserConnected() == true)
            {
                TextBlock_InfoUsuario.Text = "Conectado como: " + controlador.getLoggedUsername();
            } else
            {
                TextBlock_InfoUsuario.Text = "Conectado como invitado";
            }
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
            ventanaPreguntaRespuesta ventanaPreguntaRespuesta = new ventanaPreguntaRespuesta(indice);
            ventanaPreguntaRespuesta.Show();
            this.Close();
        }

        private void btn_HacerPregunta_Click(object sender, RoutedEventArgs e)
        {
            ventanaCrearPregunta ventanaCrearPregunta = new ventanaCrearPregunta();
            ventanaCrearPregunta.Show();
            this.Close();
        }

        private void btn_VerUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ventanaInfoUsuarios ventanaInfoUsuarios = new ventanaInfoUsuarios();
            ventanaInfoUsuarios.Show();
            this.Close();
        }
    }
}
