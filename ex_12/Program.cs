using System.Runtime.ConstrainedExecution;

namespace ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.WriteLine("Digite o final do intervalo: ");
            final = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0},", i);
                }
            }
        }
    }
}
