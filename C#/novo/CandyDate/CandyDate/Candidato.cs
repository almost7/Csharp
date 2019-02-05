using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyDate
{
    class Candidato
    {
        public string Nome { get; set; }
        public string Localidade { get; set; }
        private Data dataNasc;
        public string Sexo { get; set; }
        public string Email { get; set; }
        private int telefone;
        private string[] habilitacoes = new string [3];
        private string[] experiencias = new string [5];
        private string[] competencias = new string [5];

        public Candidato()
        {
            Nome = "";
            Localidade = "";
            dataNasc = new Data();
            Sexo = "";
            Email = "";
            telefone = 0;
        }

        public Candidato(string nome, string localidade, int ano, int mes, int dia, string sexo, string email, int telefone)
        {
            Nome = nome;
            Localidade = localidade;
            dataNasc = new Data(ano,mes,dia);
            Sexo = sexo;
            Email = email;
            this.telefone = telefone;
            setHabilitacoes();
            setExperiencias();
            setCompetencias();
        }

        public Candidato(string nome, string localidade, int ano, int mes, int dia, string sexo, string email, int telefone, string hab1, string hab2, string hab3, string exp1, string exp2, string exp3, string exp4, string exp5, string comp1, string comp2, string comp3, string comp4, string comp5)
        {
            Nome = nome;
            Localidade = localidade;
            dataNasc = new Data(ano, mes, dia);
            Sexo = sexo;
            Email = email;
            this.telefone = telefone;
            habilitacoes[0] = hab1; habilitacoes[1] = hab2; habilitacoes[2] = hab3;
            experiencias[0] = exp1; experiencias[1] = exp2; experiencias[2] = exp3; experiencias[3] = exp4; experiencias[4] = exp5;
            competencias[0] = comp1; competencias[1] = comp2; competencias[2] = comp3; competencias[3] = comp4; competencias[4] = comp5;
        }

        public Candidato(Candidato c)
        {
            Nome = c.Nome;
            Localidade = c.Localidade;
            dataNasc = c.dataNasc;
            Sexo = c.Sexo;
            Email = c.Email;
            this.telefone = c.telefone;
            string[] habilitacoes = c.habilitacoes;
            string[] experiencias = c.experiencias;
            string[] competencias = c.competencias;
        }

        public void setTelefone(int a)
        {
            this.telefone = a;
        }

        public int getTelefone()
        {
            return telefone;
        }

        public override string ToString()
        {

            return "\nnome: "+ Nome + "\nlocalidade: " + Localidade + "\ndata de nascimento :" + dataNasc.ToString() + "\nsexo :" + Sexo + "\nemail :" + Email + "\ntelefone :" + getTelefone() + "\nhabilitações literárias :" + listArray(habilitacoes) + "\nexperiência profissional :" + listArray(experiencias) + "\ncompetências: " + listArray(competencias);
        }

        public string ToFich()
        {
            return Nome + ";" + Localidade + ";" + dataNasc.Ano + ";" + dataNasc.Mes + ";" + dataNasc.Dia + ";" + Sexo + ";" + Email + ";" + getTelefone() + stringToFich(habilitacoes) + stringToFich(experiencias) + stringToFich(competencias);
        }

        public string listArray(string[] a)
        {
            string end = null;
            if (a == null)
                return "campo vazio  ";
            foreach (string x in a)
                if (x != null)
                    end += x + " ,";
                else
                    return end;
            return end;
        }

        public void setHabilitacoes()
        {
            int c = 0;
            ConsoleKeyInfo k;
            foreach (string x in habilitacoes)
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)+15) + "}", "Habilitações literárias (máx 3)"));
                Console.WriteLine("pretende inserir alguma habilitação literária? \n[ENTER] para inserir - [ESQ] para sair");
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(c + 1 + "ª habilitação:");
                    habilitacoes[c] = Console.ReadLine();
                    c++;
                }
                else if (k.Key == ConsoleKey.Escape)
                    break;
            }
        }

        public void setExperiencias()
        {
            int c = 0;
            ConsoleKeyInfo k;
            Console.WriteLine("Experiência profissional (máx 5)");
            foreach (string x in experiencias)
            {
                Console.Clear();
                Console.WriteLine("pretende inserir alguma experiência profissional? \n[ENTER] para inserir - [ESQ] para sair");
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(c+1 +"ª experiência:");
                    experiencias[c] = Console.ReadLine();
                    c++;
                }
                else if (k.Key == ConsoleKey.Escape)
                    break;
            }
        }

        public void setCompetencias()
        {
            int c = 0;
            ConsoleKeyInfo k;
            Console.WriteLine("Competências (máx 5)");
            foreach (string x in competencias)
            {
                Console.Clear();
                Console.WriteLine("pretende inserir alguma competência? \n[ENTER] para inserir - [ESQ] para sair");
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(c + 1 + "ª competência:");
                    competencias[c] = Console.ReadLine();
                    c++;
                }
                else if (k.Key == ConsoleKey.Escape)
                    break;
            }
        }

        public string stringToFich(String[] a)
        {
            string final = null;
            foreach (String cena in a) {
                final += (cena != null) ? ";" + cena : ";null";
             }
            return final;
        }

        


    }
}
