namespace AreaTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Cálcular a Área do Terreno");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Digite a largura do Terreno (m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do Terreno (m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);
        }

        static void area(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A área do terreno de {largura} x {comprimento} é de {a:F2}m²");
        }





    }

    
}
