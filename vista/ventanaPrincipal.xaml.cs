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
    /// Ventana principal del stack en la cual se muestran todas las preguntas.
    /// </summary>
    public partial class ventanaPrincipal : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        /// <summary>
        /// Constructor de la ventana
        /// </summary>
        public ventanaPrincipal()
        {
            InitializeComponent();
            FijarUsernameConectado();
            VerificarInvitado();
            ListBox_Preguntas.ItemsSource = controlador.GetPreguntas();
        }

        /// <summary>
        /// Permite verificar si el usuario entro como invitado, en caso de hacerlo se desactivan ciertas opciones
        /// </summary>
        public void VerificarInvitado()
        {
            if(controlador.IsUserConnected() == false)
            {
                btn_HacerPregunta.IsEnabled = false;
            }
        }

        /// <summary>
        /// Permite mostrar por pantalla el nombre del usuario conectado.
        /// </summary>
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

        /// <summary>
        /// Permite desconectarse y volver a la ventana inicial.
        /// </summary>
        private void Button_Logout_Click(object sender, RoutedEventArgs e)
        {
            controlador.Logout();
            VentanaInicial ventanaInicial = new VentanaInicial();
            ventanaInicial.Show();
            this.Close();
        }

        /// <summary>
        /// Permite abrir con más detalle una pregunta al darle doble click a una pregunta.
        /// </summary>
        private void ListBox_Preguntas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int indice = ListBox_Preguntas.Items.IndexOf(ListBox_Preguntas.SelectedItem);
            ventanaPreguntaRespuesta ventanaPreguntaRespuesta = new ventanaPreguntaRespuesta(indice);
            ventanaPreguntaRespuesta.Show();
            this.Close();
        }

        /// <summary>
        /// Permite abrir la ventana para crear preguntas.
        /// </summary>
        private void btn_HacerPregunta_Click(object sender, RoutedEventArgs e)
        {
            ventanaCrearPregunta ventanaCrearPregunta = new ventanaCrearPregunta();
            ventanaCrearPregunta.Show();
            this.Close();
        }

        /// <summary>
        /// Permite abrir la ventana que despliega la información de los usuarios registrados.
        /// </summary>
        private void btn_VerUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ventanaInfoUsuarios ventanaInfoUsuarios = new ventanaInfoUsuarios();
            ventanaInfoUsuarios.Show();
            this.Close();
        }
    }
}
