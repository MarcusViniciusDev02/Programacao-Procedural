using System;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        int somaDiagonal = 0;
        
    //Entrada de números
        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());

                if (linha == coluna)
                {
                    somaDiagonal += matriz[linha, coluna];
                }
            }
        }

        System.Console.WriteLine(somaDiagonal);
     

    }
}