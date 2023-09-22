using System;
using System.Diagnostics;
using System.Reflection;

namespace CalculoDeterminante
{
    internal class Program
    {
        static void Main()
        {
            int tamanhoMatriz = 0, i = 0, j = 0;

            Console.Clear();
            Console.WriteLine("-- CALCULADORA DE DETERMINANTE DE UMA MATRIZ QUADRADA --");
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Console.WriteLine($"versão: {versionInfo.FileVersion}");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lucas Tozo Monção, programa feito para a disciplina V.G.A. - prof. Dornellas");
                Console.ResetColor();

            Console.Write("Insira o tamanho da matriz: ");
            try
            {
                tamanhoMatriz = Convert.ToInt32(Console.ReadLine());
                if(tamanhoMatriz <= 0)
                {
                    Helper.EscreverErro("O tamanho da matriz precisa ser maior que zero.");
                    Console.ReadKey();
                    Main();
                }
            }
            catch
            {
                Helper.EscreverErro("O tamanho da matriz precisa ser um número inteiro.");
                Console.ReadKey();
                Main();
            }

            Console.Write($"A matriz terá tamanho ");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{tamanhoMatriz}x{tamanhoMatriz}");
                Console.ResetColor();

            Console.WriteLine(", confirme para prosseguir. [S/N]");
            if (Console.ReadLine().ToUpper() != "S")
            {
                Console.Clear();
                Main();
            }

            double[,] matriz = new double[tamanhoMatriz, tamanhoMatriz];
            Console.Clear();

            while (i < tamanhoMatriz)
            {
                j = 0;
                while (j < tamanhoMatriz)
                {
                    bool entradaValida;
                    do
                    {
                        Console.Write($"Insira o valor para a posição [Linha {i + 1}, Coluna {j + 1}]: ");
                        try
                        {
                            matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                            entradaValida = true;
                            j++;
                        }
                        catch
                        {
                            Helper.EscreverErro("O valor a ser inserido na matriz precisa ser um número.");
                            entradaValida = false;
                        }
                    }
                    while (entradaValida == false);
                }
                i++;
            }

            Console.WriteLine();
            Helper.ImprimirMatriz(matriz);
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A determinante da matriz é: " + Calculo.Determinante(matriz));
                Console.ResetColor();

            Console.WriteLine("Pressione qualquer tecla para reiniciar o programa...");
            Console.ReadKey();
            Main();
        }
    }
}