using System;

namespace CalculoDeterminante
{
    public class Helper
    {
        public static void EscreverErro(string erro)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(erro);
            Console.ResetColor();
        }

        public static void ImprimirMatriz(double[,] matriz, string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine();

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i, j],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}