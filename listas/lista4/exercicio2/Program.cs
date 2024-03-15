using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite o número de linhas: ");
        int tamanhoLinhas = int.Parse(Console.ReadLine());
        int contador;

        for (int linhas = 0; linhas < tamanhoLinhas; linhas++)
        {
            contador = 1;
            for (int colunas = 0; colunas <= linhas; colunas++)
            {
                System.Console.Write(contador);
                contador++;
            }
            System.Console.WriteLine();

        }
    }
}
