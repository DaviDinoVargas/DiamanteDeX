namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numeroEntrada;
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("                DIAMANTE DE X");
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("            Digite um número ímpar: ");
                Console.WriteLine("_______________________________________________");
                if (!int.TryParse(Console.ReadLine(), out numeroEntrada) || numeroEntrada % 2 == 0)
                {
                    Console.WriteLine("Entrada inválida. insira um número ímpar.");
                }
                // lógica do jogo -> imprimir corretamente os X 
                // após imprimir o numero correto em ordem adicionar os espaços
                // imprimir o lado debaixo do diamante
                // ajustar a exibição do lado inferior do diamante
                for (int i = 1; i <= numeroEntrada; i += 2)
                {
                    int espacosVazios = (numeroEntrada - i) / 2;
                    Console.WriteLine(new string(' ', espacosVazios) + new string('X', i));
                }
                for (int i = numeroEntrada - 2; i >= 1; i -= 2)
                {
                    int espacosVazios = (numeroEntrada - i) / 2;
                    Console.WriteLine(new string(' ', espacosVazios) + new string('X', i));
                }
                Console.WriteLine("_______________________________________________");
                Console.Write("\nDeseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S") break;
            }
        }
    }
}
