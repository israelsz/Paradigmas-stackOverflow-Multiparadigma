using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Usuario contiene todas las caracteristicas que posee un usuario.
    /// </summary>
    public class Usuario
    {
        //Atributos
        private string username;
        private string password;
        private List<Pregunta> preguntasRealizadas;
        private List<Respuesta> respuestasRealizadas;
        private int reputacion;

        //Constructor
        /// <summary>
        /// Constructor de un Usuario, recibe el nombre de usuario y contraseña del nuevo usuario.
        /// </summary>
        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.preguntasRealizadas = new List<Pregunta>();
            this.respuestasRealizadas = new List<Respuesta>();
            this.reputacion = 50;
        }

        //Getter y Setters
        /// <value> Devuelve o setea el nombre del usuario </value>
        public string Username { get => username; set => username = value; }
        /// <value> Devuelve o setea la contraseña del usuario </value>
        public string Password { get => password; set => password = value; }
        /// <value> Devuelve o setea la lista de preguntas realizadas por el usuario </value>
        public List<Pregunta> PreguntasRealizadas { get => preguntasRealizadas; set => preguntasRealizadas = value; }
        /// <value> Devuelve o setea la lista de respuestas realizadas por el usuario </value>
        public List<Respuesta> RespuestasRealizadas { get => respuestasRealizadas; set => respuestasRealizadas = value; }
        /// <value> Devuelve o la reputacion del usuario </value>
        public int Reputacion { get => reputacion; set => reputacion = value; }

    }
}
