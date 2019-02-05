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
            Carro c1 = new Carro();
            Console.WriteLine("insira nova matricula:");
            c1.Matricula = Console.ReadLine();
            Console.WriteLine(c1.Matricula);
        }
    }
}
