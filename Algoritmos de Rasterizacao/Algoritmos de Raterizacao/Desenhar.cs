using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Algoritmos_de_Raterizacao
{
    public class Desenhar
    {
        public void DesenharIM(int xi, int yi, int xf, int yf)
        { 
            Rasterizacao raster = new Rasterizacao();

            raster.Imediato(xi, yi, xf, yf);
            for (int lin = 10; lin >= 0; lin--)
            {
                for (int col = 0; col <= 10; col++)
                {
                    Point p = new Point(col, lin);

                    if (raster.filaIM.Contains(p)) //DUVIDA AQUI: Não sei se é possivel verificar igualdade do objeto
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" \u25A0");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DesenharBR(int xi, int yi, int xf, int yf)
        {
            Rasterizacao raster = new Rasterizacao();
            raster.Brensenham(xi, yi, xf, yf);
            for (int lin = 0; lin <= 10; lin++)
            {
                for (int col = 10; col >= 0; col--)
                {
                    Point p = new Point(col, lin);
                    if (raster.filaBR.Contains(p))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" \u25A0");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void CapturaDados(out int xi, out int xf, out int yi, out int yf, String algor)
        {
            Console.Clear();
            Console.WriteLine("\n\n ## Informe as coordenadas de origem (Xi, Yi): ");
            Console.Write("Xi: ");
            xi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yi: ");
            yi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("## Agora informe as coordenadas de destino (Xf, Yf): ");
            Console.Write("Xf: ");
            xf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yf: ");
            yf = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("## Coordenadas informadas para o algoritmo ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(algor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.WriteLine("\n## Origem: (" + xi + ";" + yi + ")" + " Destino: (" + xf + ";" + yf + ")");
        }
    }
}
