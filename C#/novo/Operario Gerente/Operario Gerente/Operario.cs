using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operario_Gerente
{
    class Operario : Funcionario
    {
        public string Departamento { get; set; }

        public Operario()
        {
            Departamento = "";
        }

        public Operario(string d, int id, string nome, int ano, int mes, int dia, string email, double valorHora) : base(id, nome, ano, mes, dia, email, valorHora)
        {
            Departamento = d;
        }

        public Operario(Operario d)
        {
            this.Departamento = d.Departamento;
            this.id = d.id;
            this.nome = d.nome;
            this.dataNasc = d.dataNasc;
            this.eMail = d.eMail;
            this.valorHora = d.valorHora;
        }

        public override string ToString()
        {
            return " " + getId() + " " + getNome() + " " + dataNasc.ToString() + " " + GetEMail() + "\nVALOR HORA: " + getValorHora()+"\nDEPARTAMENTO: "+Departamento;
        }

        public string ToStringToFich()
        {
            return Departamento + "," + "," + getId() + "," + getNome() + "," + dataNasc.Ano + "," + dataNasc.Mes + "," + dataNasc.Dia + "," + GetEMail() + "," + getValorHora();
        }
    }
}
