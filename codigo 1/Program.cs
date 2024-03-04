class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Fracciones");
        Console.WriteLine("Ingrese la primera fracción (ejemplo '1/2'): ");
        string fraccion1 = Console.ReadLine();
        Console.WriteLine("Ingrese la segunda fracción (ejemplo '1/2'): ");
        string fraccion2 = Console.ReadLine();
        Console.WriteLine("Ingreselo con los signos identificando si es:(+, -, *, /): ");
        char operador = char.Parse(Console.ReadLine());

        
        string[] partesFraccion1 = fraccion1.Split('/');
        string[] partesFraccion2 = fraccion2.Split('/');
        int num1 = int.Parse(partesFraccion1[0]);
        int den1 = int.Parse(partesFraccion1[1]);
        int num2 = int.Parse(partesFraccion2[0]);
        int den2 = int.Parse(partesFraccion2[1]);

        
        switch (operador)
        {
            case '+':
                SumarFracciones(num1, den1, num2, den2);
                break;
            case '-':
                RestarFracciones(num1, den1, num2, den2);
                break;
            case '*':
                MultiplicarFracciones(num1, den1, num2, den2);
                break;
            case '/':
                DividirFracciones(num1, den1, num2, den2);
                break;
            default:
                Console.WriteLine("Numeros no Validos");
                break;
        }
    }

    static void SumarFracciones(int num1, int den1, int num2, int den2)
    {
        int numResultado = (num1 * den2) + (num2 * den1);
        int denResultado = den1 * den2;
        SimplificarFraccion(ref numResultado, ref denResultado);
        Console.WriteLine($"El resultado es: {numResultado}/{denResultado}");
    }

    static void RestarFracciones(int num1, int den1, int num2, int den2)
    {
        int numResultado = (num1 * den2) - (num2 * den1);
        int denResultado = den1 * den2;
        SimplificarFraccion(ref numResultado, ref denResultado);
        Console.WriteLine($"El resultado es: {numResultado}/{denResultado}");
    }

    static void MultiplicarFracciones(int num1, int den1, int num2, int den2)
    {
        int numResultado = num1 * num2;
        int denResultado = den1 * den2;
        SimplificarFraccion(ref numResultado, ref denResultado);
        Console.WriteLine($"El resultado es: {numResultado}/{denResultado}");
    }

    static void DividirFracciones(int num1, int den1, int num2, int den2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero tonto.");
            return;
        }
        int numResultado = num1 * den2;
        int denResultado = den1 * num2;
        SimplificarFraccion(ref numResultado, ref denResultado);
        Console.WriteLine($"El resultado es: {numResultado}/{denResultado}");
    }

    static int ObtenerMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void SimplificarFraccion(ref int num, ref int den)
    {
        int mcd = ObtenerMCD(num, den);
        num /= mcd;
        den /= mcd;
    }
}