using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Consumismo
{
    class Carro
    {
        private string _matricula;
        private int _ano;
        private double _kmIniciais;
        private string _tipoCombustivel;
        public List<Abastecimento> listaAbast;

        public Carro()
        {
            _matricula = "";
            _ano = 1950;
            _kmIniciais = 0;
            _tipoCombustivel = "";
            listaAbast = new List<Abastecimento>();
        }

        public Carro(string mat, int ano, double km, string tipC)
        {
           Matricula = mat;
           Ano = ano;
           KmIniciais = km;
           TipoCombustivel = tipC;
           listaAbast = new List<Abastecimento>();
        }

        public Carro(Carro c)
        {
            this._matricula = c._matricula;
            this._ano = c._ano;
            this._kmIniciais = c._kmIniciais;
            this._tipoCombustivel = c._tipoCombustivel;
            listaAbast=new List<Abastecimento>(c.listaAbast);
        }

        public string Matricula
        {
            get { return _matricula; }
            set
            {
                bool flag = false;
                do
                {
                    Regex matriculaCarro = new Regex(@"^[a-zA-Z]{2}-[0-9]{2}-[0-9]{2}$");//|[0-9]{2}-[a-zA-Z]{2}-[0-9]{2}|[0-9]{2}-[0-9]{2}-[a-zA-Z]{2}
                    if (matriculaCarro.IsMatch(value))
                    {
                        _matricula = value;
                        Console.WriteLine("A matrícula \"{0}\" foi adicionada com sucesso.", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("A matrícula tem que estar no formato xx-xx-xx");
                        flag = false;
                        Console.WriteLine("insira matrícula:");
                        value = Console.ReadLine();
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
                    if (anoCarro.IsMatch(Convert.ToString(value)))
                    {
                        _ano = value;
                        Console.WriteLine("Ano do carro \"{0}\" foi adicionado com sucesso.", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("O ano foi inserido com formato errado, inserir ano com formato AAAA");
                        flag = false;
                        Console.WriteLine("insira ano:");
                        value = int.Parse(Console.ReadLine());
                    }
                } while (flag != true);
            }
        }

        public double KmIniciais
        {
            get { return _kmIniciais; }
            set
            {
                bool flag = false;
                do
                {
                    if (value>=0)
                    {
                        _kmIniciais = value;
                        Console.WriteLine("KM's do carro \"{0}\" foram adicionados com sucesso.", value);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("KM's iniciais do carro não pode ser um valor negativo");
                        flag = false;
                        Console.WriteLine("insira KM's iniciais:");
                        value = double.Parse(Console.ReadLine());
                    }
                } while (flag != true);
            }
        }

        public string TipoCombustivel
        {
            get { return _tipoCombustivel; }
            set
            {
                bool flag = false;
                do
                {
                    string[] tipoGota = { "Gasóleo", "Diesel", "Gasolina", "GPL", "Bio Diesel" };
                    foreach (string tipo in tipoGota)
                    {
                        if (String.Compare(tipo, value, CultureInfo.CurrentCulture,CompareOptions.IgnoreCase|CompareOptions.IgnoreNonSpace) == 0)
                            flag = true;
                    }
                    if (flag == true)
                    {
                        _tipoCombustivel = value;
                        Console.WriteLine("o tipo de combustivel \"{0}\" foi adicionado com sucesso", value);
                        break;
                    }
                    else
                        Console.WriteLine("o tipo de combustivel inserido não faz parte das opções disponiveis.\nEscolha uma:\n[1]Diesel\n[2]Gasolina\n[3]GPL\n[4]Bio Diesel");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            value = "Diesel";
                            break;
                        case 2:
                            value = "Gasolina";
                            break;
                        case 3:
                            value = "GPL";
                            break;
                        case 4:
                            value = "Bio Diesel";
                            break;
                        default:
                            break;
                    }
                } while (flag != true);
            }
        }

        public double totalGastoEmCombustivel()
        {
            double total = 0;
            foreach (Abastecimento abs in listaAbast)
                total += abs._valor;
            return total;
        }

        public double consumoMedio()
        {
            double kms = 0, litros = 0;
            foreach (Abastecimento abs in listaAbast) {
                kms += abs._km;
                litros += abs._litros;
            }
             return (100*litros)/kms;
        }
    }
}
