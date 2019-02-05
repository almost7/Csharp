using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumismo
{
    class Abastecimento
    {
        public Carro car;
        public Data dateTime;
        public double _valor;
        public double _litros;
        public double _km;

        /* não podemos usar o construtor vazio para criar um carro!!
         public Abastecimento()
        {
            car = c1;
            dateTime = new Data();
            _valor = 0;
            _litros = 0;
            _km = 0;
        }*/

        public Abastecimento(int a, int m, int d, double valor, double litros, double kms, Carro c)//aqui só é usada a referência da posição do objeto carro e não criado um novo objeto
        {
            car = c; 
            dateTime = new Data(a, m, d);
            Valor = valor;
            _litros = litros;
            if(c.listaAbast.Count==0)
                _km = kms;
            else
                if (kms < c.listaAbast.Last()._km)
                    _km = c.listaAbast.Last()._km;
                else
                    _km = kms;
        }

        public Abastecimento(Abastecimento a)
        {
            this.car = a.car;
            this.dateTime = a.dateTime;
            this._valor = a._valor;
            this._litros = a._litros;
            this._km = a._km;
        }

        public double Valor
        {
            get { return _valor; }
            set
            {
                bool flag = false;
                do
                {
                    if (value > 0)
                    {
                        _valor = value;
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("o custo do abastecimento \"{0}€\" foi adicionado com sucesso", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("o custo do abastecimento necessita ter um valor correto, insira valor");
                        value = double.Parse(Console.ReadLine());
                        flag = false;
                    }
                } while (flag != true);
            }
        }

        public double calcPrecoLitro()
        {

            return 0;
        }

    }
}
