using System;

namespace Ejercicios_sesión_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio 1 - While

            Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

            1 x 1 = 1
            1 x 2 = 2
            …
            1 x 10 = 10

            */

            Console.WriteLine("Ejercicio 1: ");
            Console.WriteLine("Escriba un número:");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (i<10) 
            {
                i++;
                Console.WriteLine(i+" x "+num+" = "+i*num);
            }

            /*
            Ejercicio 2 - Do while

            Escribe un programa que realice estos pasos:

            Reciba al menos un número por consola

            Determine si el número es positivo o negativo

            Presente un contador para cada tipo (positivo y negativo).

            Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.

             */

            Console.WriteLine("Ejercicio 2: ");
            Console.WriteLine("Escriba un número:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write($"El número:{num2} ");
            int cont = 0;

            if (num2 < 0)
            {
                Console.WriteLine("Es un número negativo");
                while (cont > num2)
                {
                    cont--;
                    Console.WriteLine("Número: "+ cont);
                }
            }
            else if (num2 > 0)
            {
                Console.WriteLine("Es un número positivo");
                while (cont < num2)
                {
                    cont++;
                    Console.WriteLine("Número: " + cont);
                }
            }
            else if (num2 == 0)
            {
                Console.WriteLine("Es un número sin valor");
            }


            /*
            Ejercicio 3 - For

            Escribe un programa que realice estos pasos:

            Reciba 3 datos:

            ancho

            alto

            relleno o no

            Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

            En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

            Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

            Input: 2,2,2, relleno = true

            Output:

            ** **

            ** **

            Input: 3, 4, 1, relleno = false

            Output:

            ***

            * *

            * *

            *** 
             */
            Console.WriteLine("Ejercicio 3: ");
            Console.WriteLine("Introduce el ancho:");
            int ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto:");
            int alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba 's' si desea que tenga relleno, si no escriba, cualquier otra tecla:");
            string relleno = Console.ReadLine();

            if (relleno.Contains('s'))
            {
                for (int r = 0; r < alto; r++)
                {
                    for (int p = 0; p < ancho; p++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                for (int r = 0; r < alto; r++)
                {
                    if (r == 0 || r == alto - 1)
                    {
                        for (int s = 0; s < ancho; s++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine("");
                    }

                    for (int p = 0; p < ancho; p++)
                    {
                        if (p == 0 || p == ancho - 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }
                    Console.WriteLine("");
                }
            }

        }
    }
}
