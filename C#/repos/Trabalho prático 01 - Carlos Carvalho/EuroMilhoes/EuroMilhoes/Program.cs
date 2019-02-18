using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EuroMilhoes
{
    class Program
    {
        static List<Chave> listaChaves = new List<Chave>();
        static List<Chave> listaChavesSorteadas = new List<Chave>();
        static void Main(string[] args)
        {
            fromFichToList();
            apresentação();
            int opcao1, opcao2;
            do
            {
                opcao1 = menu1();
                switch (opcao1)
                {
                    case 1:
                        opcao2 = menu2();
                        switch (opcao2)
                        {
                            case 1:
                                inserirChaveManualmente();
                                break;
                            case 2:
                                sortearChaveEscolhida(apresentaChaves());
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        sair();
                        break;
                    case 3:
                        ultimosSorteios();
                        break;
                    default:
                        break;
                }
            } while (opcao1 != 2);
        }

        static void fromFichToList()
        {
            StreamReader listagemChaves = new StreamReader(@"C:\Trabalho prático 01 - Carlos Carvalho\chavesEuromilhoes.txt", Encoding.GetEncoding("iso-8859-1"));
            while (!listagemChaves.EndOfStream)
            {
                string linha = listagemChaves.ReadLine();
                string[] palavras = linha.Split(',');
                listaChaves.Add(new Chave(int.Parse(palavras[0]), int.Parse(palavras[1]), int.Parse(palavras[2]), int.Parse(palavras[3]), int.Parse(palavras[4]), int.Parse(palavras[5]), int.Parse(palavras[6]), int.Parse(palavras[7]), int.Parse(palavras[8]), int.Parse(palavras[9])));
            }
            listagemChaves.Close();
        }

        static int menu1()
        {
            Console.Clear();
            Console.WriteLine("[1]Jogar\n[2]Sair\n[3]Últimas chaves sorteadas");
            return lerValor();
        }

        static int menu2()
        {
            Console.Clear();
            Console.WriteLine("[1]Inserir uma chave manualmente\n[2]Escolher uma chave do ficheiro das chaves favoritas");
            return lerValor();
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

        static void sair()
        {
            fromListToFich();
            Console.Clear();
            Console.WriteLine("\naté breve");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void fromListToFich()
        {
            StreamWriter listagemChaves2 = new StreamWriter(@"C:\Trabalho prático 01 - Carlos Carvalho\chavesEuromilhoes.txt", false);
            foreach (Chave ch in listaChaves)
                listagemChaves2.WriteLine(ch.ToStringToFich());
            listagemChaves2.Close();
        }

        static void inserirChaveManualmente()
        {
            //leitura de numeros:
            int[] numeros = new int[7];
            numeros[5] = 99;
            numeros[6] = 99;
            int[] comparacao = { -1, -1, -1, -1, -1, -1, -1};
            bool flag = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("insira o  " + (i + 1) + " º número (entre 1 e 50):");
                int num = lerValorChave();
                do
                {
                    flag = true;
                    foreach (int n in comparacao)
                    {
                        if (num == n)
                            flag = false;
                    }
                    if (flag==false)
                    {
                        Console.WriteLine("não pode repetir números, insira um NOVO número (entre 1 e 50):");
                        num = lerValorChave();
                    }
                    else
                    {
                        numeros[i] = num;
                        comparacao[i] = num;
                        flag = true;
                    }
                } while (flag!=true);
            }
            Console.WriteLine("pode inserir até mais dois números. - [1-50] para inserir esse valor ou [0] para terminar:");
            for (int i = 5; i < 7; i++)
            {
                Console.WriteLine("insira o  " + (i + 1) + " º número (entre 1 e 50):");
                int num2 = lerValorChaveSup();
                if (num2 == 0 && i == 5)
                {
                    numeros[5] = 0;
                    numeros[6] = 0;
                    break;
                }
                else if (num2 == 0 && i == 6)
                {
                    numeros[6] = num2;
                    break;
                }
                else
                    if (numeros.Contains(num2))
                    do {
                        Console.WriteLine("não pode repetir números, insira um NOVO número (entre 1 e 50):");
                        num2 = lerValorChaveSup();
                    } while (numeros.Contains(num2));
                numeros[i] = num2;
            }
            //leitura de estrelas:
            int[] estrelas = new int[3];
            estrelas[2] = 99;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("insira a " + (i + 1) + " ª estrela (entre 1 e 12):");
                int est = lerValorEstrela();
                do
                {
                    if (estrelas.Contains(est))
                    {
                        Console.WriteLine("não pode repetir números, insira um NOVO número (entre 1 e 12):");
                        est = lerValorEstrela();
                    }
                }while(estrelas.Contains(est));
                estrelas[i] = est;
            }
            Console.WriteLine("pode inserir mais uma estrela.\n [1-12] para inserir esse valor ou [0] para terminar:");
            int est2 = lerValorEstrelaSup();
            do
            {
                if (estrelas.Contains(est2))
                {
                    Console.WriteLine("não pode repetir números, insira um NOVO número (entre 1 e 12):");
                    est2 = lerValorEstrelaSup();
                }
            } while (estrelas.Contains(est2));
            estrelas[2] = est2;
            Array.Sort(numeros);
            Array.Sort(estrelas);
            Console.WriteLine("pretende adicionar esta chave à lista de chaves favoritas antes do inicio do sorteio?\n[1] para SIM - [2] para NÃO:");
            int escolha = lerValor();
            if (escolha == 1)
            {
                listaChaves.Add(new Chave(numeros[0], numeros[1], numeros[2], numeros[3], numeros[4], numeros[5], numeros[6], estrelas[0], estrelas[1], estrelas[2]));
                fromListToFich();
            }
            Console.Clear();
            Console.Write("A chave inserida foi:\nnúmeros: ");
            foreach (int num in numeros)
            {
                if (num != 0)
                {
                    Console.Write(num + " ");
                    System.Threading.Thread.Sleep(300);
                }
            }
            Console.Write(" | estrelas: ");
            foreach (int est in estrelas)
            {
                if (est != 0)
                {
                    Console.Write(est + " ");
                    System.Threading.Thread.Sleep(300);
                }
            }
            sorteio(numeros, estrelas);
            }

        static int lerValorChave()
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
                if (a < 1 || a > 50)
                {
                    Console.WriteLine("o número inserido tem que ser entre 1 e 50, por favor insira novamente um número:");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static int lerValorChaveSup()
        {
            int a = -1;
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
                if (a < 0 || a > 50)
                {
                    Console.WriteLine("o número inserido tem que ser entre 1 e 50, por favor insira novamente um número ([0} para terminar:");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static int lerValorEstrela()
        {
            int a = -1;
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
                if (a < 1 || a > 12)
                {
                    Console.WriteLine("o número inserido tem que ser entre 1 e 12, por favor insira novamente um número:");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static int lerValorEstrelaSup()
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
                if (a < 0 || a > 12)
                {
                    Console.WriteLine("o número inserido tem que ser entre 1 e 12, por favor insira novamente um número ([0] para sair sem inserir número):");
                    flag = false;
                }
            } while (!flag);
            return a;
        }

        static int apresentaChaves()
        {
            Console.Clear();
            Console.WriteLine("Abaixo encontram-se as suas chaves favoritas:\n\n");
            Console.Write("Chaves: \n");
            int c = 1;
            foreach (Chave obj in listaChaves)
            {
                Console.Write("[" + c + "]  numeros: ");
                foreach (int num in obj.numeros)
                {
                    if (num != 0)
                        Console.Write(num + " ");
                }
                Console.Write(" | estrelas: ");
                foreach (int est in obj.estrelas)
                {
                    if (est != 0)
                        Console.Write(est + " ");
                }
                Console.Write("\n");
                c++;

            }
            Console.WriteLine("\nIndique a chave que pretende utilizar para o sorteio:");
            return lerValor();
        }

        static void sorteio(int[] numeros, int[] estrelas)
        {
            int contadorNumeros = 0, contadorEstrelas = 0;
            int[] randomNumeros = new int[5];
            int[] randomEstrelas = new int[2];
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 5; i++)
            {
                randomNumeros[i] = aleatorio.Next(1, 50);
            }
            for (int i = 0; i < 2; i++)
            {
                randomEstrelas[i] = aleatorio.Next(1, 12);
            }
            if(randomEstrelas[0]== randomEstrelas[1])
                randomEstrelas[1] = aleatorio.Next(1, 12);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (numeros[i] == randomNumeros[j])
                        contadorNumeros++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    if (estrelas[i] == randomEstrelas[j])
                        contadorEstrelas++;
            }
            Array.Sort(randomNumeros);
            Array.Sort(randomEstrelas);
            Console.WriteLine("\n\nchave sorteada de hoje é:");
            Console.Write("números: ");
            foreach (int num in randomNumeros)
            {
                if (num != 0)
                {
                    Console.Write(num + " ");
                    System.Threading.Thread.Sleep(300);
                }
            }
            Console.Write(" | estrelas: ");
            foreach (int est in randomEstrelas)
            {
                if (est != 0)
                {
                    Console.Write(est + " ");
                    System.Threading.Thread.Sleep(300);
                }
            }
            Console.Write("\n\nnumeros correspondentes: ");
            foreach(int numeric in randomNumeros)
                if(numeros.Contains(numeric))
                    Console.Write("["+numeric+"]"+" ");
            Console.Write("\nestrelas correspondentes: ");
            foreach (int star in randomEstrelas)
                if (estrelas.Contains(star))
                    Console.Write("[" + star + "]" + " ");
            StreamWriter listagemChavesSorteadas2 = new StreamWriter(@"C:\Trabalho prático 01 - Carlos Carvalho\chavesSorteadas.txt", false);
            foreach (Chave ch in listaChaves)
                listagemChavesSorteadas2.WriteLine(ch.ToStringToFich());
            listagemChavesSorteadas2.Close();

            if (contadorNumeros == 5 && contadorEstrelas == 2)
            {
                Console.Clear();
                Console.WriteLine("\nparabéns ganhou o 1º prémio - é um Euromilionário");
            }
            else if (contadorNumeros == 5 && contadorEstrelas ==1)
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nparabéns ganhou o 2º prémio!");
            else if (contadorNumeros == 4 && contadorEstrelas >=1)
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nparabéns ganhou o 3º prémio!");
            else if (contadorNumeros == 3 && contadorEstrelas >= 1)
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nparabéns ganhou o 4º prémio!");
            else if (contadorNumeros == 2 && contadorEstrelas >= 1)
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nparabéns ganhou o 5º prémio!");
            else if (contadorNumeros >= 1 && contadorEstrelas >= 1)
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nparabéns ganhou qualquer coisa!");
            else
                Console.WriteLine("\n\n\n\nprémo:\n\n\n\nainda não foi desta");
            Console.ReadKey();
        }

        static void sortearChaveEscolhida(int opcao)
        {
            Console.Clear();
            Console.WriteLine("A chave escolhida/inserida foi:");
            int c = 1;
            foreach (Chave obj in listaChaves)
            {
                if (c++ == opcao)
                {
                    foreach (int num in obj.numeros)
                    {
                        if (num != 0)
                        {
                            Console.Write(num + " ");
                            System.Threading.Thread.Sleep(300);
                        }
                    }
                    Console.Write(" | estrelas: ");
                    foreach (int est in obj.estrelas)
                    {
                        if (est != 0)
                        {
                            Console.Write(est + " ");
                            System.Threading.Thread.Sleep(300);
                        }
                    }
                    sorteio(obj.numeros, obj.estrelas);
                }
            }
        }

        static void apresentação()
        {
            string[] euromilhoes = { "E", "U", "R", "O", "M", "I", "L", "H", "Õ", "E", "S" };
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n                                  ");
            foreach (string c in euromilhoes)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

        }

        static void ultimosSorteios()
        {
            Console.WriteLine("as chaves sorteadas anteriores são: ");
            StreamReader listagemChavesSorteadas = new StreamReader(@"C:\Trabalho prático 01 - Carlos Carvalho\chavesSorteadas.txt", Encoding.GetEncoding("iso-8859-1"));
            while (!listagemChavesSorteadas.EndOfStream)
            {
                string linha = listagemChavesSorteadas.ReadLine();
                string[] palavras = linha.Split(',');
                listaChavesSorteadas.Add(new Chave(int.Parse(palavras[0]), int.Parse(palavras[1]), int.Parse(palavras[2]), int.Parse(palavras[3]), int.Parse(palavras[4]), int.Parse(palavras[5]), int.Parse(palavras[6]), int.Parse(palavras[7]), int.Parse(palavras[8]), int.Parse(palavras[9])));
            }
            listagemChavesSorteadas.Close();
            int c = 1;
            foreach (Chave obj in listaChavesSorteadas)
            {
                {
                    Console.Write("[" + c + "]  numeros: ");
                    foreach (int num in obj.numeros)
                    {
                        if (num != 0)
                            Console.Write(num + " ");
                    }
                    Console.Write(" | estrelas: ");
                    foreach (int est in obj.estrelas)
                    {
                        if (est != 0)
                            Console.Write(est + " ");
                    }
                    Console.Write("\n");
                    c++;

                }
            }
            Console.ReadKey();

        }
    }
}
