using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroEntrada;
            Console.WriteLine("Diamante de X");
            Console.WriteLine("Digite um número ímpar: ");
            if (!int.TryParse(Console.ReadLine(), out numeroEntrada) || numeroEntrada % 2 == 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número ímpar.");
            }

                Console.ReadLine();
        }
    }
}
