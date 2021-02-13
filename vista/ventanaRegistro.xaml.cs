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
    /// Lógica de interacción para ventanaRegistro.xaml
    /// </summary>
    public partial class VentanaRegistro : Window
    {
        //Se invoca al controlador.
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        public VentanaRegistro()
        {
            InitializeComponent();
        }

        private void button_RegisterNewUser_Click(object sender, RoutedEventArgs e)
        {
            //En primer lugar se verificara si los campos se encuentran vacios
            if(TextBox_Username.Text == "" || PasswordBox_Password.Password == "")
            {
                MessageBox.Show("Debe escribir algo en ambos campos");
            }

            else if (controlador.Register(TextBox_Username.Text, PasswordBox_Password.Password))
            {
                MessageBox.Show("Registro exitoso");
            } else
            {
                MessageBox.Show("El usuario ya esta registrado");
            }
            TextBox_Username.Clear();
            PasswordBox_Password.Clear();
        }

        private void Button_VolverAtras_Click(object sender, RoutedEventArgs e)
        {
            VentanaInicial ventanaInicial = new VentanaInicial();
            ventanaInicial.Show();
            this.Close();
        }
    }
}
