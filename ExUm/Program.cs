using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um numero para A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Digite outro numero para B: ");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int C = 0;

        C = A;
        A = B;
        B = C;
        

        // A: B
        // B: C
        // C: A

        Console.WriteLine($"Valor de A: {A}");
        Console.WriteLine($"Valor de B: {B}");

        Console.ReadKey();
    }
}