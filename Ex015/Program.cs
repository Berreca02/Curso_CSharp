namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

                Console.Write("Digite o seu gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o genêro: ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-Vindos e Bem-Vindas ao curso de C#!");
        }

    }
}
