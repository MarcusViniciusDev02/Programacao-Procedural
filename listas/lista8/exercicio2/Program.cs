using System;
using System.Data.Common;

/*
Sua tarefa é construir uma vitrine de produtos. Para isso, seu coordenador pediu para que você criasse um programa que contenha uma struct Produto, com os campos id (inteiro), nome (string), preco (double) e disponivelEmEstoque (bool).
Após criada a struct, você deve criar um vetor de produtos, de tamanho 4 e preenchê-lo com dados recebidos via teclado.
Ao final, seu programa deve exibir na vitrine o nome e o preço dos produtos que estão disponíveis em estoque.
*/

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;


}

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Produto[] produto = new Produto[TAMANHO_VETOR];

        for (int i = 0; i < produto.Length; i++)
        {
            produto[i].id = Convert.ToInt32(Console.ReadLine());
            produto[i].nome = Console.ReadLine();
            produto[i].preco = Convert.ToDouble(Console.ReadLine());
            produto[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

        for (int i = 0; i < produto.Length; i++)
        {
            if (produto[i].disponivelEmEstoque == true)
            {
                string precoComDuasCasas = produto[i].preco.ToString("F2");
                System.Console.WriteLine(produto[i].nome);
                System.Console.WriteLine(precoComDuasCasas);
            }
        }

    }
}