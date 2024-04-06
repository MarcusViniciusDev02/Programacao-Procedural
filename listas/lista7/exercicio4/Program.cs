using System;

class Program
{
    static void Main(string[] args) 
    {
        const int TAMANHO_VETOR = 12;
        int[] pesoVagao = new int[TAMANHO_VETOR];
        Console.WriteLine("Insira o peso de cada vagão");
        
        for (int i = 0; i < pesoVagao.Length; i++)
        {
        pesoVagao[i] = Convert.ToInt32(Console.ReadLine());
        }

        ChecarPesoVagao(pesoVagao);

    }

        static void ChecarPesoVagao(int[] pesoVagao)
        {
            int pesoLimite = 50;
            for (int i = 0; i < pesoVagao.Length; i++)
            {
                if(pesoVagao[i] > pesoLimite)
                {
                    System.Console.WriteLine($"{i + 1}º vagão ultrapassou o limite de peso.");
                } 
            }

        }




}