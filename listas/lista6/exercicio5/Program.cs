using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        int[] vetor = new int[TAMANHO_VETOR];
        int numero = 0;
        int indice = 0;

        while (indice < TAMANHO_VETOR)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
            {
                vetor[indice] = numero;
                indice++;
            }
        }

        System.Console.WriteLine("Saída");
        for (int i = 0; i < indice; i++)
        {
            Console.WriteLine(vetor[i]);
        }


    }
}