using System;

class Program
{
    static void Main(string[] args)
    {

        Tabuleiro.InicializaTabuleiro();
        for (int linha = 0; linha < 8; linha++)
        {
            Tabuleiro.Adicionar(linha, 0, "s");
            for (int linhaRegressiva = 7; linhaRegressiva >= 0; linhaRegressiva--)
            {
                Tabuleiro.Adicionar(linha, 7, "s");

                for (int coluna = 0; coluna < 8; coluna++)
                {
                    Tabuleiro.Adicionar(0, coluna, "s");

                    for (int colunaRegressiva = 7; colunaRegressiva >= 0; colunaRegressiva--)
                    {
                        Tabuleiro.Adicionar(7, colunaRegressiva, "s");

                    }
                }
            }


        }




        Tabuleiro.ImprimeTabuleiro();
    }
}