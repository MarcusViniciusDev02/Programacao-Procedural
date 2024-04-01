using System;

class Program
{
    static void Main (string[] args)
    {
        	const int TAMANHO_VETOR = 10;
        string[] vetorNomes = new string[TAMANHO_VETOR];
        int contador = 0;

        for(; contador < TAMANHO_VETOR; contador++)
        {
            vetorNomes[contador] = Console.ReadLine();
        }

        for (int i = TAMANHO_VETOR -1 ; i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                System.Console.WriteLine(vetorNomes[i]);
            }

        }
			
    }
}