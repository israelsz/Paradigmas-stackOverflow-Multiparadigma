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
         private Stack stack;

        //Constructor
        public Controlador()
        {
            this.stack = new Stack(); //El controlador toma del modelo a stack para controlarlo
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
    }
}
