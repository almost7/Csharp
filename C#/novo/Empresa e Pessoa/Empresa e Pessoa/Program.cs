using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_e_Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Contato c1 = new Contato(12773423, "Carlos Carvalho", 932603044, "carlos.carvalho@gmail.com");
            Pessoa p1 = new Pessoa(12957927, "Sofia Carvalho", 932598714, "sofia.carvalho@gmail.com",1986,10,10);
            Empresa e1 = new Empresa("eng. Carlos", "rua timor", 14, 212917650, "Muita Pasta", 229757956, "muitapasta@gmail.com");
            Console.WriteLine(e1);
            Console.WriteLine(p1);
            Console.WriteLine("idade: "+p1.calcularIdade());
            Console.WriteLine(c1);
            Contato c5 = inserirContato();
            Console.WriteLine(c5);*/
            Console.WriteLine("insira Ano");
            int ano = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("insira Mes");
            Console.Write(ano + "/");
            int mes = int.Parse(Console.ReadLine());
            /*Contato[] vetorContatos = new Contato[200];
            Contato contac = new Contato();
            Pessoa[] vetorPessoas = new Pessoa[200];
            Pessoa pess = new Pessoa();
            int contC = 0, contP = 0, contE = 0;
            Console.WriteLine("o que pretende inserir? \n[1] Contato \n[2] Pessoa \n[3] Empresa");
            int escolha = int.Parse(Console.ReadLine());
            do
            {
                switch (escolha)
                {
                    case 1:
                        contac = inserirContato();
                        vetorContatos[contC] = contac;
                        contC++;
                        break;
                    case 2:
                        pess = inserirPessoa();
                        vetorPessoas[contP] = pess;
                        contP++;
                        break;
                    case 3:

                         break;
                }
                Console.WriteLine("o que pretende inserir? \n[1] Contato \n[2] Pessoa \n[3] Empresa \n[0] Sair");
                escolha= int.Parse(Console.ReadLine());
            } while (escolha != 0);
            Console.Clear();
            for (int i=0;i<contC;i++)
                Console.WriteLine(vetorContatos[i].ToString());
            for (int i = 0; i < contP; i++)
                Console.WriteLine(vetorContatos[i].ToString());
            System.Threading.Thread.Sleep(7000);  


            Contato inserirContato()
            {
                Console.WriteLine("nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("telefone:");
                int tel = int.Parse(Console.ReadLine());
                Console.WriteLine("mail:");
                string mail = Console.ReadLine();
                Contato c = new Contato(id, nome, tel, mail);
                return c;
            }
            */
            Pessoa inserirPessoa()
            {
                Console.WriteLine("nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("telefone:");
                int tel = int.Parse(Console.ReadLine());
                Console.WriteLine("mail:");
                string mail = Console.ReadLine();
                Console.WriteLine("insira Ano");
                int ano = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("insira Mes");
                Console.Write(ano + "/");
                int mes = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("insira Dia");
                Console.Write(ano + "/"+mes+"/");
                int dia = int.Parse(Console.ReadLine());
                Pessoa p = new Pessoa(id, nome, tel, mail, ano, mes, dia);
                return p;
            }
        }
    }
}
