using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroItensCompados = 0;
        int escolhaItens = 0;
        double somaValorItens = 0.0;
        char resposta = 's';
        double camisa = 70.00, calca = 65.00, meia = 22.00, tenis = 90.00;



        System.Console.WriteLine("Seja bem vindo.\nHoje temos uma promoção de frete grátis.\nComprando acima de R$150,00 seu frete é gratuito, aproveite.");
        while (resposta == 's')
        {
            System.Console.WriteLine("Temos esses itens disponíveis em nossas lojas: \n\n1 - Camisa: R$70,00\n2 - Calça: R$65,00\n3 - Meias: R$22,00\n4 - Tênis: R$90.00\n\nEscolha através da numeração exibida");
            escolhaItens = int.Parse(Console.ReadLine());

            switch (escolhaItens)
            {
                case 1:
                    somaValorItens += camisa;
                    break;

                case 2:
                    somaValorItens += calca;
                    break;

                case 3:
                    somaValorItens += meia;
                    break;

                case 4:
                    somaValorItens += tenis;
                    break;

                default:
                    System.Console.WriteLine("Pedido não reconhecido.");
                    break;
            }
            System.Console.WriteLine("Você selecionou: " + escolhaItens);
            System.Console.WriteLine("Pedido realizado, deseja cotinuar?\n[s] - Sim\n[n] - Não");
            resposta = char.Parse(Console.ReadLine());

        
        }

        if(somaValorItens >= 150.00){
            System.Console.WriteLine("Valor da compra: " + somaValorItens);
            System.Console.WriteLine("Parabéns, você ganhou frete grátis!");
        }
    }

}

