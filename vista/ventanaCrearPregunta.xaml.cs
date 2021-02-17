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
using System.Linq;

namespace vista
{
    /// <summary>
    /// Lógica de interacción para ventanaCrearPregunta.xaml
    /// </summary>
    public partial class ventanaCrearPregunta : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");

        public ventanaCrearPregunta()
        {
            InitializeComponent();
            LlenarEtiquetas();
        }

        public void LlenarEtiquetas()
        {
            cb_SeleccionEtiquetas.ItemsSource = controlador.GetEtiquetas();
        }

        private void btn_AgregarEtiqueta_Click(object sender, RoutedEventArgs e)
        {
            if (!lb_EtiquetasSeleccionadas.Items.Contains(cb_SeleccionEtiquetas.SelectedItem) && cb_SeleccionEtiquetas.SelectedItem != null)
            {
                lb_EtiquetasSeleccionadas.Items.Add(cb_SeleccionEtiquetas.SelectedItem);
            }
        }

        private void btn_EliminarEtiqueta_Click(object sender, RoutedEventArgs e)
        {
            if(lb_EtiquetasSeleccionadas.SelectedIndex >= 0)
            {
                lb_EtiquetasSeleccionadas.Items.RemoveAt(lb_EtiquetasSeleccionadas.SelectedIndex);
            }
        }

        private void btn_PublicarPregunta_Click(object sender, RoutedEventArgs e)
        {
            if(tb_Titulo.Text == "" || tb_Contenido.Text == "")
            {
                MessageBox.Show("No pueden haber campos en blanco");
            }
            else
            {
                var lista = lb_EtiquetasSeleccionadas.Items.Cast<modelo.Etiqueta>().ToList();
                controlador.Ask(tb_Titulo.Text, tb_Contenido.Text, lista);
                MessageBox.Show("Pregunta agregada !");
                ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
                ventanaPrincipal.Show();
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void btn_CrearEtiqueta_Click(object sender, RoutedEventArgs e)
        {
            ventanaCrearEtiqueta ventanaCrearEtiqueta = new ventanaCrearEtiqueta(this);
            ventanaCrearEtiqueta.Show();
        }
    }
}
