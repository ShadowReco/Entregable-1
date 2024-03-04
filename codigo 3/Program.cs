using System;

class Program
{
    static void Main(string[] args)
    {
        int añoActual = DateTime.Now.Year;

        Console.Write("Ingrese su año de nacimiento: ");
        int añoNacimiento = int.Parse(Console.ReadLine());

        int díasTotales = (añoActual - añoNacimiento) * 365;

        for (int año = añoNacimiento; año <= añoActual; año++)
        {
            if (EsBisiesto(año))
            {
                díasTotales++;
            }
        }

        Console.WriteLine($"Han pasado un total de {díasTotales} días desde el año {añoNacimiento} hasta el año actual.");
    }

    static bool EsBisiesto(int año)
    {
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }
}