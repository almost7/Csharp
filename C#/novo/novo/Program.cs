using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace novo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader vencimento = new StreamReader(@"D:\Carlos Carvalho - T0114404\C#\novo\VENCIMENTOS.txt", Encoding.GetEncoding("iso-8859-1"));
            StreamWriter supmil = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\novo\SUPMIL.TXT");
            while (!vencimento.EndOfStream)
            {
                string linha = vencimento.ReadLine();
                string[] palavras = linha.Split(' ');
                if (int.Parse(palavras[1]) >= 1000)
                    supmil.WriteLine(palavras[0] + " " + palavras[1]);
            }
            vencimento.Close();
            supmil.Close();

            StreamReader notas = new StreamReader(@"D:\Carlos Carvalho - T0114404\C#\novo\NOTAS.txt", Encoding.GetEncoding("iso-8859-1"));
            StreamWriter aprovados = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\novo\APROVADOS.TXT");
            StreamWriter reprovados = new StreamWriter(@"D:\Carlos Carvalho - T0114404\C#\novo\REPROVADOS.TXT");
            int flagA = 0, flagR = 0;
            while (!notas.EndOfStream)
            {
                string linha = notas.ReadLine();
                string[] palavras = linha.Split(' ');
                if (double.Parse(palavras[3]) >= 9.5)
                {
                    aprovados.WriteLine(palavras[0] + " " + palavras[1] + " " + palavras[2] + " " + palavras[3]);
                    flagA = 1;
                }
                else
                {
                    reprovados.WriteLine(palavras[0] + " " + palavras[1] + " " + palavras[2] + " " + palavras[3]);
                    flagR = 1;
                }
            }           
            if (flagA==0)
                aprovados.WriteLine("não tem registos");
            if(flagR==0)
                reprovados.WriteLine("não tem registos");
            notas.Close();
            aprovados.Close();
            reprovados.Close();
        }
    }
}
