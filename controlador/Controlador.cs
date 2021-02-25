using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controlador
{
    public class Controlador
    {
        //Atributos
        //Modelo
        private Stack stack;
        private bool stackInicialLleno;
        private static Controlador instancia;

        //Constructor
        public Controlador()
        {
            this.stack = new Stack();
            this.stackInicialLleno = false;
        }

        //Metodos
        public static Controlador Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controlador();
                }
                return instancia;
            }

        }

        public bool StackInicialLleno { get => stackInicialLleno; set => stackInicialLleno = value; }

        public void llenarStackInicial()
        {
            //Etiquetas
            if (StackInicialLleno == false)
            {
                Etiqueta etiqueta1 = new Etiqueta("Python", "python es un lenguaje interpretado, multiparadigma que busca favorecer un codigo legible");
                List<Etiqueta> listaEtiqueta1 = new List<Etiqueta>();
                stack.Etiquetas.Add(etiqueta1);
                listaEtiqueta1.Add(etiqueta1);
                Etiqueta etiqueta2 = new Etiqueta("C", "C es un lenguaje de alto rendimiento de proposito general fuertemente tipado");
                List<Etiqueta> listaEtiqueta2 = new List<Etiqueta>();
                stack.Etiquetas.Add(etiqueta2);
                listaEtiqueta2.Add(etiqueta2);
                Etiqueta etiqueta3 = new Etiqueta("Java", "Java es un lenguaje de programacion de proposito general, que soporta la orientacion a objetos");
                List<Etiqueta> listaEtiqueta3 = new List<Etiqueta>();
                stack.Etiquetas.Add(etiqueta3);
                listaEtiqueta3.Add(etiqueta3);

                Pregunta pregunta1 = new Pregunta("Como hacer hola mundo en python",
                    "Como el titulo dice, no conozco la funcion necesaria para poder mostrar hola mundo por pantalla en python",
                    listaEtiqueta1);
                //Fecha 16/11/2020
                Pregunta pregunta2 = new Pregunta("Asignar memoria a un arreglo en C",
                        "En C ¿como puedo asignar memoria a un arreglo?",
                        listaEtiqueta2);
                //Fecha 16/11/2020
                Pregunta pregunta3 = new Pregunta("como printear cosas en java ?",
                        "Hola soy nuevo al lenguaje java, que metodo puedo usar para printear una string por ejemplo ?",
                        listaEtiqueta3);
                //Fecha 16/11/2020
                Pregunta pregunta4 = new Pregunta("librerias en python",
                        "Hola como puedo instalar una libreria en python?",
                        listaEtiqueta1);
                //Fecha 17/11/2020
                Pregunta pregunta5 = new Pregunta("definir clases en java",
                        "¿Como puedo crear una nueva clase en java?",
                        listaEtiqueta3);
                //Fecha 17/11/2020
                Usuario usuario1 = new Usuario("israel", "qwerty");
                Usuario usuario2 = new Usuario("pedro", "123");
                Usuario usuario3 = new Usuario("juan", "asd");
                Usuario usuario4 = new Usuario("maria", "hola123");



                Respuesta respuesta1 = new Respuesta("Hola, puedes usar malloc para asignarle memoria");
                //Fecha 18/11/2020
                Respuesta respuesta2 = new Respuesta("Intenta usar print(Hola mundo)");
                //Fecha 18/11/2020
                Respuesta respuesta3 = new Respuesta("Tambien puedes asignar la cantidad de elementos del arreglo, como int *arreglo[100]");
                //Fecha 18/11/2020
                Respuesta respuesta4 = new Respuesta("public class *nombre clase*, puedes cambiar el public a privado o al que necesites");
                //Fecha 19/11/2020
                Respuesta respuesta5 = new Respuesta("en la cmd usa el comando pip install *nombreLibreria*");
                //Fecha 19/11/2020
                Respuesta respuesta6 = new Respuesta("debes indicar la visibilidad el tipo de clase (public,private,abstract,etc) y su nombre");
                //Fecha 19/11/2020
                Respuesta respuesta7 = new Respuesta("el metodo  System.out.println(); deberia cumplir lo que quieres");
                //Fecha 19/11/2020
                Respuesta respuesta8 = new Respuesta("aportando a la respuesta anterior, dentro de los parentesis debes indicar lo que quieres imprimir");
                //Fecha 20/11/2020
                Respuesta respuesta9 = new Respuesta("Un ejemplo puede ser public class nuevaClase { }");
                //Fecha 20/11/2020
                Respuesta respuesta10 = new Respuesta("podrias usar print, muestra cosas por pantalla");
                //Fecha 20/11/2020

                pregunta1.Autor = usuario1;
                pregunta1.Fecha = "16/11/2020";
                pregunta1.Respuestas.Add(respuesta2);

                respuesta2.Autor = usuario2;
                respuesta2.Fecha = "18/11/2020";
                usuario2.RespuestasRealizadas.Add(respuesta2);

                pregunta1.Respuestas.Add(respuesta10);
                respuesta10.Autor = usuario3;
                respuesta10.Fecha = "20/11/2020";
                usuario3.RespuestasRealizadas.Add(respuesta10);
                usuario1.PreguntasRealizadas.Add(pregunta1);

                pregunta2.Fecha = "16/11/2020";
                pregunta2.Autor = usuario2;

                pregunta2.Respuestas.Add(respuesta1);
                respuesta1.Autor = usuario1;
                respuesta1.Fecha = "18/11/2020";
                usuario1.RespuestasRealizadas.Add(respuesta1);

                pregunta2.Respuestas.Add(respuesta3);
                respuesta3.Autor = usuario4;
                respuesta3.Fecha = "18/11/2020";
                usuario4.RespuestasRealizadas.Add(respuesta3);
                usuario2.PreguntasRealizadas.Add(pregunta2);

                pregunta3.Fecha = "16/11/2020";
                pregunta3.Autor = usuario3;

                pregunta3.Respuestas.Add(respuesta7);
                respuesta7.Autor = usuario1;
                respuesta7.Fecha = "19/11/2020";
                usuario1.RespuestasRealizadas.Add(respuesta7);

                pregunta3.Respuestas.Add(respuesta8);
                respuesta8.Autor = usuario4;
                respuesta8.Fecha = "20/11/2020";
                usuario4.RespuestasRealizadas.Add(respuesta8);
                usuario3.PreguntasRealizadas.Add(pregunta3);

                pregunta4.Fecha = "17/11/2020";
                pregunta4.Autor = usuario4;

                pregunta4.Respuestas.Add(respuesta5);
                respuesta5.Autor = usuario1;
                respuesta5.Fecha = "19/11/2020";
                usuario1.RespuestasRealizadas.Add(respuesta5);
                usuario4.PreguntasRealizadas.Add(pregunta4);

                pregunta5.Fecha = "17/11/2020";
                pregunta5.Autor = usuario3;

                pregunta5.Respuestas.Add(respuesta4);
                respuesta4.Autor = usuario4;
                respuesta4.Fecha = "19/11/2020";
                usuario4.RespuestasRealizadas.Add(respuesta4);

                pregunta5.Respuestas.Add(respuesta6);
                respuesta6.Autor = usuario1;
                respuesta6.Fecha = "19/11/2020";
                usuario1.RespuestasRealizadas.Add(respuesta6);

                pregunta5.Respuestas.Add(respuesta9);
                respuesta9.Autor = usuario2;
                respuesta9.Fecha = "20/11/2020";
                usuario2.RespuestasRealizadas.Add(respuesta9);
                usuario3.PreguntasRealizadas.Add(pregunta5);

                //Se agregan las preguntas y usuarios al stack
                stack.Preguntas.Add(pregunta1);
                stack.Preguntas.Add(pregunta2);
                stack.Preguntas.Add(pregunta3);
                stack.Preguntas.Add(pregunta4);
                stack.Preguntas.Add(pregunta5);

                stack.Usuarios.Add(usuario1);
                stack.Usuarios.Add(usuario2);
                stack.Usuarios.Add(usuario3);
                stack.Usuarios.Add(usuario4);

                stackInicialLleno = true;
            }

        }

        public bool Register(string username, string password)
        {
            //Se verifica en primer lugar que no exista el usuario:
            if (stack.Usuarios.Any(i => i.Username == username)) {
                //Se encontro un usuario que ya tiene el mismo nombre de usuario
                return false;
            } else
            {   //Si el usuario no se encuentra registrado
                Usuario nuevoUsuario = new Usuario(username, password);
                stack.Usuarios.Add(nuevoUsuario);
                return true;
            }

        }

        public bool Login(string username, string password)
        {
            //Se verifica la existencia del usuario en el stack
            if (stack.Usuarios.Any(i => i.Username == username && i.Password == password))
            {
                //Si se encontro al usuario y su contraseña corresponde se establece como usuario conectado
                stack.UsuarioConectado = stack.Usuarios.Find(i => i.Username == username);
                //Se cambia el estado del stack, ahora hay alguien conectado
                stack.Conectado = true;
                //Retorna true al haberse podido loguear
                return true;
            }
            return false;
        }

        public bool IsUserConnected()
        {
            if(stack.Conectado == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string getLoggedUsername()
        {
            if (stack.Conectado == true)
            {
                return stack.UsuarioConectado.Username;
            }
            return "";
        }

        public List<Pregunta> GetPreguntas()
        {
            return stack.Preguntas;
        }

        public void Logout()
        {
            stack.Conectado = false;

        }

        public string getTitulo(int indice)
        {
            return stack.Preguntas[indice].Titulo;
        }

        public string getContenido(int indice)
        {
            return stack.Preguntas[indice].Contenido;
        }

        public List<Etiqueta> GetQuestionLabels(int indice)
        {
            return stack.Preguntas[indice].Etiquetas;
        }

        public List<Respuesta> GetRespuestas(int indice)
        {
            return stack.Preguntas[indice].Respuestas;
        }

        public string getQuestionFecha(int indice)
        {
            return stack.Preguntas[indice].Fecha;
        }

        public int getQuestionVotes(int indice)
        {
            return stack.Preguntas[indice].Votos;
        }

        public string GetQuestionStatus(int indice)
        {
            return stack.Preguntas[indice].Estado;
        }

        public string GetQuestionAutor(int indice)
        {
            return stack.Preguntas[indice].Autor.Username;
        }

        public int GetQuestionId(int indice)
        {
            return stack.Preguntas[indice].Id;
        }

        public Pregunta GetQuestionbyIndex(int indice)
        {
            return stack.Preguntas[indice];
        }

        public int GetQuestionReward(int indice)
        {
            return stack.Preguntas[indice].Recompensa;
        }

        public int GetUserReputation()
        {
            return stack.UsuarioConectado.Reputacion;
        }

        public string GetAnswerAutor(Respuesta respuesta)
        {
            return respuesta.Autor.Username;
        }

        public List<Usuario> GetAllUsers()
        {
            return stack.Usuarios;
        }
        public void Answer(Pregunta pregunta, string contenido)
        {
            //Se crea la respuesta
            Respuesta respuesta = new Respuesta(contenido);
            //Se consigue al autor de la respuesta y se asigna
            respuesta.Autor = stack.UsuarioConectado;
            //Se agrega la respuesta creada al usuario correspondiente
            stack.UsuarioConectado.RespuestasRealizadas.Add(respuesta);
            //Se añade la respuesta a la lista de respuestas de la pregunta
            pregunta.Respuestas.Add(respuesta);
        }

        public List<Etiqueta> GetEtiquetas()
        {
            return stack.Etiquetas;
        }

        public void Ask(string titulo, string contenido, List<Etiqueta> etiquetas)
        {
            //Se crea la pregunta
            Pregunta pregunta = new Pregunta(titulo, contenido, etiquetas);
            //Se agrega al autor de la pregunta
            pregunta.Autor = stack.UsuarioConectado;
            //Se agrega la pregunta al stack
            stack.Preguntas.Add(pregunta);
            //Se agrega la pregunta al usuario que la hizo
            stack.UsuarioConectado.PreguntasRealizadas.Add(pregunta);
        }

        public bool CrearEtiqueta(string nombre, string descripcion)
        {
            //Se verifica que no exista una etiqueta con el mismo nombre
            if (stack.Etiquetas.Any(i => i.NombreEtiqueta == nombre)) {
                //Se encontro una etiqueta con el mismo nombre
                return false;
            }
            else
            {
                //Si no existe una etiqueta con el mismo nombre, se creara
                Etiqueta etiqueta = new Etiqueta(nombre, descripcion);
                //Se agrega la etiqueta creada al stack
                stack.Etiquetas.Add(etiqueta);
                return true;
            }
        }

        public bool Reward(Pregunta pregunta, int recompensaOfrecida)
        {
            //Se verifica que la recompensa ofrecida sea menor o igual a la recompensa del usuario y mayor a cero
            if (recompensaOfrecida <= stack.UsuarioConectado.Reputacion && recompensaOfrecida > 0)
            {
                //Se añade la recompensa a la pregunta
                pregunta.Recompensa = pregunta.Recompensa + recompensaOfrecida;
                //Se descuenta la recompensa al usuario
                stack.UsuarioConectado.Reputacion = stack.UsuarioConectado.Reputacion - recompensaOfrecida;
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Pregunta> GetPreguntasByConnectedUser()
        {
            return stack.UsuarioConectado.PreguntasRealizadas;
        }

        public bool Accept(Pregunta pregunta,Respuesta respuesta)
        {
            //Se verifica si la pregunta ya se encuentra aceptada
            if(pregunta.Estado != "abierta")
            {
                return false;
            }
            //En primer lugar se cambian los estados tanto de la pregunta como la respuesta
            pregunta.Estado = "Cerrada";
            respuesta.Estado = "Aceptada";
            //Se fija la nueva reputacion, la cual es la reputacion actual del usuario + la recompensa por la pregunta + 15 por haber sido su respuesta aceptada
            respuesta.Autor.Reputacion = respuesta.Autor.Reputacion + pregunta.Recompensa + 15;
            //Se reinicia la recompensa de la pregunta
            pregunta.Recompensa = 0;
            //Se le otorgaran los 2 de recompensa al usuario que acepto la respuesta
            stack.UsuarioConectado.Reputacion = stack.UsuarioConectado.Reputacion + 2;
            return true;
        }

        //Vote para preguntas
        public void Vote(Pregunta pregunta, bool voto)
        {
            //Si el voto es positivo
            if (voto)
            {
                //Se suma el voto
                pregunta.Votos = pregunta.Votos + 1;
                //Se agregan 10 puntos a favor para la persona cuya pregunta fue votada a favor
                pregunta.Autor.Reputacion = pregunta.Autor.Reputacion + 10;
            }
            //Si el voto es negativo
            else
            {
                //Se resta el voto
                pregunta.Votos = pregunta.Votos - 1;
                //Se quitan 2 puntos de reputacion para la persona cuya pregunta fue votada en contra
                pregunta.Autor.Reputacion = pregunta.Autor.Reputacion - 2;
            }
        }

        //Vote para respuestas
        public void Vote(Respuesta respuesta, bool voto)
        {
            //Si el voto es positivo
            if (voto)
            {
                //Se suma el voto
                respuesta.Votos = respuesta.Votos + 1;
                //Se agregan 10 puntos a favor para la persona cuya respuesta fue votada a favor
                respuesta.Autor.Reputacion = respuesta.Autor.Reputacion + 10;
            }
            //Si el voto es negativo
            else
            {
                //Se resta el voto
                respuesta.Votos = respuesta.Votos - 1;
                //Se quitan 2 puntos de reputacion para la persona cuya pregunta fue votada en contra
                respuesta.Autor.Reputacion = respuesta.Autor.Reputacion - 2;
                //Se resta 1 punto al usuario que voto en contra de otra respuesta
                stack.UsuarioConectado.Reputacion = stack.UsuarioConectado.Reputacion - 1;
            }
        }
    }
}
