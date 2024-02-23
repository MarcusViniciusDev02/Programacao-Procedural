class Program
{
    public static void Main(String[] args)
    {

        Console.WriteLine("Escreva a base do triângulo: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva a altura do triângulo: ");
        double altura = double.Parse(Console.ReadLine());

        double areaTriangulo = (h * altura) / 2;
        bool areaCheck = areaTriangulo > 20;
        Console.WriteLine("A área do triângulo é maior que 20? " + areaCheck);

        

    }
}
