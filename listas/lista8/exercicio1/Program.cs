using System;
struct Pizza
{
    //id, sabor e preço;
    public int id;
    public string sabor;
    public double preco;
}

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza;

        pizza.id = Convert.ToInt32(Console.ReadLine());
        pizza.sabor = Console.ReadLine();
        pizza.preco = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine($"{pizza.id}\n{pizza.sabor}\n{pizza.preco}");


    }
}