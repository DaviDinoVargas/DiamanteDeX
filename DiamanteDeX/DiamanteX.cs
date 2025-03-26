namespace DiamanteDeX
{
    class DiamanteX
    {
        public static int numeroEntrada;
        public static char charExibido = 'X';

        // lógica do jogo -> imprimir corretamente os X 
        // após imprimir o numero correto em ordem adicionar os espaços
        // imprimir o lado debaixo do diamante
        // ajustar a exibição do lado inferior do diamante

        public static int ValidarEntrada()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numeroEntrada) || numeroEntrada % 2 == 0 || numeroEntrada > 101)
                {
                    Program.MensagemErro();
                }
                else
                {
                    break;
                }
            }
            return numeroEntrada;
        }
        public static void SuperiorDiamante()
        {
            for (int i = 1; i <= numeroEntrada; i += 2)
            {
                ExibirLinhaDiamante(i);
            }
        }
        public static void InferiorDiamante()
        {
            for (int i = numeroEntrada - 2; i >= 1; i -= 2)
            {
                ExibirLinhaDiamante(i);
            }
        }
        public static void ExibirLinhaDiamante(int i)
        {
            int espacosVazios = (numeroEntrada - i) / 2;
            Console.WriteLine(new string(' ', espacosVazios) + new string(charExibido, i));
        }
        public static bool DesejaContinuar()
        {
            Console.Write("\nDeseja continuar? (s/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            return opcaoContinuar == "S";
        }
    }
}
