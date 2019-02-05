using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retas_e_pontos
{
    public class Ponto
    {
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public Ponto()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Ponto(int a, int b)
        {
            this.X = a;
            this.Y = b;
        }

        public Ponto(Ponto p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }

        public override string ToString()
        {
            return "Ponto ("+X+","+Y+")";
        }

        /*public double distEntrePontos(Ponto a, Ponto b)
        {

        } */
    }
}
