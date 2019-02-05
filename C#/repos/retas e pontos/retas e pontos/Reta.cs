using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retas_e_pontos
{
    class Reta
    {
        public Ponto p1;
        public Ponto p2;

        public Reta()
        {
            p1.X = 0;
            p1.Y = 0;
            p2.X = 0;
            p2.Y = 0;
        }

        public Reta(int a, int b, int c, int d)
        {
            p1.X = a;
            p1.Y = b;
            p2.X = c;
            p2.Y = d;
        }

        public Reta(Ponto a, Ponto b)
        {
            p1 = a;
            p2 = b;
        }

        public Reta(Reta r)
        {
            this.p1 = r.p1;
            this.p2 = r.p2;
        }

        public override string ToString()
        {
            return "Reta (" + p1.X + "," + p1.Y + ") + (" + p2.X + "," + p2.Y + ")";
        }
    }

}
