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


            //---- ESCOLHA DA PALAVRA SECRETA -------------
            PalavraSecreta palavra = new PalavraSecreta(opcaoEscolhida);
            palavra.DefinicaoPalavraSecreta();


            string palavraSecreta = palavra.palavraSecreta;
            Console.WriteLine();
            Console.WriteLine($"Categoria: {palavra.categoria}");
            Console.WriteLine($"Palavra Secreta: {palavraSecreta}");
            Console.WriteLine();
            //---------------------------------------------


            //------- OCULTAÇÃO DA PALAVRA SECRETA ---------
            OcultacaoPalavraSecreta ocultacaoDaPalavra = new OcultacaoPalavraSecreta(palavraSecreta);
            ocultacaoDaPalavra.RealizacaoDaOcultacao();
            ocultacaoDaPalavra.MostrarPalavraOcultada();

            Console.WriteLine();
            Console.WriteLine($"{ocultacaoDaPalavra.MostrarPalavraOcultada()}");
            Console.WriteLine();
            //---------------------------------------------


            //---------- Usuario chuta uma letra ----------
            //=============================================
            Console.WriteLine("Chute uma letra: ");
            char valorChutado = Convert.ToChar(Console.ReadLine()!.ToUpper()[0]);
            //=============================================


            //---------- Verifica se é uma letra ----------
            VerificadorDoValorChutado verificador = new VerificadorDoValorChutado(valorChutado);
            char letraChutada = verificador.VerificaLetra();
            //---------------------------------------------


            //----------- Revelador de letras -------------
            Console.WriteLine();
            RevaladorDeLetras revelador = new RevaladorDeLetras(letraChutada, ocultacaoDaPalavra.LetrasDaPalavraSecreta, ocultacaoDaPalavra.arrayLetrasOcultadas, palavraSecreta);
            revelador.ReveladorLetras();
            Console.WriteLine();
            //---------------------------------------------
        }
    }
}
