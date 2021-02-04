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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class VentanaLogin : Window
    {
        Controlador controlador;
        public VentanaLogin(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void Button_volverAtras_Click(object sender, RoutedEventArgs e)
        {
            VentanaInicial ventanaInicial = new VentanaInicial(controlador);
            ventanaInicial.Show();
            this.Close();
        }

        private void Button_Conectarse_Click(object sender, RoutedEventArgs e)
        {
            //En primer lugar se verificara si los campos se encuentran vacios
            if (TextBox_Username.Text == "" || PasswordBox_Password.Password == "")
            {
                MessageBox.Show("Debe escribir algo en ambos campos");
            }
            //Se llama a login
            else if (controlador.Login(TextBox_Username.Text, PasswordBox_Password.Password)){
                //Si fue posible loguearse
                MessageBox.Show("Logueo correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no validas, verifiquelo e intente otra vez");
            }
            TextBox_Username.Clear();
            PasswordBox_Password.Clear();
        }
    }
}
