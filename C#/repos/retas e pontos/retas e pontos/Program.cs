using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retas_e_pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto();
            int a = 1, b = 3;
            Ponto p2 = new Ponto(a, b);
            Reta r1 = new Reta();
            Reta r2 = new Reta(r1);
            Console.WriteLine(r1.ToString());
            Console.WriteLine(r2.ToString());
            System.Threading.Thread.Sleep(5000);
        }
    }
}
