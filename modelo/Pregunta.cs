using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Pregunta contiene todas las caracteristicas que posee una pregunta.
    /// </summary>
    public class Pregunta
    {
        //Atributos
        private static int idContador = 0;
        private List<Respuesta> respuestas;
        private string titulo;
        private string contenido;
        private string fecha;
        private Usuario autor;
        private string estado;
        private int recompensa;
        private int id;
        private int votos;
        private List<Etiqueta> etiquetas;

        //Constructor
        /// <summary>
        /// Constructor de una pregunta, recibe un titulo, contenido y lista de etiquetas para la pregunta.
        /// </summary>
        public Pregunta(string titulo, string contenido, List<Etiqueta> etiquetas)
        {
            this.titulo = titulo;
            this.contenido = contenido;
            this.etiquetas = etiquetas;
            this.recompensa = 0;
            this.estado = "abierta";
            this.respuestas = new List<Respuesta>();
            this.etiquetas = etiquetas;
            idContador += 1;
            this.id = idContador;
            this.votos = 0;
            //Para conseguir la fecha:
            DateTime fechaActual = DateTime.Now;
            this.fecha = fechaActual.ToString("dd'/'MM'/'yyyy");
        }
        //Getters y Setters
        /// <value> Devuelve o setea el valor del contador autoincremental </value>
        public static int IdContador { get => idContador; set => idContador = value; }
        /// <value> Devuelve o setea la lista de respuestas de la pregunta </value>
        public List<Respuesta> Respuestas { get => respuestas; set => respuestas = value; }
        /// <value> Devuelve o setea el titulo de la pregunta </value>
        public string Titulo { get => titulo; set => titulo = value; }
        /// <value> Devuelve o setea el contenido de la pregunta </value>
        public string Contenido { get => contenido; set => contenido = value; }
        /// <value> Devuelve o setea la fecha de publicacion de la pregunta </value>
        public string Fecha { get => fecha; set => fecha = value; }
        /// <value> Devuelve o setea al Autor de la pregunta </value>
        public Usuario Autor { get => autor; set => autor = value; }
        /// <value> Devuelve o setea el estado de la pregunta </value>
        public string Estado { get => estado; set => estado = value; }
        /// <value> Devuelve o setea la recompensa de la pregunta </value>
        public int Recompensa { get => recompensa; set => recompensa = value; }
        /// <value> Devuelve o setea el id de la pregunta </value>
        public int Id { get => id; set => id = value; }
        /// <value> Devuelve o setea la cantidad de votos de la pregunta </value>
        public int Votos { get => votos; set => votos = value; }
        /// <value> Devuelve o setea la lista de etiquetas de la pregunta </value>
        public List<Etiqueta> Etiquetas { get => etiquetas; set => etiquetas = value; }
    }
}
