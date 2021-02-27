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
    /// Ventana que despliega la información de los usuarios registrados.
    /// </summary>
    public partial class ventanaInfoUsuarios : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        /// <summary>
        /// Constructor de la ventana
        /// </summary>
        public ventanaInfoUsuarios()
        {
            InitializeComponent();
            LlenarInformacion();
        }

        /// <summary>
        /// Método que permite llenas la información de los usuarios del stack.
        /// </summary>
        public void LlenarInformacion()
        {
            lb_Usuarios.ItemsSource = controlador.GetAllUsers();
        }

        /// <summary>
        /// Permite volver atras y cerrar esta ventana.
        /// </summary>
        private void btn_Atras_Click(object sender, RoutedEventArgs e)
        {
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
