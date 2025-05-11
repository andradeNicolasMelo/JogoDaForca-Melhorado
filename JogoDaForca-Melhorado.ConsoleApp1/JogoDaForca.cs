using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaForca_Refotorado.ConsoleApp1
{
    public class PalavraSecreta
    {
        //------------ Entrada de dados ----------------

        public string opcaoEscolhida;

        public PalavraSecreta(string temp)
        {
            opcaoEscolhida = temp;
        }
        //--------------------------------------------

        public string palavraSecreta = "";
        public string categoria = ""; //categoria escolhida. Apenas tem a função de informar a categoria para o usuario
        public void DefinicaoPalavraSecreta()
        {

            do
            {
                if (opcaoEscolhida == "1")
                {
                    string[] frutas = { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

                    Random random = new Random();
                    int indice = random.Next(frutas.Length);

                    palavraSecreta = frutas[indice];
                    categoria = "Frutas";

                    break;
                }

                else if (opcaoEscolhida == "2")
                {
                    string[] animais = { "CACHORRO", "GATO", "ELEFANTE", "LEAO", "TIGRE", "ZEBRA", "GIRAFA", "MACACO", "RINOCERONTE", "HIPOPOTAMO", "COBRA", "JACARE", "ARARA", "TUCANO", "PANTERA", "LOBO", "URSO", "CAMELO", "GOLFINHO", "BALEIA", "TARTARUGA", "PINGUIM", "CORUJA", "FOCA", "LEOPARDO", "AVESTRUZ", "GALO", "SAPO", "CARANGUEIJO", "BORBOLETA" };

                    Random random = new Random();
                    int indice = random.Next(animais.Length);

                    palavraSecreta = animais[indice];
                    categoria = "Animais";

                    break;
                }

                else if (opcaoEscolhida == "3")
                {
                    string[] paises = { "BRASIL", "ARGENTINA", "CANADA", "CHILE", "COLOMBIA", "CUBA", "EQUADOR", "ESTADOS_UNIDOS", "FRANÇA", "ALEMANHA", "INDIA", "ITALIA", "JAPAO", "MÉXICO", "PORTUGAL", "RUSSIA", "ESPANHA", "SUECIA", "SUICA", "CHINA", "AFRICA_DO_SUL", "AUSTRÁLIA", "BELGICA", "DINAMARCA", "EGITO", "FILIPINAS", "GRECIA", "HOLANDA", "IRLANDA", "NORUEGA" };

                    Random random = new Random();
                    int indice = random.Next(paises.Length);

                    palavraSecreta = paises[indice];
                    categoria = "Países";

                    break;
                }

                else
                {
                    Console.Write("Escolha 1, 2 ou 3: ");
                    opcaoEscolhida = Console.ReadLine()!;
                }
            } while (true);
        }
    }

    public class OcultacaoPalavraSecreta
    {
        public string palavraSecreta;
        public char[] LetrasDaPalavraSecreta;
        public char[] arrayLetrasOcultadas;

        public OcultacaoPalavraSecreta(string temp)
        {
            palavraSecreta = temp;
            LetrasDaPalavraSecreta = palavraSecreta.ToCharArray();
            arrayLetrasOcultadas = new char[LetrasDaPalavraSecreta.Length];
        }

        public void RealizacaoDaOcultacao()
        {
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                arrayLetrasOcultadas[i] = '-';
            }
        }
        public string MostrarPalavraOcultada()
        {
            string palavraSecretaOcultada = string.Join("", arrayLetrasOcultadas);

            return palavraSecretaOcultada;
        }
    }

    public class VerificadorDoValorChutado
    {
        public char valorChutado = ' ';
        
        public VerificadorDoValorChutado(char temp)
        {
            valorChutado = temp;
        }

        // vai verificar SE é letra
        public char VerificaLetra()
        {
            do
            {
                if (!char.IsLetter(valorChutado))
                {
                    Console.Write("Não é uma letra. Digite uma letra: ");
                    valorChutado = Convert.ToChar(Console.ReadLine()!.ToUpper()[0]);
                }
                else
                {
                    return valorChutado;
                }
            } while (true);
        }
    }

    public class RevaladorDeLetras
    {
        public char letraChutada;
        public char[] LetrasDaPalavraSecreta;
        public char[] arrayLetrasOcultadas;
        public string palavraSecreta;

        public RevaladorDeLetras(char temp, char[] temp2, char[] temp3, string temp4)
        {
            letraChutada = temp;
            LetrasDaPalavraSecreta = temp2;
            arrayLetrasOcultadas = temp3;
            palavraSecreta = temp4;
        }

        public int contadorDeErros = 0;
        int tentativas = 5;

        public void ReveladorLetras()
        {
            char[] letrasChutadas = new char[26];
            int indice = 0;

            while (true)
            {
                for(int i = 0; i < letrasChutadas.Length; i++)
                {
                    while(letraChutada == letrasChutadas[i])
                    {
                        Console.WriteLine("Letra já chutada. Chute outra letra: ");
                        letraChutada = Convert.ToChar(Console.ReadLine()!.ToUpper()[0]);
                    }
                }

                letrasChutadas[indice] = letraChutada;
                indice++;

                string visualizacaoDeLetrasChutadas = string.Join(" ", letrasChutadas);

                string palavraSecretaRevelada = string.Join("", arrayLetrasOcultadas);
                bool letraChutadaIgualApalavraSecreta = false;

                for (int i = 0; i < LetrasDaPalavraSecreta.Length; i++)
                {
                    if (letraChutada == LetrasDaPalavraSecreta[i])
                    {
                        arrayLetrasOcultadas[i] = letraChutada;
                        palavraSecretaRevelada = string.Join("", arrayLetrasOcultadas);
                        letraChutadaIgualApalavraSecreta = true;
                    }
                }

                if (!letraChutadaIgualApalavraSecreta)
                {
                    Console.Clear();

                    contadorDeErros++;
                    tentativas--;

                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine($"errou {contadorDeErros} vezes. restam {tentativas} tentativas");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine();

                    string cabecaDoBoneco = contadorDeErros >= 1 ? " o " : " ";
                    string tronco = contadorDeErros >= 2 ? "x" : " ";
                    string troncoBaixo = contadorDeErros >= 2 ? " x " : " ";
                    string bracoEsquerdo = contadorDeErros >= 3 ? "/" : " ";
                    string bracoDireito = contadorDeErros >= 4 ? @"\" : " ";
                    string pernas = contadorDeErros >= 5 ? "/ \\" : " ";


                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
                    Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
                    Console.WriteLine(" |        {0}       ", troncoBaixo);
                    Console.WriteLine(" |        {0}       ", pernas);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                }

                if (palavraSecretaRevelada == palavraSecreta)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine($"Parabens! Você acertou a palavra {palavraSecretaRevelada}");
                    Console.WriteLine("Jogo acabou");
                    Console.WriteLine();

                    break;
                }

                if (contadorDeErros == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Infelizmente voce perdeu");
                    Console.WriteLine($"A palavra era {palavraSecreta}");
                    Console.WriteLine("Jogo acabou");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine();

                    break;
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"Dica da palavra: {palavraSecretaRevelada}");
                Console.WriteLine($"Letras chutadas: {visualizacaoDeLetrasChutadas}");
                Console.WriteLine();
                Console.Write($"Chute uma palavra: ");
                letraChutada = Convert.ToChar(Console.ReadLine()!.ToUpper()[0]);
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }

    public class JogoDaForca
    {
    }
}
