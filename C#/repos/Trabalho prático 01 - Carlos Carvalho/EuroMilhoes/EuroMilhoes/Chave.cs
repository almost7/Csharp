using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroMilhoes
{
    class Chave
    {
        public int[] numeros = new int[7];
        public int[] estrelas = new int[3];

        public Chave()
        {
            numeros[0] = 0;
            numeros[1] = 0;
            numeros[2] = 0;
            numeros[3] = 0;
            numeros[4] = 0;
            numeros[5] = 0;
            numeros[6] = 0;
            estrelas[0] = 0;
            estrelas[1] = 0;
            estrelas[2] = 0;
        }

        public Chave(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int e1, int e2, int e3)
        {
            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;
            numeros[3] = n4;
            numeros[4] = n5;
            numeros[5] = n6;
            numeros[6] = n7;
            estrelas[0] = e1;
            estrelas[1] = e2;
            estrelas[2] = e3;
        }

        public Chave(Chave ch)
        {
            this.numeros = ch.numeros;
            this.estrelas = ch.estrelas;
        }

        public int getNumeros()
        {
            foreach (int num in numeros)
                return num;
            return 0;
        }

        public int getEstrelas()
        {
            foreach (int num in estrelas)
                return num;
            return 0;
        }

        public override string ToString()
        {
            return "\nChave\nnumeros: " + numeros[0] + "," + numeros[1] + "," + numeros[2] + "," + numeros[3] + "," + numeros[4] + "," + numeros[5] + "," + numeros[6] + " | estrelas: " + estrelas[0] + "," + estrelas[1] + "," + estrelas[2];
        }

        public string ToStringToFich()
        {
            return numeros[0] + "," + numeros[1] + "," + numeros[2] + "," + numeros[3] + "," + numeros[4] + "," + numeros[5] + "," + numeros[6] + "," + estrelas[0] + "," + estrelas[1] + "," + estrelas[2];
        }
    }
}
