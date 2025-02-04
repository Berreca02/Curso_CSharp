namespace Exercicio_Area_do_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Calcular a Área do Triângulo");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Digite o valor da Base (m): ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o valor da Altura (m): ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(B, A);

        }

        static void area(double Base, double Altura)
        {
            double a = (Base * Altura) / 2;
            Console.WriteLine($"A área do triângulo é: {a} m²");


        }

    }
}
