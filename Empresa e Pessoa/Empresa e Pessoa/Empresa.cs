using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_e_Pessoa
{
    public class Empresa : Contato
    {   
        public string Responsavel { get; set; }
        public string Morada { get; set; }
        public int Atividade { get; set; }

        public Empresa()
        {
            Responsavel = "";
            Morada = "";
            Atividade = 0;
        }

        public Empresa(string r, string m, int a, int id, string nome, int tel, string mail) : base(id, nome, tel, mail)
        {
            Responsavel = r;
            Morada = m;
            Atividade = a;
        }

        public Empresa(Empresa e)
        {
            this.Responsavel = e.Responsavel;
            this.Morada = e.Morada;
            this.Atividade = e.Atividade;
            this.Id = e.Id;
            this.Nome = e.Nome;
            this.Telef = e.Telef;
            this.EMail = e.EMail;
        }

        public override string ToString()
        {
            return "\nEMPRESA:\nID: " + Id + "\nNome: " + Nome + "\nTelefone: " + Telef + "\nEmail: " + EMail+"\nResponsavel: "+Responsavel+"\nMorada: "+Morada+"\nAtividade: "+Atividade;
        }
    }
}
