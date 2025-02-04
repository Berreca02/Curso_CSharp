using System.Runtime.InteropServices;

namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contagem(1, 10, 1);
            contagem(10, 0, 2);

            Escrever("Agora é a sua vez de fazer a contagem");
            Console.Write("Digite o inicio da Contagem: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Escrever("Agora é a sua vez de fazer a contagem");
            Console.Write("Digite o inicio da Contagem: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Escrever("Agora é a sua vez de fazer a contagem");
            Console.Write("Digite o inicio da Contagem: ");
            int passo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            contagem(inicio, fim, passo);
        }

        static void contagem (int i, int f, int p)
        {
            Escrever($"Contagem de {i} {f} de {p} em {p}.");

            if (p < 0)
            {
                p *= -1;
            }

            if (i < f)
            {
                int cont = i;
                while(cont <= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont += p;
                }
                Console.WriteLine("Fim");
            }
            else
            {
                int cont = i;
                while (cont >= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont -= p;
                }
                Console.WriteLine("Fim");
            }
        }
        

        static void Escrever (string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadLeft(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine($"{textoCentralizado}");
            Console.WriteLine(linha);
        }
    }
}
