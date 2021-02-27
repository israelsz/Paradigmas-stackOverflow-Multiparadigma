using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Etiqueta contiene todas las caracteristicas que poseé una etiqueta.
    /// </summary>
    public class Etiqueta
    {
        //Atributos
        private string nombreEtiqueta;
        private string descripcionEtiqueta;

        //Constructor
        /// <summary>
        /// Constructor de una etiqueta, recibe el nombre y descripción de la etiqueta como strings.
        /// </summary>
        public Etiqueta(string nombreEtiqueta, string descripcionEtiqueta)
        {
            this.nombreEtiqueta = nombreEtiqueta;
            this.descripcionEtiqueta = descripcionEtiqueta;
        }

        //Getter y Setters
        /// <value> Devuelve o setea el nombre de la etiqueta </value>
        public string NombreEtiqueta { get => nombreEtiqueta; set => nombreEtiqueta = value; }
        /// <value> Devuelve o setea la descripcion de la etiqueta </value>
        public string DescripcionEtiqueta { get => descripcionEtiqueta; set => descripcionEtiqueta = value; }
    }
}
