using System;

namespace Ejercicios_sesión_2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  //Ejercicio 1
            Console.WriteLine("Ejercicio 1: ");
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
            */ /*
            Console.WriteLine("Ejercicio 2: ");
            Console.WriteLine("¿Cuantas puertas tiene el coche?");
            int puerta = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas ruedas tiene el coche?");
            int ruedas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Que marca es el coche?");
            String marca = Console.ReadLine();
            Console.WriteLine("¿Que color es el coche?");
            String color = Console.ReadLine();
            
            Console.WriteLine("Su coche es: \nMarca: " + marca + "\nTiene: " + puerta + " puertas \nTiene :  " + ruedas + " ruedas \nColor:  " + color);

            //Ejercicio 3
            /*
             * Operadores Determina los operadores para verificar las siguientes condiciones:
            Un número es mayor o igual a 18
            Un char es ‘a’
            Se cumplen dos conciones a la vez (ambas verdaderas)
            Se cumple una de dos condiciones a la vez (una true y otra false)
            */
            Console.WriteLine("Ejercicio 3: ");
            Console.WriteLine("Escriba un número");
            int Num = int.Parse(Console.ReadLine());
            if (Num > 18)
            {
                Console.WriteLine("El número " + Num + " es mayor a 18");
            }
            else if (Num < 18)
            {
                Console.WriteLine("El número " + Num + " es menor a 18");
            }
            else if (Num == 18)
            {
                Console.WriteLine("El número " + Num + " es igual a 18");
            }

            Console.WriteLine("Escriba el caracter 'a'");
            char a = char.Parse(Console.ReadLine());
            if (a == 'a')
            {
                Console.WriteLine("El caracter es a");
            }
            else
            {
                Console.WriteLine("El caracter no es a");

            }
        }
    }
}
