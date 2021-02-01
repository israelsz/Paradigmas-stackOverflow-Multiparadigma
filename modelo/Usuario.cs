using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public class Usuario
    {
        //Atributos
        private string username;
        private string password;
        private List<Pregunta> preguntasRealizadas;
        private List<Respuesta> respuestasRealizadas;
        private int reputacion;

        //Constructor
        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.preguntasRealizadas = new List<Pregunta>();
            this.respuestasRealizadas = new List<Respuesta>();
            this.reputacion = 50;
        }

        //Getter y Setters
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public List<Pregunta> PreguntasRealizadas { get => preguntasRealizadas; set => preguntasRealizadas = value; }
        public List<Respuesta> RespuestasRealizadas { get => respuestasRealizadas; set => respuestasRealizadas = value; }
        public int Reputacion { get => reputacion; set => reputacion = value; }

    }
}
