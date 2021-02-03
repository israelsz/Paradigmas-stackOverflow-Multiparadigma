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
        Controlador controlador = new Controlador();
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void botonRegister_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistro registro = new VentanaRegistro();
            registro.Show();
            this.Close();
        }
    }
}
