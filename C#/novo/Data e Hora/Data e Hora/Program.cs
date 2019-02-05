using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data(2010, 03, 25, 01, 00, 00, "Sábado");
            Data d2 = new Data(2017, 03, 25, 01, 00, 00, "Sábado");
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            Hora h1 = new Hora(23, 25, 25);
            Hora h2 = new Hora(10, 15, 24);
            Console.WriteLine(d1.difEntreAnos(d2)+" anos");
            string diaSemana = (Console.ReadLine());
            System.Threading.Thread.Sleep(5000);
        }
    }
}
