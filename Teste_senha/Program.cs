namespace Teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3) { break; }
            } while (senha != senhaDigitada);

            if (senha != senhaDigitada)
            {
                Console.Clear();
                Console.WriteLine("Senha Incorreta! Tentativas: " + tentativas);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha Correta! Tentativas: " + tentativas);
            }

        }   
    }
}
