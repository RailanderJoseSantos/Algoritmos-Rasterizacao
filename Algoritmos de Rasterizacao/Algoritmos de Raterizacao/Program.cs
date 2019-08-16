using Algoritmos_de_Raterizacao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Algoritmos_de_Rasterizacao
{
    class Program
    {
        static void DesenharIM(int xi, int yi, int xf, int yf)
        {
            Rasterizacao raster = new Rasterizacao();

            raster.Imediato(xi, yi, xf, yf);
            for (int lin = 10; lin >= 0; lin--)
            {
                for (int col = 0; col <= 10; col++)
                {
                    Point p = new Point(col, lin);
                    
                    if ( raster.filaIM.Contains(p)) //DUVIDA AQUI: Não sei se é possivel verificar igualdade do objeto
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
        static void DesenharBR(int xi, int yi, int xf, int yf)
        {
            Rasterizacao raster = new Rasterizacao();
            raster.Brensenham(xi, yi, xf, yf);
            for (int lin = 10; lin >= 0; lin--)
            {
                for (int col = 0; col <= 10; col++)
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
        static void Main(string[] args)
        {

            int xi, yi, xf, yf;
            String algoritimo;
            int op = 1532;
            do
            {
                Console.WriteLine(" ##### Qual algoritmo deseja visualizar?  1 - Imediato 2 - Bresenham  3- Ambos 4- Sair  ##### \n");
                Console.Write("> ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    algoritimo = "Imediato";
                    Captura(out xi, out xf, out yi, out yf, algoritimo);
                    DesenharIM(xi, yi, xf, yf);
                }
                else if (opcao == 2)
                {
                    algoritimo = "Bresenham";
                    Captura(out xi, out xf, out yi, out yf, algoritimo);
                    DesenharBR(xi, yi, xf, yf);
                }else if( opcao == 3)
                {
                    Captura(out xi, out xf, out yi, out yf, "Bresenham");
                    DesenharBR(xi, yi, xf, yf);

                    Console.Write(" ## Coordenadas informadas para o algoritmo ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Imediato");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(":");
                    Console.WriteLine("\n## Origem: (" + xi + ";" + yi + ")" + " Destino: (" + xf + ";" + yf + ")");

                    DesenharIM(xi, yi, xf, yf);
                }else
                if (opcao == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nOpção inválida!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(600);
                }
            } while (op != 4);

            //raster.Imediato(1, 2, 9, 8);



        }

        public static void Captura(out int xi, out int xf, out int yi, out int yf, String algor)
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
            Console.WriteLine("\n## Origem: ("+xi +";" +yi+ ")" + " Destino: (" + xf + ";" + yf + ")");
        }
    }
}
