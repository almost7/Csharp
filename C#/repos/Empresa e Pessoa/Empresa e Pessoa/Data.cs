using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_e_Pessoa
{
    class Data
    {
        private int _ano;
        private int _mes;
        private int _dia;

        public Data()
        {
            _ano = 2000;
            _mes = 01;
            _dia = 01;
        }

        public Data(int a, int m, int d)
        {
            Ano = a;
            if (Ano == 0)
                Ano = 2000;
            Mes = m;
            if (Mes == 0)
                Mes = 01;
            Dia = d;
            if (Dia == 0)
                Dia = 01;
        }

        public Data(Data d)
        {
            this.Ano = d.Ano;
            this.Mes = d.Mes;
            this.Dia = d.Dia;
        }

        public int Ano
        {
            get { return _ano; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    _ano = value;
            }
        }

        public int Mes
        {
            get { return _mes; }
            set
            {
                if (value > 0 && value < 13 && (_ano == DateTime.Now.Year && value <= DateTime.Now.Month))
                    _mes = value;
                else
                    if (value > 0 && value < 13 && (_ano < DateTime.Now.Year))
                    _mes = value;
            }
        }

        public int Dia
        {
            get { return _dia; }
            set
            {
                if (value > 0 && value < 31)
                    _dia = value;
            }
        }

        public override string ToString()
        {
            return Dia + "/" + Mes + "/" + Dia;
        }
    }
}
