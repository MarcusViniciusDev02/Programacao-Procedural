using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 3;
        int[] vetor = new int[TAMANHO_VETOR];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        int resultado = PegarMaiorElemento(vetor);

        System.Console.WriteLine($"resultado: {resultado}");
    }

    static int PegarMaiorElemento(int[] vetor)
    {
        int maiorNumero = int.MinValue;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maiorNumero)
            {
                maiorNumero = vetor[i];
            }
        }
        return maiorNumero;
    }
}