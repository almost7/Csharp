using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //c. Altere o programa anterior para que a mensagem surja para todos os nomes terminados em "eu". Exemplo:> Olá Zebedeu!Dá cá o meu!
            /*string nome, parte;
            Console.WriteLine("insira o seu nome");
            nome = Console.ReadLine();
            parte = nome.Substring((nome.Length)-2, 2);
            if (parte == "eu")
                Console.WriteLine("Olá "+nome+" Dá cá o meu!");
            else
                Console.WriteLine("Olá "+nome+"!");
            System.Threading.Thread.Sleep(3000);*/

            //e. Crie uma função que indique qual de três strings introduzidas pelo utilizador tem um comprimento superior.
            /* string frase1 = "Atirei o pau ao gato", frase2 = "era uma vez há muito tempo", frase3 = "Atirei o pau ao gato";
             if (frase1.Length > frase2.Length && frase1.Length > frase3.Length)
                 Console.WriteLine("a primeira frase é a maior");
             else
                 if (frase2.Length > frase1.Length && frase2.Length > frase3.Length)
                 Console.WriteLine("a segunda frase é a maior");
             else
                     if (frase3.Length > frase2.Length && frase3.Length > frase1.Length)
                 Console.WriteLine("a terceira frase é a maior");
             System.Threading.Thread.Sleep(3000); */

            //d. Altere o programa de modo a pedir o nome completo e apresentar apenas o primeiro e o último nome.
            /*string nome;
            Console.WriteLine("insira o nome completo:");
            nome = Console.ReadLine();
            string[] partesNome = nome.Split(' ');
            Console.WriteLine(partesNome[0]+" "+partesNome[(partesNome.Length)-1]);
            System.Threading.Thread.Sleep(3000);*/

            //f. Crie uma função que receba um vector de strings como argumento e retorne um valor booleano indicando se todas as strings têm o mesmo comprimento.
            /*string nome;
            Console.WriteLine("insira uma frase:");
            nome = Console.ReadLine();
            string[] partesNome = nome.Split(' ');
            if (allEqual(partesNome))
                Console.WriteLine("todas as strings têm o mesmo tamanho.");
            else
                Console.WriteLine("as strings não têm todas o mesmo tamanho.");
            System.Threading.Thread.Sleep(3000);*/

            //g. Crie uma função que receba um vector de strings como argumento e retorne um valor inteiro correspondendo à soma de todos os comprimentos das strings.
            /*string nome= "Carlos Alberto Gomes Silva";
            string[] partesNome = nome.Split(' ');
            Console.WriteLine("a soma do tamanho das strings é: "+ somaTamStrings(partesNome));
            System.Threading.Thread.Sleep(3000);*/

            //h. Crie uma função que, numa string substitua todas as letras “v” por “b” e todas as ocorrências de “ão” por “om”.
            /*string nome = "vi um video de um avião com um fogetão em cima";
            Console.WriteLine(replaceLetter(nome));
            System.Threading.Thread.Sleep(7000);*/

            //i. Crie uma função para verificar se uma string é constituída apenas por algarismos. A função deverá retornar um valor booleano true neste caso.
            /*string texto = "1 2 3 4";
           if (confirmNumber(texto))
               Console.WriteLine("a string tem apenas números.");
           else
               Console.WriteLine("a string não tem apenas números.");
           System.Threading.Thread.Sleep(7000);*/

            // j. Crie uma função que receba uma string como argumento e retorne true se a string não contiver algarismos.
            /*string texto = "ljikdhf a";
            if (!notNumber(texto))
                Console.WriteLine("a string tem números.");
            else
                Console.WriteLine("a string não tem números.");
            System.Threading.Thread.Sleep(7000);*/

            //k. Crie uma função que leia 2 strings do utilizador e indique qual das strings está primeiro na ordem alfabética.
            /*string a = "atirei o pau ao gato", b = "mas o gato não morreu";
            Console.WriteLine("a frase que está primeiro na ordem alfabética é: " + firstPhrase(a,b));
            System.Threading.Thread.Sleep(7000);*/

            //l. Crie uma função que leia 10 nomes para um vector de strings e os ordene alfabeticamente na saída.
            /*Console.WriteLine(alphaOrder());
            System.Threading.Thread.Sleep(10000);*/

            // m. Crie um jogo com 10 advinhas do tipo "Qual a cor do cavalo branco do Napoleão?", cada uma com 3 alternativas, apresentando o resultado final.
            //guessNumber();
           string nome = "A dama admirou o rim da amada";
            if (palindromoV2(nome))
                Console.WriteLine("é palindromo");
            else
                Console.WriteLine("não é palindromo");
            System.Threading.Thread.Sleep(30000);
        }
        public static bool allEqual(string[] a)
        {
            for (int i = 1; i < a.Length; i++)
                if (a[i].Length != a[0].Length)
                    return false;
            return true;
        }
        public static int somaTamStrings(string[] a)
        {
            int tamanho = 0;
            for (int i = 0; i < a.Length; i++)
                tamanho += a[i].Length;
            return tamanho;
        }
        public static string replaceLetter(string a)
        {
            string inicio = a.Replace("v", "b");
            string fim = inicio.Replace("ão", "om");
            return fim;
        }
        public static bool confirmNumber(string frase)
        {
            string noSpace = frase.Replace(" ", "");
            foreach (char a in noSpace)
            {
                if (!char.IsNumber(a))
                    return false;
            }
            return true;
        }
        public static bool notNumber(string frase)
        {
            string noSpace = frase.Replace(" ", "");
            foreach (char a in noSpace)
            {
                if (char.IsNumber(a))
                    return false;
            }
            return true;
        }
        public static int firstPhrase(string a, string b)
        {
            return string.Compare(a, b);
        }
        public static string alphaOrder()
        {
            string[] nomes = {"Carlos", "João", "Vitor", "Rui", "António", "Lucio", "Voldemort", "Joaquina", "Miguel", "Fabio"};
            string aux;
            for (int i = 0; i < nomes.Length - 1; i++)
                for (int j = i + 1; j < nomes.Length; j++)
                    if (string.Compare(nomes[i], nomes[j]) == 1)
                    {
                        aux = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
            aux = "";
            foreach(string a in nomes)
            {
                aux += a + ", ";
            }
            return aux;
        }
        public static void guessGame()
        {
            Console.WriteLine("Qual a soma de 2+2?  [4]  [22]  [0]");
            int primeira = int.Parse(Console.ReadLine());
            Console.WriteLine("Que cor se obtém da soma de azul e amarelo?\n[laranja]  [castanho]  [verde]");
            string segunda = Console.ReadLine();
            Console.WriteLine("O que é que o nadador faz para bater o record?\n[nada]  [tudo]  [dorme]");
            string terceira = Console.ReadLine();
            Console.WriteLine("O que é que tem oito letras e tirando metade ainda fica oito?\n[16]  [dobro]  [biscoito]");
            string quarta = Console.ReadLine();
            Console.WriteLine("O que é que quanto mais se perde mais se tem?\n[dinheiro]  [tempo]  [sono]");
            string quinta = Console.ReadLine();
            Console.WriteLine("O que é que é surdo-mudo mas conta tudo?\n[cuscuvilheiro]  [livro]  [relogio]");
            string sexta = Console.ReadLine();
            Console.WriteLine("O que é que anda deitado e dorme em pé?\n[corredor]  [sonâmbulo]  [pé]");
            string setima = Console.ReadLine();
            Console.WriteLine("O que é que tem coroa mas não é rei?\n[pai natal]  [abacaxi]  [chocolate]");
            string oitava = Console.ReadLine();
            Console.WriteLine("que é que num instante se quebra quando se diz o nome dele?\n[vidro]  [silêncio]  [ar]");
            string nona = Console.ReadLine();
            Console.WriteLine("O que é que entra na água e não se molha?\n[agua]  [sombra]  [submarino]");
            string decima = Console.ReadLine();
            int pontos = 0;
            if (primeira == 4) {
                Console.WriteLine("primeira resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("primeira resposta: errada.\na resposta certa é: 4");
            if (segunda == "verde") {
                Console.WriteLine("segunda resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("segunda resposta: errada.\na resposta certa é: verde");
            if (terceira == "nada")
            {
                Console.WriteLine("terceira resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("terceira resposta: errada.\na resposta certa é: nada");
            if (quarta == "biscoito")
            {
                Console.WriteLine("quarta resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("quarta resposta: errada.\na resposta certa é: biscoito");
            if (quinta == "sono")
            {
                Console.WriteLine("quinta resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("quinta resposta: errada.\na resposta certa é: sono");
            if (sexta == "livro")
            {
                Console.WriteLine("sexta resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("sexta resposta: errada.\na resposta certa é: livro");
            if (setima == "pé")
            {
                Console.WriteLine("setima resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("setima resposta: errada.\na resposta certa é: pé");
            if (oitava == "abacaxi")
            {
                Console.WriteLine("oitava resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("oitava resposta: errada.\na resposta certa é: abacaxi");
            if (nona == "silêncio")
            {
                Console.WriteLine("nona resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("nona resposta: errada.\na resposta certa é: silêncio");
            if (decima == "sombra")
            {
                Console.WriteLine("decima resposta: certa.");
                pontos++;
            }
            else
                Console.WriteLine("decima resposta: errada.\na resposta certa é: sombra");
            Console.WriteLine("\n\nobteve uma pontuação de" + pontos + "/10");
        }
        public static void guessNumber()
        {
            int pontos = 0;
            for(int i = 0; i < 10; i++)
            {
                int a = new Random().Next(1,250);
                int b = new Random().Next(251, 500);
                Console.WriteLine("qual a soma de " + a + " + " + b + " ?");
                if (int.Parse(Console.ReadLine()) == a + b)
                {
                    Console.WriteLine("certo!!");
                    pontos++;
                }
                else
                    Console.WriteLine("errado!!  a resposta certa é: " + (a + b));
            }
            Console.WriteLine("acertaste em " + pontos + " perguntas em 10!");
        }
        public static bool palindromo(string nome)
        {
            string final = nome.Replace(" ","");
            final = final.ToLower();
            char[] letras = final.ToCharArray();
            char[] inverso = final.ToCharArray();
            int k = 0;
            for (int i = letras.Length - 1; i > -1; i--)
            {
                if (letras[i] != inverso[k])
                    return false;
                k++;
            }
            return true;
        }
        public static bool palindromoV2(string nome)
        {
            string final = nome.Replace(" ", "");
            string inverso = new string(final.Reverse().ToArray());
            if (final.Equals(inverso, StringComparison.InvariantCultureIgnoreCase))
                return true;
            else
                return false;
        }
    }
}
