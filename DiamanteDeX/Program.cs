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
                DiamanteX.SuperiorDiamante();
                DiamanteX.InferiorDiamante();
                if (!DiamanteX.DesejaContinuar()) break;  
            }
        }
        static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("                     DIAMANTE DE X");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("                 Digite um número ímpar: ");
            Console.WriteLine("______________________________________________________");
        }
        public static void MensagemErro()
        {
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("<ERRO> Entrada inválida. Insira um número ímpar > 101.");
            Console.WriteLine("______________________________________________________");
        }
    }
}
