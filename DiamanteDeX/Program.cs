namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirMenu();
                int numeroEntrada = ValidarEntrada();
                // lógica do jogo -> imprimir corretamente os X 
                // após imprimir o numero correto em ordem adicionar os espaços
                // imprimir o lado debaixo do diamante
                // ajustar a exibição do lado inferior do diamante
                SuperiorDiamante(numeroEntrada);
                InferiorDiamante(numeroEntrada);
                if (!DesejaContinuar()) break;

                static void ExibirMenu()
                {
                    Console.Clear();
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine("                DIAMANTE DE X");
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine("            Digite um número ímpar: ");
                    Console.WriteLine("_______________________________________________");
                }

                static int ValidarEntrada()
                {
                    int numeroEntrada;
                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out numeroEntrada) || numeroEntrada % 2 == 0)
                        {
                          MensagemErro();
                        }
                        else
                        {
                            break;
                        }
                    }
                    return numeroEntrada;
                }
                static void SuperiorDiamante(int numeroEntrada)
                {
                    for (int i = 1; i <= numeroEntrada; i += 2)
                    {
                        ExibirLinhaDiamante(i, numeroEntrada);
                    }
                }
                static void InferiorDiamante(int numeroEntrada)
                {
                    for (int i = numeroEntrada - 2; i >= 1; i -= 2)
                    {
                        ExibirLinhaDiamante(i, numeroEntrada);
                    }
                }
                static void ExibirLinhaDiamante(int i, int numeroEntrada)
                {
                    int espacosVazios = (numeroEntrada - i) / 2;
                    Console.WriteLine(new string(' ', espacosVazios) + new string('X', i));
                }
                static void MensagemErro()
                {
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine("<ERRO> Entrada inválida. Insira um número ímpar.");
                    Console.WriteLine("_______________________________________________");
                }

                static bool DesejaContinuar()
                {
                    Console.Write("\nDeseja continuar? (s/N): ");
                    string opcaoContinuar = Console.ReadLine()!.ToUpper();
                    return opcaoContinuar == "S";
                }
            }
        }
    }
}
