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
    /// Lógica de interacción para ventanaInfoUsuarios.xaml
    /// </summary>
    public partial class ventanaInfoUsuarios : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        public ventanaInfoUsuarios()
        {
            InitializeComponent();
            LlenarInformacion();
        }

        public void LlenarInformacion()
        {
            lb_Usuarios.ItemsSource = controlador.GetAllUsers();
        }

        private void btn_Atras_Click(object sender, RoutedEventArgs e)
        {
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
