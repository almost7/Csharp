using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Consumismo
{
    class Carro
    {
        private string _matricula;
        private int _ano;
        private double _kmIniciais;
        private string _tipoCombustivel;
        private List<Abastecimento> listaAbast = new List<Abastecimento>();

        public Carro()
        {
            _matricula = "";
            _ano = 1950;
            _kmIniciais = 0;
            _tipoCombustivel = "";
        }

        public Carro(string mat, int ano, double km, string tipC)
        {
           Matricula = mat;
           this._ano = ano;
           _kmIniciais = km;
           _tipoCombustivel = tipC;
        }

        public Carro(Carro c)
        {
            this._matricula = c._matricula;
            this._ano = c._ano;
            this._kmIniciais = c._kmIniciais;
            this._tipoCombustivel = c._tipoCombustivel;
            this.listaAbast = c.listaAbast;
        }

        public string Matricula
        {
            get { return _matricula; }
            set
            {
                bool flag = false;
                do
                {
                    Regex matriculaCarro = new Regex(@"^[0-9a-zA-Z]{2}-[0-9a-zA-Z]{2}-[0-9a-zA-Z]{2}$");
                    if (matriculaCarro.IsMatch(value))
                    {
                        _matricula = value;
                        Console.WriteLine("A matrícula: {0} foi adicionada.", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("A matrícula tem que estar no formato xx-xx-xx");
                        flag = false;
                    }
                } while (flag != true);
            }
        }

        public int Ano
        {
            get { return _ano; }
            set
            {
                bool flag = false;
                do
                {
                    Regex anoCarro = new Regex(@"^[0-9]{4}$");
                    if (anoCarro.IsMatch(value))
                    {
                        _ano = value;
                        Console.WriteLine("Ano do carro \"{0}\" foi adicionado.", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("A matrícula tem que estar no formato xx-xx-xx");
                        flag = false;
                    }
                } while (flag != true);
            }
        }



                public double totalGastoEmCombustivel()
        {

            return 0;
        }

        public double consumoMedio()
        {

            return 0;
        }
    }
}
