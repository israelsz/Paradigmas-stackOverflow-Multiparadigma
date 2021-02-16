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
    /// Lógica de interacción para ventanaPreguntaRespuesta.xaml
    /// </summary>
    public partial class ventanaPreguntaRespuesta : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        private int indice;
        public ventanaPreguntaRespuesta(int indice)
        {
            InitializeComponent();
            this.indice = indice;
            LlenarInformacionPregunta();
        }

        public int Indice { get => indice; set => indice = value; }

        public void LlenarInformacionPregunta()
        {
            tb_Titulo.Text = controlador.getTitulo(Indice);
            tb_Contenido.Text = controlador.getContenido(Indice);
            tb_Fecha.Text = controlador.getQuestionFecha(Indice);
            tb_Votos.Text = "Votos: " + controlador.getQuestionVotes(Indice);
            tb_Estado.Text = "Estado: " + controlador.GetQuestionStatus(Indice);
            tb_Autor.Text = "Autor: " + controlador.GetQuestionAutor(Indice);
            tb_Id.Text = "Id: " + controlador.GetQuestionId(Indice);
            lb_Etiquetas.ItemsSource = controlador.GetQuestionLabels(Indice);
            lb_Respuestas.ItemsSource = controlador.GetRespuestas(Indice);
        }

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void btn_AgregarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            ventanaCrearRespuesta ventanaCrearRespuesta = new ventanaCrearRespuesta(Indice,this);
            ventanaCrearRespuesta.Show();
        }
    }
}
