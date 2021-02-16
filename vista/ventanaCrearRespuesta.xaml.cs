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
    /// Lógica de interacción para ventanaCrearRespuesta.xaml
    /// </summary>
    public partial class ventanaCrearRespuesta : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        private int indice;
        private ventanaPreguntaRespuesta ventanaPreguntaRespuesta;
        public ventanaCrearRespuesta(int indice, ventanaPreguntaRespuesta ventanaPreguntaRespuesta)
        {
            InitializeComponent();
            this.indice = indice;
            this.ventanaPreguntaRespuesta = ventanaPreguntaRespuesta;
        }

        public int Indice { get => indice; set => indice = value; }
        public ventanaPreguntaRespuesta VentanaPreguntaRespuesta { get => ventanaPreguntaRespuesta; set => ventanaPreguntaRespuesta = value; }

        private void btn_AgregarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            controlador.Answer(controlador.GetQuestionbyIndex(Indice), tb_ContenidoRespuesta.Text);
            MessageBox.Show("Respuesta Agregada");
            ventanaPreguntaRespuesta.lb_Respuestas.Items.Refresh();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
