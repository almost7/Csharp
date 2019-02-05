using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    public class Hora
    {
        private int _h;
        private int _m;
        private int _s;

        public Hora()
        {
            _h = 0;
            _m = 0;
            _s = 0;
        }

        public Hora(int h, int m, int s)
        {
            this.H = h;
            this.M = m;
            this.S = s;
        }

        public Hora(Hora h)
        {
            this._h = h.H;
            this._m = h.M;
            this._s = h.S;
        }

        public int H
        {
            get { return _h; }
            set
            {
                if (value > 0 && value < 25)
                    _h = value;
            }
           
        }

        public int M
        {
            get { return _m; }
            set
            {
                if (value > 0 && value < 60)
                    _m = value;
            }
        }

        public int S
        {
            get { return _s; }
            set
            {
                if (value > 0 && value < 60)
                    _s = value;
            }
        }

        public int difEntre2Horas(Hora h1)
        {
            return Math.Abs((((h1.H * 60) * 60) + (h1.M * 60) + h1.S) - (((this.H * 60) * 60) + (this.M * 60) + this.S));
        }

        public override string ToString()
        {
            return H+":"+M+":"+S;
        }
    }
}
