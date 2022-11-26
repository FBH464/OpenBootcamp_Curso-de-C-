using System;

namespace Ejercicios_sesión_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Ejercicio 1
            String Nombre;
            String Apellido;
            int edad;
            String programar;

            Console.WriteLine("Escriba su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Sabe programar?:");
            programar = Console.ReadLine();

            Console.WriteLine("Hola, Bienvenido " + Nombre + " " + Apellido + "\nSu edad es: " + edad + "\nSabe programar: " + programar);
            //Ejercicio 2

            /*Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
            Coche: puertas, ruedas, marca, ITV vigente
            Mesa: peso, largo, material, color
            */
            String


            //Ejercicio 3
            /*
             * Operadores Determina los operadores para verificar las siguientes condiciones:
            Un número es mayor o igual a 18
            Un char es ‘a’
            Se cumplen dos conciones a la vez (ambas verdaderas)
            Se cumple una de dos condiciones a la vez (una true y otra false)
            */

}
}
}
