using System;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.WriteLine("Introduce tu nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Hola, Bienvenido " + nombre);
            //Ejercicio 2

            String fecha = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(fecha);

        }
    }
}
