using System;

class Program
{
    public static void Main(string[] args)
    {
        int linha = int.Parse(Console.ReadLine());
        int coluna = int.Parse(Console.ReadLine());

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}