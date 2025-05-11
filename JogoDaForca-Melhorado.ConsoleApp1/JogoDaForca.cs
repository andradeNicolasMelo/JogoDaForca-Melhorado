using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaForca_Refotorado.ConsoleApp1
{
    public class JogoDaForca
    {

    }


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

}
