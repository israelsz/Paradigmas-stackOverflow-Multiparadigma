using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Stack contiene todas las caracteristicas que posee el stack para almacenar toda la informacion.
    /// </summary>
    public class Stack
    {
        //Atributos
        private List<Pregunta> preguntas;
        private List<Usuario> usuarios;
        private Usuario usuarioConectado;
        private bool conectado = false;
        private List<Etiqueta> etiquetas;

        //Constructor
        /// <summary>
        /// Constructor de un Stack, inicializa listas para almacenar datos.
        /// </summary>
        public Stack()
        {
            this.preguntas = new List<Pregunta>();
            this.usuarios = new List<Usuario>();
            this.etiquetas = new List<Etiqueta>();
        }

        //Getters y Setters
        /// <value> Devuelve o setea la lista de preguntas del stack </value>
        public List<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
        /// <value> Devuelve o setea la lista de usuarios del stack </value>
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        /// <value> Devuelve o setea al usuario conectado actualmente en el stack </value>
        public Usuario UsuarioConectado { get => usuarioConectado; set => usuarioConectado = value; }
        /// <value> Devuelve o setea el valor de si hay alguien conectado en el stack o no </value>
        public bool Conectado { get => conectado; set => conectado = value; }
        /// <value> Devuelve o setea la lista de etiquetas del stack </value>
        public List<Etiqueta> Etiquetas { get => etiquetas; set => etiquetas = value; }
    }
}
