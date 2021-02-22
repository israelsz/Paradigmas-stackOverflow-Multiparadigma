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
    /// Lógica de interacción para ventanaVote.xaml
    /// </summary>
    public partial class ventanaVote : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        private string tipo;
        private ventanaPreguntaRespuesta ventanaPreguntaRespuesta;
        public ventanaVote(string tipo, ventanaPreguntaRespuesta ventanaPreguntaRespuesta)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.ventanaPreguntaRespuesta = ventanaPreguntaRespuesta;
            FijarTexto();
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public ventanaPreguntaRespuesta VentanaPreguntaRespuesta { get => ventanaPreguntaRespuesta; set => ventanaPreguntaRespuesta = value; }

        public void FijarTexto()
        {
            //Si se trata de votar por una pregunta
            if(Tipo == "pregunta")
            {
                tb_TextoVoto.Text = "Votando por pregunta";
            }
            //Si se trata de votar por una respuesta
            else
            {
                tb_TextoVoto.Text = "Votando por respuesta";
            }
        }

        private void btn_VotarPositivo_Click(object sender, RoutedEventArgs e)
        {
            //Si se trata de votar positivamente por una pregunta
            if (Tipo == "pregunta")
            {
                controlador.Vote(controlador.GetQuestionbyIndex(VentanaPreguntaRespuesta.Indice), true);
                VentanaPreguntaRespuesta.LlenarInformacionPregunta();
                MessageBox.Show("Pregunta votada positivamente");
                this.Close();
            }
            //Si se trata de votar positivamente por una respuesta
            else
            {
                controlador.Vote((modelo.Respuesta)VentanaPreguntaRespuesta.lb_Respuestas.SelectedItem, true);
                ventanaPreguntaRespuesta.lb_Respuestas.Items.Refresh();
                MessageBox.Show("Respuesta votada positivamente");
                this.Close();
            }
        }

        private void btn_VotarNegativo_Click(object sender, RoutedEventArgs e)
        {
            //Si se trata de votar negativamente por una pregunta
            if (Tipo == "pregunta")
            {
                controlador.Vote(controlador.GetQuestionbyIndex(VentanaPreguntaRespuesta.Indice), false);
                VentanaPreguntaRespuesta.LlenarInformacionPregunta();
                MessageBox.Show("Pregunta votada negativamente");
                this.Close();
            }
            //Si se trata de votar negativamente por una respuesta
            else
            {
                controlador.Vote((modelo.Respuesta)VentanaPreguntaRespuesta.lb_Respuestas.SelectedItem, false);
                ventanaPreguntaRespuesta.lb_Respuestas.Items.Refresh();
                MessageBox.Show("Respuesta votada negativamente");
                this.Close();
            }
        }
    }
}
