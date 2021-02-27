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
    /// Ventana que permite crear respuestas
    /// </summary>
    public partial class ventanaCrearRespuesta : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        private int indice;
        private ventanaPreguntaRespuesta ventanaPreguntaRespuesta;

        /// <summary>
        /// Constructor de la ventana, recibe un indice y la ventana de donde fue abierta esta ventana.
        /// </summary>
        public ventanaCrearRespuesta(int indice, ventanaPreguntaRespuesta ventanaPreguntaRespuesta)
        {
            InitializeComponent();
            this.indice = indice;
            this.ventanaPreguntaRespuesta = ventanaPreguntaRespuesta;
        }

        /// <value> Devuelve o setea el indice </value>
        public int Indice { get => indice; set => indice = value; }

        /// <value> Devuelve o setea la ventana </value>
        public ventanaPreguntaRespuesta VentanaPreguntaRespuesta { get => ventanaPreguntaRespuesta; set => ventanaPreguntaRespuesta = value; }

        /// <summary>
        /// Permite agregar una respuesta con la información ingresada.
        /// </summary>
        private void btn_AgregarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            if(tb_ContenidoRespuesta.Text == "")
            {
                MessageBox.Show("Debe escribir una respuesta");
            } else
            {
                controlador.Answer(controlador.GetQuestionbyIndex(Indice), tb_ContenidoRespuesta.Text);
                MessageBox.Show("Respuesta Agregada");
                ventanaPreguntaRespuesta.lb_Respuestas.Items.Refresh();
                this.Close();
            }
        }

        /// <summary>
        /// Permite salir de la ventana y volver atras.
        /// </summary>
        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
