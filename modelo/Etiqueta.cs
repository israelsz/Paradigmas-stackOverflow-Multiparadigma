using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public class Etiqueta
    {
        //Atributos
        private string nombreEtiqueta;
        private string descripcionEtiqueta;

        //Constructor
        public Etiqueta(string nombreEtiqueta, string descripcionEtiqueta)
        {
            this.nombreEtiqueta = nombreEtiqueta;
            this.descripcionEtiqueta = descripcionEtiqueta;
        }

        //Getter y Setters
        public string NombreEtiqueta { get => nombreEtiqueta; set => nombreEtiqueta = value; }
        public string DescripcionEtiqueta { get => descripcionEtiqueta; set => descripcionEtiqueta = value; }
    }
}
