namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirMenu();
                DiamanteX.ValidarEntrada();
                // lógica do jogo -> imprimir corretamente os X 
                // após imprimir o numero correto em ordem adicionar os espaços
                // imprimir o lado debaixo do diamante
                // ajustar a exibição do lado inferior do diamante
                DiamanteX.SuperiorDiamante();
                DiamanteX.InferiorDiamante();
                if (!DiamanteX.DesejaContinuar()) break;  
            }
        }
        static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("                DIAMANTE DE X");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("            Digite um número ímpar: ");
            Console.WriteLine("_______________________________________________");
        }
        public static void MensagemErro()
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("<ERRO> Entrada inválida. Insira um número ímpar.");
            Console.WriteLine("_______________________________________________");
        }
    }
}
