using System;

class Program
{
    static void Main(string[] args)
    {
        string usuarioDefinido = "admin";
        string contraseñaDefinida = "12345";

        int intentos = 3;

        while (intentos > 0)
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == usuarioDefinido && contraseña == contraseñaDefinida)
            {
                Console.WriteLine("Acceso concedido");
                return;
            }
            else
            {
                intentos--;
                if (intentos > 0)
                {
                    Console.WriteLine($"Nombre de usuario o contraseña incorrectos. Intentos restantes: {intentos}");
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                    return;
                }
            }
        }
    }
}