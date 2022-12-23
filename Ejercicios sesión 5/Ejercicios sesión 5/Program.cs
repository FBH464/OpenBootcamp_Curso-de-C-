using System;

namespace Ejercicios_sesión_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio 1 - If

            Escribe un programa que:

            Pida datos a un cliente: Nombre, email, cupón

            Determine si un cliente tiene un cupon descuento

            Muestre un precio rebajado en función del descuento

            Muestre el precio de un producto sin descuento si no hay cupón

            Nota: puedes poner un precio fijo de un producto o uno variable.
            */
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Escriba su nombre:");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escriba su email:");
            String email = Console.ReadLine();

            Console.WriteLine("Escribe 'si' si tienes cupón, si no escribe 'no':");
            string cupon = Console.ReadLine();

            double precio = 46.20;
            double descuento = (precio * 10) / 100;
            if (cupon == "si")
            {
                Console.WriteLine("Tienes un descuento del 10%");
                Console.WriteLine("El precio del producto con descuento es de " + (precio - descuento));
            }
            else
            {
                Console.WriteLine($"El precio del producto es de {precio}");
            }
            /*
            Ejercicio 2 - Switch

            Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

            Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
             */
            Console.WriteLine("Ejercicio 2");
            string[] languages = { "C#", "Java", "C++" };

            // Presentamos la lista de lenguajes de programación
            for (int i = 0; i < languages.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {languages[i]}");
            }

            // Pedimos al usuario que seleccione un lenguaje
            Console.Write("Selecciona un lenguaje de programación mediante 1(a), 2(b) o 3(c): ");
            string selection = Console.ReadLine();

            // Mostramos el resultado en consola
            if (selection == "1" || selection == "a")
            {
                Console.WriteLine($"Has seleccionado el lenguaje de programación {languages[0]}");
            }
            else if (selection == "2" || selection == "b")
            {
                Console.WriteLine($"Has seleccionado el lenguaje de programación {languages[1]}");
            }
            else if (selection == "3" || selection == "c")
            {
                Console.WriteLine($"Has seleccionado el lenguaje de programación {languages[2]}");
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

        }
    }
}
