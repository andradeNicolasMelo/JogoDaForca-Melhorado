namespace jogoDaForca_Refotorado.ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Jogo da forca");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Frutas");
            Console.WriteLine("2 - Animais");
            Console.WriteLine("3 - Paises");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.Write("Escolha a categoria da palavra secreta: ");
            string opcaoEscolhida = Console.ReadLine()!;

            //---------------------------------------------
            PalavraSecreta palavra = new PalavraSecreta(opcaoEscolhida);
            palavra.DefinicaoPalavraSecreta();

            Console.WriteLine();
            Console.WriteLine($"Categoria: {palavra.categoria}");
            Console.WriteLine($"Palavra Secreta: {palavra.palavraSecreta}");
            Console.WriteLine();
            //---------------------------------------------
        }
    }
}
