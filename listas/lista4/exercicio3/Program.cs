using System;

class Program
{
    static void Main(string[] args)
    {

        Tabuleiro.InicializaTabuleiro();

        for (int linha0 = 0; linha0 < 8; linha0++)
        {
            Tabuleiro.Adicionar(linha0, 0, "S");

            for (int linha7 = 7; linha7 >= 0; linha7--)
            {
                Tabuleiro.Adicionar(linha7, 7, "S");
                
            }

            
        }
        for (int coluna1 = 0; coluna1 < 8; coluna1++)
        {
            Tabuleiro.Adicionar(0, coluna1, "S");

            for (int coluna7 = 7; coluna7 >= 0; coluna7--)
            {
                Tabuleiro.Adicionar( 7, coluna7, "S");
                
            }

            
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}