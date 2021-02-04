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
         private Stack stack; //Modelo

        //Constructor
        public Controlador(Stack stack)
        {
            this.stack = stack; //El controlador toma del modelo a stack para controlarlo
        }

        //Metodos
        public bool Register(string username, string password)
        {
            //Se verifica en primer lugar que no exista el usuario:
            if(stack.Usuarios.Any(i=>i.Username == username)){
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
            if(stack.Usuarios.Any(i=>i.Username == username && i.Password == password))
            {
                //Si se encontro al usuario y su contraseña corresponde se establece como usuario conectado
                stack.UsuarioConectado = stack.Usuarios.Find(i => i.Username == username);
                Console.WriteLine("Usuario conectado = " + stack.UsuarioConectado.Username);
                return true;
            }
            return false;
        }
    }
}
