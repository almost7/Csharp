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

        public Abastecimento(int a, int m, int d, double valor, double litros, double kms, Carro c1)
        {
            car = c1;
            dateTime = new Data(a, m, d);
            _valor = valor;
            _litros = litros;
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

        public double calcPrecoLitro()
        {

            return 0;
        }
    }
}
