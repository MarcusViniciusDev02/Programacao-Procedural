using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(matriz);
        ChecarBalisca(matriz);
    }


    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void ChecarBalisca(int[,] matriz)
    {
        bool baliscaCheck = false;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == 0)
                {
                    baliscaCheck = true;
                }

            }
        }
        if (baliscaCheck == true)
        {
            System.Console.WriteLine("Fique atento! existem Balistas no tabuleiro");
        }
        else
        {
            System.Console.WriteLine("Não há Balistas, pode relaxar.");
        }
    }

}