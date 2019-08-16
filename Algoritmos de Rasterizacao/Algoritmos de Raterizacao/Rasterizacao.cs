using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Algoritmos_de_Raterizacao
{
    class Rasterizacao
    {
        public Queue<Point> filaIM = new Queue<Point>();
        public Queue<Point> filaBR = new Queue<Point>();
        public void Imediato(int Xi, int Yi, int Xf, int Yf)
        {
            Double DeltaY, DeltaX, m, b, Ylinha;

            DeltaY = Yf - Yi;
            DeltaX = Xf - Xi;
            m = DeltaY / DeltaX;
            b = (Yi - (m * Xi));
            Point p;
            for (int x = Xi; x <= Xf; x++)
            {
                Ylinha = (m * x + b);
                p = new Point(x, Convert.ToInt32(Math.Floor(Ylinha)));
                filaIM.Enqueue(p);
            }
        }
        public void Brensenham(int Xi, int Yi, int Xf, int Yf)
        {
            Double DeltaY, DeltaX, decisao, incE, incNE, y;
            DeltaY = Yf - Yi;
            DeltaX = Xf - Xi;
            decisao = 2 * (DeltaY - DeltaX);
            incE = 2 * DeltaY;
            incNE = decisao;
            y = Yi;
            Point p;
            for (int x = Xi; x <= Xf; x++)
            {
                if (decisao <= 0) decisao += incE;
                else
                {
                    decisao += incNE;
                    y++;
                }
                p = new Point(x, Convert.ToInt32(y)); //passa valores para construtor
                filaBR.Enqueue(p);//guarda o objeto criado
            }
        }
    }
}
