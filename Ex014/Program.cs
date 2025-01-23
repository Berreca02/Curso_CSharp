namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0} * {1} = {2}", numero, i, numero*i);
            }
        }
    }
}
