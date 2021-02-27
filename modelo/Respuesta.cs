using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Respuesta contiene todas las caracteristicas que posee una respuesta.
    /// </summary>
    public class Respuesta
    {
        //Atributos
        private static int idContador = 0;
        private Usuario autor;
        private string fecha;
        private string contenido;
        private string estado;
        private int id;
        private int votos;

        //Constructor
        /// <summary>
        /// Constructor de una respuesta, recibe el contenido a publicar.
        /// </summary>
        public Respuesta(string contenido)
        {
            this.contenido = contenido;
            this.estado = "pendiente";
            idContador += 1;
            this.id = idContador;
            this.votos = 0;
            //Para conseguir la fecha:
            DateTime fechaActual = DateTime.Now;
            this.fecha = fechaActual.ToString("dd'/'MM'/'yyyy");
        }

        //Getters y setters
        /// <value> Devuelve o setea el valor del contador autoincremental </value>
        public static int IdContador { get => idContador; set => idContador = value; }
        /// <value> Devuelve o setea al autor de la respuesta </value>
        public Usuario Autor { get => autor; set => autor = value; }
        /// <value> Devuelve o setea la fecha de publicacion de la respuesta </value>
        public string Fecha { get => fecha; set => fecha = value; }
        /// <value> Devuelve o setea el contenido de la respuesta </value>
        public string Contenido { get => contenido; set => contenido = value; }
        /// <value> Devuelve o setea el estado de la respuesta </value>
        public string Estado { get => estado; set => estado = value; }
        /// <value> Devuelve o setea el id de la respuesta </value>
        public int Id { get => id; set => id = value; }
        /// <value> Devuelve o setea los votos de la respuesta </value>
        public int Votos { get => votos; set => votos = value; }
    }
}
