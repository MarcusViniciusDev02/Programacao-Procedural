using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        string[] nome = new string[TAMANHO_VETOR];

        for (int i = 0; i < TAMANHO_VETOR; i++)
        {
            nome[i] = Console.ReadLine();
        }

        //Pesquisa de nome
        string nomePesquisa = Console.ReadLine();
        
        bool encontrado = false;
        for(int i = 0; i < nome.Length; i++)
        {
            if(nomePesquisa == nome[i])
            {
                encontrado = true; // Alterna para true caso o nome pesquisado seja encontrado. 
                break;
            }

            if(encontrado)
            {
                System.Console.WriteLine("ACHEI");
            }
            else
            {
                System.Console.WriteLine("NAO ACHEI");
            }
        }
    }
}