using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumismo
{
    class Carro
    {
        private string _matricula;
        private int _ano;
        private double _kmIniciais;
        private string _tipoCombustivel;
        private List<Abastecimento> listaAbast;

        public Carro()
        {
            _matricula = "";
            _ano = 1950;
            _kmIniciais = 0;
            _tipoCombustivel = "";
            List<Abastecimento> listaAbast = new List<Abastecimento>();
        }

        public Carro(string mat, int ano, double km, string tipC)
        {
            _matricula = mat;
            this._ano = ano;
            _kmIniciais = km;
            _tipoCombustivel = tipC;
            List<Abastecimento> listaAbast = new List<Abastecimento>();
        }

        public Carro(Carro c)
        {
            this._matricula = c._matricula;
            this._ano = c._ano;
            this._kmIniciais = c._kmIniciais;
            this._tipoCombustivel = c._tipoCombustivel;
            List<Abastecimento> listaAbast = c.listaAbast;
        }

        public string Matricula
        {
            get { return _matricula; }
            set
            {

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
