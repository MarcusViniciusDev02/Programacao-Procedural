using System;

class Program
{
    static void Main(string[] args)
    {

        for (int num1 = 1; num1 <= 10; num1++)
        {
            System.Console.WriteLine("Tabuada de: " + num1);
            for (int num2 = 1; num2 <= 10; num2++ )
            {
                int multiplicacaoTabuada = num1 * num2;
                System.Console.WriteLine(num1 + "x" + num2 + "= " + multiplicacaoTabuada);
            }
            System.Console.WriteLine();
        }

    }
}
