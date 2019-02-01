using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    class Data
    {
        private int _ano;
        private int _mes;
        private int _dia;
        public Hora H { get; set; }
        private string diaSemana;

        public Data()
        {
            _ano = 2000;
            _mes = 01;
            _dia = 01;
            H = new Hora();
            diaSemana = "";
        }

        public Data(int a, int m, int d, int hora, int min, int seg, String ds)
        {
            Ano = a;
            if(Ano==0)
                Ano = 2000;    
            Mes = m;
            if (Mes == 0)
                Mes = 01;
            Dia = d;
            if (Dia == 0)
                Dia = 01;
            H = new Hora(hora, min, seg);
            diaSemana = ds;
        }

        public Data(Data d)
        {
            this.Ano = d.Ano;
            this.Mes = d.Mes;
            this.Dia = d.Dia;
            this.H = d.H;
            this.diaSemana = d.diaSemana;
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
                if (value > 0 && value <13 && (_ano == DateTime.Now.Year && value <= DateTime.Now.Month))
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
            return Ano+"/"+Mes+"/"+Dia+" \n"+H + " \n" +diaSemana;
        }

        public void setDiaSemana(string a)
        {
            diaSemana = a;
        }

        public int difEntreAnos(Data a)
        {
            if (this.Ano > a.Ano)
            {
                if (this.Mes >= a.Mes)
                    return Math.Abs(this.Ano - a.Ano);
                else
                    if (this.Mes < a.Mes)
                    return Math.Abs(this.Ano - a.Ano) - 1;
            }
            else
            {
                if (this._ano < a.Ano)
                    if (a.Mes >= this.Mes)
                        return Math.Abs(a.Ano - this.Ano);
                    else
                       if (a.Mes < this.Mes)
                        return Math.Abs(a.Ano - this.Ano) - 1;
            }
            return 0;
            }

    }

}
