using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Operario_Gerente
{
    class Program
    {
        static List<Operario> listaOperario = new List<Operario>();
        static List<Gerente> listaGerente = new List<Gerente>();
        static void Main(string[] args)
        {
            fromFichToList();
            int opcao1;
            do
            {
                opcao1 = menuGeral();
                switch (opcao1)
                {
                    case 1:
                        listaGerente.Add(inserirGerente());
                        break;
                    case 2:
                        listaOperario.Add(inserirOperario());
                        break;
                    case 3:
                        int opcao2 = apresentaGerentes();
                        if (opcao2 == 0)
                            break;
                        else
                        {
                            int c = 1;
                            foreach (Gerente obj in listaGerente)
                            {
                                if (c++ == opcao2)
                                {
                                    gerenteSelecionado(obj);
                                    int opcao3 = menuAlterarGerente();
                                    switch (opcao3)
                                    {
                                        case 1:
                                            alteraValorHora(obj);
                                            break;
                                        case 2:
                                            mostraIdade(obj);
                                            break;
                                        case 3:
                                            mostraHorasTrabalhas(obj);
                                            break;
                                        default:
                                            break;
                                    }
                                }

                            }
                        }
                        break;
                    case 4:
                        int opcao4 = apresentaOperarios();
                        if (opcao4 == 0)
                            break;
                        else
                        {
                            int c = 1;
                            foreach (Operario obj in listaOperario)
                            {
                                if (c++ == opcao4)
                                {
                                    operarioSelecionado(obj);
                                    int opcao5 = menuAlterarOperario();
                                    switch (opcao5)
                                    {
                                        case 1:
                                            alteraValorHoraOperario(obj);
                                            break;
                                        case 2:
                                            mostraIdadeOperario(obj);
                                            break;
                                        case 3:
                                            mostraHorasTrabalhasOperario(obj);
                                            break;
                                        default:
                                            break;
                                    }
                                }

                            }
                        }
                        break;
                    case 5:
                        apresentaFuncionarios();
                        break;
                    case 6:
                        sair();
                        break;
                    default:

                        break;
                }
            } while (opcao1 != 6);
        }

        static void fromFichToList()
        {
            StreamReader listagemGerente = new StreamReader(@"D:\Carlos Carvalho - T0114404\C#\repos\Operario Gerente\Operario Gerente\listagemGerente.txt", Encoding.GetEncoding("iso-8859-1"));
            while (!listagemGerente.EndOfStream)
            {
                string linha = listagemGerente.ReadLine();
                string[] palavras = linha.Split(',');
                listaGerente.Add(new Gerente(palavras[0], int.Parse(palavras[1]), int.Parse(palavras[2]), palavras[3], int.Parse(palavras[4]), int.Parse(palavras[5]), int.Parse(palavras[6]), palavras[7], double.Parse(palavras[8])));
            }
            listagemGerente.Close();
            StreamReader listagemOperario = new StreamReader(@"D:\Carlos Carvalho - T0114404\C#\repos\Operario Gerente\Operario Gerente\listagemOperario.txt", Encoding.GetEncoding("iso-8859-1"));
            while (!listagemOperario.EndOfStream)
            {
                string linha = listagemOperario.ReadLine();
                string[] palavras = linha.Split(',');
                listaOperario.Add(new Operario(palavras[0], int.Parse(palavras[1]), palavras[2], int.Parse(palavras[3]), int.Parse(palavras[4]), int.Parse(palavras[5]), palavras[6], double.Parse(palavras[7])));
            }
            listagemOperario.Close();
        }

        static void fromListToFich()
        {
            StreamWriter listagemGerente2 = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\repos\Operario Gerente\Operario Gerente\listagemGerente.txt", false);
            foreach (Gerente ger in listaGerente)
                listagemGerente2.WriteLine(ger.ToStringToFich());
            listagemGerente2.Close();
            StreamWriter listagemOperario2 = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\repos\Operario Gerente\Operario Gerente\listagemOperario.txt", false);
            foreach (Operario ope in listaOperario)
                listagemOperario2.WriteLine(ope.ToStringToFich());
            listagemOperario2.Close();
        }

        static Gerente inserirGerente()
        {
            Console.WriteLine("Especialidade:");
            string especialidade = Console.ReadLine();
            Console.WriteLine("Extensão:");
            int extensao = lerValor();
            Console.WriteLine("ID:");
            int id = lerValor();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Ano Nascimento:");
            int ano = lerValor();
            Console.WriteLine("Mes Nascimento:");
            int mes = lerValor();
            Console.WriteLine("Dia Nascimento:");
            int dia = lerValor();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("valorHora:");
            double valorHora = lervalorDouble();
            return new Gerente(especialidade, extensao, id, nome, ano, mes, dia, email, valorHora);
        }

        static int menuGeral()
        {
            Console.Clear();
            Console.WriteLine("Indique a opção pretendida:\n[1]Inserir Gerente\n[2]Inserir Operário\n[3]Visualizar Gerentes\n[4]Visualizar Operários\n[5]Visualizar Funcionários\n[6]Sair");
            return lerValor();
        }

        static int menuAlterarGerente()
        {
            Console.WriteLine("Indique a opção pretendida:\n[1]Alterar Valor Hora\n[2]Calcular Idade\n[3]Calcular Salário");
            return lerValor();
        }

        static void mostraHorasTrabalhas(Gerente obj)
        {
            Console.WriteLine("Indique o numero de horas trabalhadas:");
            double horas = lervalorDouble();
            Console.WriteLine("o salário é: " + obj.calcSal(horas));
        }

        static void mostraIdade(Gerente obj)
        {
            Console.WriteLine("a idade do Gerente é: " + obj.calcIdade());
            System.Threading.Thread.Sleep(2000);
        }

        static void alteraValorHora(Gerente obj)
        {
            Console.WriteLine("Indique o novo valorHora");
            double valor = lervalorDouble();
            obj.setValorHora(valor);
            Console.WriteLine("valorHora alterado com sucesso");
            System.Threading.Thread.Sleep(1000);
        }

        static int apresentaGerentes()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("Lista de Gerentes:\n");
            foreach (Gerente obj in listaGerente)
            {
                Console.WriteLine("[" + ++num + "]" + " " + obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora() + " " + obj.Especialidade + " " + obj.Extensao);
            }
            Console.WriteLine("Indique o Gerente que pretende alterar ou [0] para voltar");
            return lerValor();
        }

        static Operario inserirOperario()
        {
            Console.WriteLine("Especialidade:");
            string departamento = Console.ReadLine();
            Console.WriteLine("ID:");
            int id = lerValor();
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Ano Nascimento:");
            int ano = lerValor();
            Console.WriteLine("Mes Nascimento:");
            int mes = lerValor();
            Console.WriteLine("Dia Nascimento:");
            int dia = lerValor();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("valorHora:");
            double valorHora = lervalorDouble();
            return new Operario(departamento, id, nome, ano, mes, dia, email, valorHora);
        }

        static double lervalorDouble()
        {
            double a = 0;
            bool flag = false;
            do
            {
                try
                {
                    a = double.Parse(Console.ReadLine());
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
                    Console.WriteLine("formato errado, insira um número inteiro:");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static void gerenteSelecionado(Gerente obj)
        {
            Console.Clear();
            Console.WriteLine(obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora() + " " + obj.Especialidade + " " + obj.Extensao + "\n");
        }

        static void sair()
        {
            fromListToFich();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      até breve");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void opcaoInvalida()
        {
            Console.WriteLine("opção inválida, insira um numero entre 1 e 6:");
        }

        static int apresentaOperarios()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("Lista de Operários:\n");
            foreach (Operario obj in listaOperario)
            {
                Console.WriteLine("[" + ++num + "]" + " " + obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora());
            }
            Console.WriteLine("Indique o Operário que pretende alterar ou [0] para voltar");
            return lerValor();
        }

        static void operarioSelecionado(Operario obj)
        {
            Console.Clear();
            Console.WriteLine(obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora() + "\n");
        }

        static int menuAlterarOperario()
        {
            Console.WriteLine("Indique a opção pretendida:\n[1]Alterar Valor Hora\n[2]Calcular Idade\n[3]Calcular Salário");
            return lerValor();
        }

        static void mostraHorasTrabalhasOperario(Operario obj)
        {
            Console.WriteLine("Indique o numero de horas trabalhadas:");
            double horas = lervalorDouble();
            Console.WriteLine("o salário é: " + obj.calcSal(horas));
        }

        static void mostraIdadeOperario(Operario obj)
        {
            Console.WriteLine("a idade do Gerente é: " + obj.calcIdade());
            System.Threading.Thread.Sleep(2000);
        }

        static void alteraValorHoraOperario(Operario obj)
        {
            Console.WriteLine("Indique o novo valorHora");
            double valor = lervalorDouble();
            obj.setValorHora(valor);
            Console.WriteLine("valorHora alterado com sucesso");
            System.Threading.Thread.Sleep(1000);
        }

        static void apresentaFuncionarios()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("Lista de Gerentes:\n");
            foreach (Gerente obj in listaGerente)
            {
                Console.WriteLine("[" + ++num + "]" + " " + obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora() + " " + obj.Especialidade + " " + obj.Extensao);
            }
            num = 0;
            Console.WriteLine("\nLista de Operários:\n");
            foreach (Operario obj in listaOperario)
            {
                Console.WriteLine("[" + ++num + "]" + " " + obj.getNome() + " " + obj.getDataNasc() + " " + obj.GetEMail() + " " + obj.getValorHora());
            }
        }
    }
}
