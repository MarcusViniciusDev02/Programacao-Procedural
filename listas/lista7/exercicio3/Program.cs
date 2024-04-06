using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        ClassificaNadador(idade);
    }

    static int ClassificaNadador(int idade)
    {
        
        if(idade < 12)
        {
            System.Console.WriteLine("Infantil");
        }
        else if (idade >= 12 && idade <= 14)
        {
            System.Console.WriteLine("Juvenil A");
        }
        else if (idade >= 15 && idade <= 17)
        {
            System.Console.WriteLine("Juvenil B");
        }
        else if (idade >= 18)
        {
            System.Console.WriteLine("Adulto");
        }
        else
        {
            System.Console.WriteLine("Entrada Inválida");
        }
        return idade;
    }
}