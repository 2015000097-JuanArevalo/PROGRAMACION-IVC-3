using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, opc;

        Console.WriteLine("==== Calculadora Básica ====");

        Console.Write("Digite el primer número entero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el segundo número entero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("Suma - 1");
        Console.WriteLine("Resta - 2");
        Console.WriteLine("Multiplicación - 3");
        Console.WriteLine("División - 4");

        Console.Write("Digite la opción: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("La suma es: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("La resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("La multiplicación es: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("La división es: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("ERROR AL OPERAR LOS NÚMEROS");
                break;
        }
    }
}