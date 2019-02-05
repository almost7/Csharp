using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_e_Pessoa
{
    class Pessoa : Contato
    {
        public Data DataNasc { get; set; }

        public Pessoa()
        {
            DataNasc = new Data();
        }

        public Pessoa(int id, string nome, int tel, string mail, int ano, int mes, int dia) : base(id, nome, tel, mail)
        {
            DataNasc = new Data(ano, mes, dia);
        }

        public Pessoa(Pessoa p)
        {
            this.DataNasc = p.DataNasc;
            this.Id = p.Id;
            this.Nome = p.Nome;
            this.Telef = p.Telef;
            this.EMail = p.EMail;
        }

        public override string ToString()
        {
            return "\nPESSOA:\nID: " + Id + "\nNome: " + Nome + "\nTelefone: " + Telef + "\nEmail: " + EMail+"\nData Nascimento: "+DataNasc.Dia+"/"+DataNasc.Mes+"/"+DataNasc.Ano;
        }

        public int calcularIdade()
        {
            if (DataNasc.Mes < DateTime.Now.Month)
                return DateTime.Now.Year - DataNasc.Ano;
            if (DataNasc.Mes >= DateTime.Now.Month)
                return (DateTime.Now.Year - DataNasc.Ano)-1;
            return 0;
        }
    }
}
