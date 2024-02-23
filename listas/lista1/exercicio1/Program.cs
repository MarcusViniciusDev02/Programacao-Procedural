using System;

class Program{
    public static void Main (String[] args){
       Console.WriteLine("Digite a primeira nota: ");
       double nota1 = double.Parse(Console.ReadLine());
       Console.WriteLine("Digite a segunda nota: ");
       double nota2 = double.Parse(Console.ReadLine());
       Console.WriteLine("Digite a terceira nota: ");
       double nota3 = double.Parse(Console.ReadLine());
       Console.WriteLine("Digite a quarta nota: ");
       double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("A média do aluno é " + media);       

    }
}
