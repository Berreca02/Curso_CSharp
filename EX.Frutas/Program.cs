using System;

namespace EX.Frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Pêra", "Maçã", "Carambola", "Banana", "Goiaba", "Manga", "Morango", "Melância", "Uva", "Laranja" };

          int [] precos = { 5.00, 5.60, 10.50, 9.00, 8.30, 15.00, 12.00, 20.00, 15.50, 7.90};

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("O preço da: " + nomes[i]; + "é R$" + precos[i]);
            }
           

            

            




        }
    }
}
