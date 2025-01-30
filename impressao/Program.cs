namespace impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                escreva("Rebeca Rezende");
                Console.WriteLine();

            }

            static void escreva(string texto)
            {

                /* Escreva o texto centralizado em uma linha com o caracter informado*/

                char caracter = '*'; // caracter que será impresso
                int tamanho = texto.Length + 4; // Tamanho da linha
                string linha = new string(caracter, tamanho); // cria uma linha com o caracter informado
                string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // centraliza o texto
                Console.WriteLine(linha); 
                Console.WriteLine(textoCentralizado);
                Console.WriteLine(linha);
            }

        }
    }
}
