using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos_de_Raterizacao
{
    public class Ponto
    {
        private double x, y;
        public Ponto() { }
        public Ponto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX() { return x; }
        public double GetY() { return y; }

    }
}
