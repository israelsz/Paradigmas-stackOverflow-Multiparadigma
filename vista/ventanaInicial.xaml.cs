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
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class VentanaInicial : Window
    {
        Controlador controlador;
        public VentanaInicial(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            //Se llena el stack de informacion
            controlador.llenarStackInicial();
        }

        private void botonRegister_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistro registro = new VentanaRegistro(controlador);
            registro.Show();
            this.Close();
        }

        private void botonLogin_Click(object sender, RoutedEventArgs e)
        {
            VentanaLogin login = new VentanaLogin(controlador);
            login.Show();
            this.Close();
        }
    }
}
