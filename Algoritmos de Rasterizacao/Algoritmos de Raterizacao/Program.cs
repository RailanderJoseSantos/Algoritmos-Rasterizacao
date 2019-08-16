using Algoritmos_de_Raterizacao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Algoritmos_de_Rasterizacao
{
   class Program
    {
        static void Main(string[] args)
        {
            Desenhar d = new Desenhar();
            int xi, yi, xf, yf;
            String algoritimo;
            int op = 1532;
            do
            {
                Console.WriteLine(" ##### Qual algoritmo deseja visualizar?  1- Imediato 2- Bresenham  3- Ambos 4- Sair  ##### \n");
                Console.Write("> ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    algoritimo = "Imediato";
                    d.CapturaDados(out xi, out xf, out yi, out yf, algoritimo);
                    d.DesenharIM(xi, yi, xf, yf);
                }
                else if (opcao == 2)
                {
                    algoritimo = "Bresenham";
                    d.CapturaDados(out xi, out xf, out yi, out yf, algoritimo);
                    d.DesenharBR(xi, yi, xf, yf);
                }else if( opcao == 3)
                {
                    d.CapturaDados(out xi, out xf, out yi, out yf, "Imediato");
                    d.DesenharIM(xi, yi, xf, yf);
                    Console.Write(" ## Coordenadas informadas para o algoritmo ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Bresenham");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(":");
                    Console.WriteLine("\n## Origem: (" + xi + ";" + yi + ")" + " Destino: (" + xf + ";" + yf + ")");
                    d.DesenharBR(xi, yi, xf, yf);
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
    }
}
