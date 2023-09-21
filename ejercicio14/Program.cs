// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class program
{
    static void Main(string[] args)
    {
        int sumPares = 0;
        int sumImpares = 0;

        for (int i = 2; i <= 100; i += 2)
        {
            Console.WriteLine(i);
            sumPares += i;
        }

        for (int i = 1; i <= 100; i += 2)
        {
            Console.WriteLine(i);
            sumImpares += i;
        }

        Console.WriteLine("Suma de los números pares: " + sumPares);
        Console.WriteLine("Suma de los números impares: " + sumImpares);
    }
}