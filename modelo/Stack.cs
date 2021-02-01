using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public class Stack
    {
        //Atributos
        private List<Pregunta> preguntas;
        private List<Usuario> usuarios;
        private Usuario usuarioConectado;
        private bool conectado = false;
        private List<Etiqueta> etiquetas;

        //Constructor
        public Stack()
        {
        }

        //Getters y Setters
        public List<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public Usuario UsuarioConectado { get => usuarioConectado; set => usuarioConectado = value; }
        public bool Conectado { get => conectado; set => conectado = value; }
        public List<Etiqueta> Etiquetas { get => etiquetas; set => etiquetas = value; }
    }
}
