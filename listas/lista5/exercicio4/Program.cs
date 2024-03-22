using System;
/*
       Crie um programa que receba números inteiros através do teclado e acumule todos os números ímpares digitados em um somatório. Quando um número negativo for digitado, seu programa deve parar de acumular os números e exibir o resultado do somatório de ímpares.

OBS: O número negativo não deve ser adicionado ao somatório.

Exemplo de entrada:
7
0
2
3
-5

Saída esperada:
O somatorio de impares eh: 10*/

class Program
{
    static void Main(string[] args)
    {
        int numeroEntrada = 0;
        int acumuladorDeImpares = 0;

        while (numeroEntrada >= 0)
        {
            numeroEntrada = int.Parse(Console.ReadLine());

            if (numeroEntrada % 2 >= 1)
            {
                acumuladorDeImpares += numeroEntrada;
            }
        }
        System.Console.WriteLine("O somatorio de impares eh: " + acumuladorDeImpares);
    }
}