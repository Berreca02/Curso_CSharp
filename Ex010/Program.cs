namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.WriteLine("Qual o valor do seu salario?");
            salario = Convert.ToDouble(Console.ReadLine());
           

            if (salario > 2500)
            {
                aumento = salario * 0.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;
            }
            else
            {
                aumento = salario * 0.15;
            }

            Console.WriteLine("O aumento do seu salario é de: {0}", aumento + salario);







        }
    }
}
