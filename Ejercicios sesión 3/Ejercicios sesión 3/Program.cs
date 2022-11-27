using System;

namespace Ejercicios_sesión_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente usuarioCli = new Cliente("Christian", "Diaz", 093233, "Street 123", "correo@gmail.com", true);
            Console.WriteLine("Cliente: \nNombre: " + usuarioCli.nombre + "\nApellido: " + usuarioCli.apellido + "" +
                "\nTeléfono: " + usuarioCli.telefono + "\nDirección: " + usuarioCli.direccion + "\nEmail: " + usuarioCli.email + "" +
                "\nEs cliente: " + usuarioCli.newCliente);
            
        }
        public struct Cliente
        {
            public Cliente(String Nombre, String Apellido, float Telefono, String Direccion, String Email, Boolean NewCliente)
            {
                nombre = Nombre;
                apellido = Apellido;
                telefono = Telefono;
                direccion = Direccion;
                email = Email;
                newCliente = NewCliente;

            }
            public String nombre { get; set; }
            public String apellido { get; set; }
            public float telefono { get; set; }
            public String direccion { get; set; }
            public String email { get; set; }
            public bool newCliente { get; set; }

            public override string ToString() => $"({nombre}, {apellido}, {telefono}, {direccion}, {email}, {newCliente},)";

        }

    }
}
