using controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vista
{
    /// <summary>
    /// Logica para la ventana inicial
    /// </summary>

    public partial class VentanaInicial : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        /// <summary>
        /// Constructor de la ventana.
        /// </summary>
        public VentanaInicial()
        {
            InitializeComponent();
            //Se llena el stack de informacion
            controlador.llenarStackInicial();
        }

        /// <summary>
        /// Al ser clickeado llama a register desde el controlador
        /// </summary>
        private void botonRegister_Click(object sender, RoutedEventArgs e)
        {
            //En primer lugar se verificara si los campos se encuentran vacios
            if (tb_Username.Text == "" || pb_Password.Password == "")
            {
                MessageBox.Show("Debe escribir algo en ambos campos");
            }

            else if (controlador.Register(tb_Username.Text, pb_Password.Password))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("El usuario ya esta registrado");
            }
            tb_Username.Clear();
            pb_Password.Clear();
        }

        /// <summary>
        /// Al ser clickeado llama a Login desde el controlador.
        /// </summary>
        private void botonLogin_Click(object sender, RoutedEventArgs e)
        {
            //En primer lugar se verificara si los campos se encuentran vacios
            if (tb_Username.Text == "" || pb_Password.Password == "")
            {
                MessageBox.Show("Debe escribir algo en ambos campos");
            }
            //Se llama a login
            else if (controlador.Login(tb_Username.Text, pb_Password.Password))
            {
                //Si fue posible loguearse
                MessageBox.Show("Logueo correcto");
                ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
                ventanaPrincipal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no validas, verifiquelo e intente otra vez");
            }
            tb_Username.Clear();
            pb_Password.Clear();
        }

        /// <summary>
        /// Permite el ingreso al stack como invitado
        /// </summary>
        private void btn_EntrarInvitado_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logueandose como invitado");
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }
    }
}
