using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite o número para verificação");
        int numeroVerificacao = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(VerificaParImpar(numeroVerificacao));

    }

    static bool VerificaParImpar(int numero)
    {
        if(numero % 2 == 0)
        {
            return true;
        }
        return false; 
    }
}