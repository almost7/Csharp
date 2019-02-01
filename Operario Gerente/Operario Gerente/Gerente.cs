using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operario_Gerente
{
    class Gerente : Funcionario
    {
        public string Especialidade { get; set; }
        public int Extensao { get; set; }

        public Gerente()
        {
            Especialidade = "";
            Extensao = 0;
        }

        public Gerente(string e, int x, int id, string nome, int ano, int mes, int dia, string email, double valorHora) : base(id, nome, ano, mes, dia, email, valorHora)
        {
            Especialidade = e;
            Extensao = x;
        }

        public Gerente(Gerente g)
        {
            this.Especialidade = g.Especialidade;
            this.Extensao = g.Extensao;
            this.id = g.id;
            this.nome = g.nome;
            this.dataNasc = g.dataNasc;
            this.eMail = g.eMail;
            this.valorHora = g.valorHora;
        }

        public override string ToString()
        {
            return "\nGERENTE\nID: " + getId() + "\nNOME: " + getNome() + "\nDATANASC: " + dataNasc.ToString() + "\nEMAIL: " + GetEMail() + "\nVALOR HORA: " + getValorHora() + "\nESPECIALIDADE: " + Especialidade+"\nEXTENSÃO: "+Extensao;
        }

        public string ToStringToFich()
        {
            return Especialidade + "," + Extensao + "," + getId() + "," + getNome() + "," + dataNasc.Ano + "," + dataNasc.Mes + "," + dataNasc.Dia + "," + GetEMail() + "," + getValorHora();
        }
    }
}
