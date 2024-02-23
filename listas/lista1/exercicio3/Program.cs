using System;

class Program{
     public static void Main(String[] args)
    {

Console.WriteLine("Digite o valor para a conversão em reais e centavos: ");
int valor = int.Parse(Console.ReadLine());

double reais = valor / 100;
double centavos = valor % 100;


Console.WriteLine("O resultado é: " + reais + " reais e " + centavos + " centavos.");
}
}