class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero para identificar si 'especial'");
        Console.Write("Ingrese el  número: ");
        int numero = int.Parse(Console.ReadLine());

        bool esEspecial = EsEspecial(numero);

        if (esEspecial)
        {
            Console.WriteLine($"El número {numero} es especial.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es especial.");
        }
    }

    static bool EsEspecial(int num)
    {
        if (num % 5 != 0)
        {
            return false;
        }

        if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }

        return true;
    }
}