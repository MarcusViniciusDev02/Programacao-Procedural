using System;
public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 10; i >= 1; i--)
        {

            for (int j = 0; j <= 10; j++)
            {
                int tabuadaDeMultiplicacao = i * j;
                Console.WriteLine(i + " x " + j + " = " + tabuadaDeMultiplicacao);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}