using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DeterminanteForms.Helpers
{
    internal class SaveLoad
    {
        public static void SalvarMatriz(double[,] matriz)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo MTX (*.mtx)|*.mtx";
            saveFileDialog.Title = "Salvar matriz como";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;
                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);

                using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                {
                    sw.WriteLine($"{linhas} {colunas}");
                    for (int i = 0; i < linhas; i++)
                    {
                        for (int j = 0; j < colunas; j++)
                        {
                            sw.Write(matriz[i, j] + " ");
                        }
                        sw.WriteLine();
                    }
                }
            }
        }

        public static double[,] CarregarMatriz(string caminhoArquivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string[] dimensoes = sr.ReadLine().Split(' ');
                    if (dimensoes.Length != 2 || int.Parse(dimensoes[0]) != int.Parse(dimensoes[1]))
                    {
                        MessageBox.Show("Arquivo inválido. O arquivo deve representar uma matriz quadrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    int linhas = int.Parse(dimensoes[0]);
                    int colunas = int.Parse(dimensoes[1]);

                    double[,] matriz = new double[linhas, colunas];
                    for (int i = 0; i < linhas; i++)
                    {
                        string[] valoresLinha = sr.ReadLine().Trim().Split(' ');
                        if (valoresLinha.Length != colunas)
                        {
                            MessageBox.Show("Arquivo inválido. Todas as linhas devem ter o mesmo número de colunas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }

                        for (int j = 0; j < colunas; j++)
                        {
                            if (string.IsNullOrEmpty(valoresLinha[j]))
                            {
                                MessageBox.Show("Arquivo inválido. Nenhum valor pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }

                            matriz[i, j] = double.Parse(valoresLinha[j]);
                        }
                    }

                    return matriz;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}