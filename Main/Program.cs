using controlador;
using modelo;
using System;
using vista;

namespace Main
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Punto de partida de el programa
            //Se crea el modelo
            Stack stack = new Stack();
            //Se crea el controlador y se le entrega al modelo como entrada
            Controlador controlador = new Controlador(stack);
            //Se crea la vista y se le entrega al controlador como entrada
            System.Windows.Application app = new System.Windows.Application();
            app.Run(new VentanaInicial(controlador));
        }
    }
}
