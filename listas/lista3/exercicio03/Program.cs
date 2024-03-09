using System;

class Program
{
    static void Main(string[] args)
    {
        string usuarioCorreto = "admin", senhaCorreta = "123senha";
        int tentativas = 0, numeroTentativas = 1;

        System.Console.WriteLine("Seja bem vindo\nDigite seu login e senha");

        while (tentativas < 3)
        {

            System.Console.WriteLine("Usuário/Senha incorreto.\nTente novamente.\nMas tome cuidado! Após 3 tentativas sua conta será bloqueada.\nTentativa: " + numeroTentativas);


            System.Console.WriteLine("Usuário: ");
            string usuario = Console.ReadLine();
            System.Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                System.Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            else
            {
                System.Console.WriteLine("Conta bloqueada.");
            }
            tentativas++;
            numeroTentativas++;
        }

    }



}

