using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
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
            this.fecha = fechaActual.ToString("dd/MM/yyyy");
        }
        //Getters y Setters
        public static int IdContador { get => idContador; set => idContador = value; }
        public List<Respuesta> Respuestas { get => respuestas; set => respuestas = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public Usuario Autor { get => autor; set => autor = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Recompensa { get => recompensa; set => recompensa = value; }
        public int Id { get => id; set => id = value; }
        public int Votos { get => votos; set => votos = value; }
        public List<Etiqueta> Etiquetas { get => etiquetas; set => etiquetas = value; }
    }
}
