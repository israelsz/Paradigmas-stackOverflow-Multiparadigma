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
            tb_Recompensa.Text = "Recompensa: " + controlador.GetQuestionReward(Indice);

            //Se verifica si el autor de la pregunta es la misma persona conectada en este momento
            if (controlador.GetQuestionAutor(Indice) != controlador.getLoggedUsername())
            {
                //En caso de que la pregunta no pertenece a la persona conectada, se deshabilitara la opcion de Accept
                btn_AceptarRespuesta.IsEnabled = false;
            }

            //Si el autor de la pregunta es la misma persona conectada en este momento
            if (controlador.GetQuestionAutor(Indice) == controlador.getLoggedUsername())
            {
                //Se desactivara la opcion de poder votar por su propia pregunta
                btn_VotePregunta.IsEnabled = false;
            }
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

        private void btn_DarRecompensa_Click(object sender, RoutedEventArgs e)
        {
            if(controlador.GetQuestionStatus(Indice) == "abierta")
            {
                ventanaReward ventanaReward = new ventanaReward(Indice, this);
                ventanaReward.Show();
            }
            else
            {
                MessageBox.Show("No puede ofrecer una recompensa a una pregunta cerrada");
            }
        }

        private void btn_AceptarRespuesta_Click(object sender, RoutedEventArgs e)
        {
            if (lb_Respuestas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una respuesta para ser aceptada");
            }
            else
            {
                if(controlador.Accept(controlador.GetQuestionbyIndex(Indice), (modelo.Respuesta)lb_Respuestas.SelectedItem))
                {
                    LlenarInformacionPregunta();
                    MessageBox.Show("Respuesta aceptada");
                }
                else
                {
                    MessageBox.Show("La pregunta ya se encuentra cerrada\nNo es posible aceptar otra respuesta");
                }
            }
        }

        private void btn_VotePregunta_Click(object sender, RoutedEventArgs e)
        {
            ventanaVote ventanaVote = new ventanaVote("pregunta", this);
            ventanaVote.Show();
        }

        private void btn_VoteRespuesta_Click(object sender, RoutedEventArgs e)
        {
            if(lb_Respuestas.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una respuesta antes de poder votar");
            }
            else
            {
                ventanaVote ventanaVote = new ventanaVote("respuesta", this);
                ventanaVote.Show();
            }
        }

        private void lb_Respuestas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string autorRespuesta = controlador.GetAnswerAutor((modelo.Respuesta)lb_Respuestas.SelectedItem);
            //En caso que la respuesta seleccionada pertenezca al usuario conectado actualmente
            if(autorRespuesta == controlador.getLoggedUsername())
            {
                btn_VoteRespuesta.IsEnabled = false;
            } else
            {
                btn_VoteRespuesta.IsEnabled = true;
            }
        }
    }
}
