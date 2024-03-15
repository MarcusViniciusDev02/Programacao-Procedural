using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um número:");
        int numero1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite outro número:");
        int numero2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("A soma dos números é " + (numero1 + numero2));
    }
}

//O debbuger para onde tiver um break point