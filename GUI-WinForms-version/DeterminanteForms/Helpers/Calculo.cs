using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterminanteForms
{
    internal class Calculo
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
                    if (string.IsNullOrEmpty(control.Text) || control.Text == "-")
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
            double det = 1;
            int trocas = 0;

            for (int p = 0; p < tamanho; p++)
            {
                int max = p;
                for (int i = p + 1; i < tamanho; i++)
                {
                    if (Math.Abs(matriz[i, p]) > Math.Abs(matriz[max, p]))
                    {
                        max = i;
                    }
                }

                if (p != max)
                {
                    double[] temp = new double[tamanho];
                    for (int i = 0; i < tamanho; i++)
                    {
                        temp[i] = matriz[p, i];
                        matriz[p, i] = matriz[max, i];
                        matriz[max, i] = temp[i];
                    }
                    trocas++;
                }

                det *= matriz[p, p];
                if (Math.Abs(det) <= 0.000001)
                {
                    return 0;
                }

                for (int i = p + 1; i < tamanho; i++)
                {
                    double f = matriz[i, p] / matriz[p, p];
                    for (int j = p + 1; j < tamanho; j++)
                    {
                        matriz[i, j] -= f * matriz[p, j];
                    }
                    matriz[i, p] = 0;
                }
            }
            return (trocas % 2 == 0 ? 1 : -1) * det;
        }

        public static double CalcularDeterminante(int matrixSize, Panel panelMatrixField)
        {
            double[,] matrix = GetMatrixFromFields(matrixSize, panelMatrixField);
            double determinant = Determinante(matrix);
            return determinant;
        }
    }
}