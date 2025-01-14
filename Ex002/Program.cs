namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = -45;
            float num = 12.5f;
            char letra = 'c';
            string nome = "Rebeca";
            Console.WriteLine("O número é {0} .",numero);
            Console.WriteLine("O valor é R${0}.",num);
            Console.WriteLine("A letra é {0}.", letra);
            Console.WriteLine("Seu nome é {0}.", nome);

            Console.WriteLine("O número é {0}, O Valor é R${1}, a letra é {2} e seu nome é {3}.", numero, num, letra, nome);
        }
    }
}
