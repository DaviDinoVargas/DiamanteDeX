namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numeroEntrada;
                Console.WriteLine("Diamante de X");
                Console.WriteLine("Digite um número ímpar: ");
                if (!int.TryParse(Console.ReadLine(), out numeroEntrada) || numeroEntrada % 2 == 0)
                {
                    Console.WriteLine("Entrada inválida. insira um número ímpar.");
                }

                Console.Write("\nDeseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S") break;
            }
        }
    }
}
