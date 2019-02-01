using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CandyDate
{
    class Program
    {
        static List<Candidato> listaCandidatos = new List<Candidato>();
        static void Main(string[] args)
        {
            fromFichToList();
            int a = 0;
            int escolha;
            do
            {
                escolha = menuGeral();
                switch (escolha)
                {
                    case 1:
                        apresentaCandidatos();
                        break;
                    case 2:
                        criarCandidato();
                        break;
                    case 3:
                        sair();
                        break;
                    default:
                        opcaoInvalida();
                        break;
                }
            } while (escolha != 3);
        }

        static void criarCandidato()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n                                            qual é o seu ano de Nascimento");
            Console.SetCursorPosition(59, 4);
            int ano = int.Parse(Console.ReadLine());
            if (DateTime.Now.Year - ano < 18)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n                                     Lamentamos, não são possiveis candidaturas de menores");
                System.Threading.Thread.Sleep(2000);
                return;
            }
            else
            {
                Console.WriteLine("                                            qual é o seu mês de Nascimento");
                Console.SetCursorPosition(59, 6);
                int mes = lerValor();
                Console.WriteLine("                                            qual é o seu dia de Nascimento");
                Console.SetCursorPosition(59, 8);
                int dia = lerValor();
                Console.WriteLine("                                            Qual é o seu nome?");
                Console.SetCursorPosition(59, 10);
                string nome = Console.ReadLine();
                Console.WriteLine("                                            Qual é a sua localidade?");
                Console.SetCursorPosition(59, 12);
                string localidade = Console.ReadLine();
                Console.WriteLine("                                            qual é o seu sexo?");
                Console.SetCursorPosition(59, 14);
                string sexo = Console.ReadLine();
                Console.WriteLine("                                            qual é o seu email?");
                Console.SetCursorPosition(59, 16);
                string email = Console.ReadLine();
                Console.WriteLine("                                            qual o seu número de telefone:");
                Console.SetCursorPosition(59, 18);
                int telefone = lerValor();
                listaCandidatos.Add(new Candidato(nome, localidade, ano, mes, dia, sexo, email, telefone));
                fromListToFich(true);
            }
        }

        static int lerValor()
        {
            int a = 0;
            bool flag = false;
            do
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("formato errado, insira um número:");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static int menuGeral()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n                                                     CandyDate\n\n\n\n\n\n                                            Prima [1] para ver candidatos\n                                            prima [2] para inserir candidatura\n                                            Prima [3] para sair");
            Console.SetCursorPosition(57, 15);
            Console.CursorVisible = false;
            return lerValor();
        }

        static void apresentaCandidatos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Candidatos:\n");
            foreach (Candidato obj in listaCandidatos)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("prima qualquer tecla para continuar");
            Console.ReadKey(true);
        }

        static void sair()
        {
            fromListToFich(false);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      até breve");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void opcaoInvalida()
        {
            Console.WriteLine("opção inválida, insira um numero entre 1 e 3:");
        }

        static void fromFichToList()
        {
            StreamReader candidaturas = new StreamReader(@"D:\Carlos Carvalho - T0114404\C#\repos\CandyDate\CandyDate\candidatos.txt", Encoding.GetEncoding("iso-8859-1"));
            while (!candidaturas.EndOfStream)
            {
                string linha = candidaturas.ReadLine();
                string[] palavras = linha.Split(';');
                for (int i = 0; i < palavras.Length; i++) {
                    if (palavras[i] == "null")
                        palavras[i] = null;
                }
                listaCandidatos.Add(new Candidato(palavras[0], palavras[1], int.Parse(palavras[2]), int.Parse(palavras[3]), int.Parse(palavras[4]), palavras[5], palavras[6], int.Parse(palavras[7]), palavras[8], palavras[9], palavras[10], palavras[11], palavras[12], palavras[13], palavras[14], palavras[15], palavras[16], palavras[17], palavras[18], palavras[19], palavras[20]));
            }
            candidaturas.Close();
        }

        static void fromListToFich(bool opcao)
        {
            StreamWriter candidaturas = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\repos\CandyDate\CandyDate\candidatos.txt", opcao, Encoding.GetEncoding("iso-8859-1"));
            foreach (Candidato can in listaCandidatos)
                candidaturas.WriteLine(can.ToFich());
            candidaturas.Close();
        }
    }
}
