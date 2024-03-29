﻿using controlador;
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
    /// Ventana que permite otorgar recompensa a una pregunta.
    /// </summary>
    public partial class ventanaReward : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        private int indice;
        private ventanaPreguntaRespuesta ventanaPreguntaRespuesta;

        /// <summary>
        /// Constructor de la ventana
        /// </summary>
        public ventanaReward(int indice, ventanaPreguntaRespuesta ventanaPreguntaRespuesta)
        {
            InitializeComponent();
            this.indice = indice;
            this.ventanaPreguntaRespuesta = ventanaPreguntaRespuesta;
            mostrarInfo();
        }

        public int Indice { get => indice; set => indice = value; }
        public ventanaPreguntaRespuesta VentanaPreguntaRespuesta { get => ventanaPreguntaRespuesta; set => ventanaPreguntaRespuesta = value; }

        /// <summary>
        /// Método que permite mostrar la información de los puntos actuales del usuario.
        /// </summary>
        private void mostrarInfo()
        {
            tb_InfoPuntos.Text = "Usted tiene " + controlador.GetUserReputation() + " puntos de reputación \n No puede dar más puntos que los que poseé";
        }

        /// <summary>
        /// Permite asignar una recompensa a la pregunta según los datos ingresados
        /// </summary>
        private void btn_OfrecerRecompensa_Click(object sender, RoutedEventArgs e)
        {

            //Se convierte a entero el numero ingresado en la textbox
            int recompensa;
            if (int.TryParse(tb_Recompensa.Text, out recompensa))
            {
                //Si la conversión fue exitosa
                //Se llama a Reward desde el controlador
                if (controlador.Reward(controlador.GetQuestionbyIndex(Indice), Convert.ToInt32(tb_Recompensa.Text)))
                {
                    MessageBox.Show("Recompensa agregada");
                    ventanaPreguntaRespuesta.LlenarInformacionPregunta();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No puede ingresar una recompensa mayor a la que usted tiene, ni menor a cero");
                    tb_Recompensa.Clear();
                }
            } else
            {
                //Si el usuario ingreso texto
                tb_Recompensa.Clear();
                MessageBox.Show("Solo puede ingresar números !");

            }    
        }

        /// <summary>
        /// Permite cerrar la ventana.
        /// </summary>
        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
