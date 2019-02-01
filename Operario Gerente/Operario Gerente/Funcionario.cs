using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operario_Gerente
{
    class Funcionario
    {
        protected int id;
        protected string nome;
        protected Data dataNasc;
        protected string eMail;
        protected double valorHora;

        public Funcionario()
        {
            id = 0;
            nome = "";
            dataNasc = new Data();
            eMail = "";
            valorHora = 0;
        }

        public Funcionario(int id, string nome, int ano, int mes, int dia, string email, double valorHora)
        {
            this.id = id;
            this.nome = nome;
            dataNasc = new Data(ano, mes, dia);
            this.eMail = email;
            this.valorHora = valorHora;
        }

        public Funcionario(Funcionario f)
        {
            this.id = f.id;
            this.nome = f.nome;
            this.dataNasc = f.dataNasc;
            this.eMail = f.eMail;
            this.valorHora = f.valorHora;
        }

        public int getId()
        {
            return id;
        }

        public string getNome()
        {
            return nome;
        }

        public Data getDataNasc()
        {
            return dataNasc;
        }

        public string GetEMail()
        {
            return eMail;
        }

        public double getValorHora()
        {
            return valorHora;
        }

        public override string ToString()
        {
            return "\nFUNCIONÁRIO\nID: " + getId() + "\nNOME: "+getNome()+"\nDATANASC: "+dataNasc.ToString()+"\nEMAIL: "+GetEMail()+"\nVALOR HORA: "+getValorHora();
        }

        public int calcIdade()
        {
            if (dataNasc.Mes > DateTime.Now.Month)
                return DateTime.Now.Year - dataNasc.Ano;
            else
                return DateTime.Now.Year - dataNasc.Ano - 1;
        }

        public double calcSal(double horasTrab)
        {
            return horasTrab * this.valorHora;
        }

        public void setValorHora(double v)
        {
            this.valorHora = v;
        }
    }
}

