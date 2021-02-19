using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
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
        public Respuesta(string contenido)
        {
            this.contenido = contenido;
            this.estado = "pendiente";
            idContador += 1;
            this.id = idContador;
            this.votos = 0;
            //Para conseguir la fecha:
            //Para conseguir la fecha:
            DateTime fechaActual = DateTime.Now;
            this.fecha = fechaActual.ToString("dd'/'MM'/'yyyy");
        }

        //Getters y setters
        public static int IdContador { get => idContador; set => idContador = value; }
        public Usuario Autor { get => autor; set => autor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }
        public int Votos { get => votos; set => votos = value; }
    }
}
