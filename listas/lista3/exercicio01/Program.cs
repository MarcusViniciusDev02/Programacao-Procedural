using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = 0.0;
        double somaSalario = 0.0;
        int filhoPorHabitante = 0;
        int somaFilhoPorHabitante = 0;
        double maiorSalario = 0.0;
        int contador = 0;

        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Digite seu salário");
            salario = double.Parse(Console.ReadLine());
            somaSalario += salario;

            System.Console.WriteLine("Quantos filhos você tem?");
            filhoPorHabitante = int.Parse(Console.ReadLine());
            somaFilhoPorHabitante += filhoPorHabitante;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;

            }
            contador++;
        }


        double mediaSalario = somaSalario / 3;
        int mediaFilhosPorHabitante = somaFilhoPorHabitante / 3;
        System.Console.WriteLine(contador);
        System.Console.WriteLine("Média salarial por habitante: " + mediaSalario + "\n" + "Media de filhos por habitante: " + mediaFilhosPorHabitante + "\n" + "Maior salário: " + maiorSalario);

    }
}