using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("00-OO-00", 1910, 85, "gasoleo");
            abastecer(2019, 02, 05, 12.75, 100, 1000, c1);
            abastecer(2019, 02, 06, 100, 75, 1250, c1);
            abastecer(2019, 02, 07, 15, 25, 1800, c1);
            Console.WriteLine("o carro consome, neste momento, uma média de " +c1.consumoMedio().ToString("n2")+" litros aos 100");
        }

        static void abastecer(int a, int m, int d, double valor, double litros, double kms, Carro c)
        {
            Console.WriteLine("insira data de abastecimento:\nano:");
            int ano = int.Parse(Console.ReadLine());
            c.listaAbast.Add(new Abastecimento(a,m,d,valor,litros,kms, c));
        }

        static void 
    }
}
