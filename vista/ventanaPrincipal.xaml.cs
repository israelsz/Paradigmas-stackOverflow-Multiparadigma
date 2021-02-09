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
        Controlador controlador;
        public ventanaPrincipal(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            TextBlock_InfoUsuario.Text = "Conectado como: " + controlador.getLoggedUsername();
        }


    }
}
