namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.WriteLine("Digite nota final do aluno:");
            nota_final = Convert.ToDouble(Console.ReadLine());

            if (nota_final >= 70)
            {
       
                if ( nota_final >= 95)
                {
                    resultado = "aprovado com louvor";
                }
                else
                {
                    resultado = "aprovado";
                }
                
            }
            else if (nota_final >=45)
            {
                resultado = "recuperação";
            }
            else
            {
                resultado = "reprovado";
            }
            Console.WriteLine("Nota do aluno: {0} - Resultado: {1}", nota_final, resultado);


                
        }
    }
}
