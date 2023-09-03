using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterminanteForms
{
    internal class Calculate
    {
        public static double[,] GetMatrixFromFields(int size, Panel panelMatrixField)
        {
            double[,] matrix = new double[size, size];
            int index = 0;
            foreach (Control control in panelMatrixField.Controls)
            {
                if (control is TextBox)
                {
                    int i = index / size;
                    int j = index % size;
                    if (string.IsNullOrEmpty(control.Text) || control.Text=="-")
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = double.Parse(control.Text);
                    }
                    index++;
                }
            }
            return matrix;
        }

        public static double Determinante(double[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            if (tamanho > 2)
            {
                double soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    double[,] subMatriz = GetSubMatriz(matriz, i);
                    soma += Math.Pow(-1, i) * matriz[0, i] * Determinante(subMatriz);
                }
                return soma;
            }
            else if (tamanho == 2)
            {
                return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
            }
            else
            {
                return matriz[0, 0];
            }
        }

        static double[,] GetSubMatriz(double[,] matrizOriginal, int colunaARemover)
        {
            int tamanho = matrizOriginal.GetLength(0);
            double[,] subMatriz = new double[tamanho - 1, tamanho - 1];
            int colunaSubMatriz = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (i != colunaARemover)
                {
                    for (int j = 1; j < tamanho; j++)
                    {
                        subMatriz[j - 1, colunaSubMatriz] = matrizOriginal[j, i];
                    }
                    colunaSubMatriz++;
                }
            }
            return subMatriz;
        }

        public static double CalcularDeterminante(int matrixSize, Panel panelMatrixField)
        {
            double[,] matrix = GetMatrixFromFields(matrixSize, panelMatrixField);
            double determinant = Determinante(matrix);
            return determinant;
        }
    }
}
