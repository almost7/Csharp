using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_e_Pessoa
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telef { get; set; }
        public string EMail { get; set; }

        public Contato()
        {
            Id = 0;
            Nome = "sem nome";
            Telef = 0;
            EMail = "";                
        }

        public Contato(int id, string nome, int tel, string mail)
        {
            Id = id;
            Nome = nome;
            Telef = tel;
            EMail = mail;
        }

        public Contato(Contato c)
        {
            this.Id = c.Id;
            this.Nome = c.Nome;
            this.Telef = c.Telef;
            this.EMail = c.EMail;
        }

        public override string ToString()
        {
            return "\nCONTATO:\nID: "+Id+"\nNome: "+Nome+"\nTelefone: "+Telef+"\nEmail: "+EMail;
        }
    }
}
