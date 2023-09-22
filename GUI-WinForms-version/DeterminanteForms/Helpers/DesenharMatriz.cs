using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterminanteForms.Helper
{
    internal class DesenharMatriz
    {
        public static int RequestMatrixSize(int matrixSize, Panel panelMatrixField)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Insira o tamanho da matriz:", "Tamanho da matriz");
            if (string.IsNullOrEmpty(input))
            {
                return matrixSize;
            }

            try
            {
                matrixSize = Convert.ToInt32(input);
                if (matrixSize > 0)
                {
                    AddMatrixFields(matrixSize, panelMatrixField);
                }
                else
                {
                    MessageBox.Show("Entrada inválida. Insira um número inteiro positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RequestMatrixSize(matrixSize, panelMatrixField);
                }
            }
            catch
            {
                MessageBox.Show("Entrada inválida. Insira um número inteiro positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RequestMatrixSize(matrixSize, panelMatrixField);
            }

            return matrixSize;
        }
        public static void AddMatrixFields(int size, Panel panelMatrixField, double[,] values = null)
        {
            // Limpa o painel
            panelMatrixField.Controls.Clear();

            // Adiciona os textbox
            int margin = 10;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var textBox = new TextBox();
                    textBox.Width = 65;
                    textBox.Height = 40;
                    textBox.MaxLength = 7;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Top = margin + i * (textBox.Height + 5);
                    textBox.Left = margin + j * (textBox.Width + 5);
                    textBox.KeyPress += TextBox_KeyPress;
                    textBox.Margin = new Padding(10);

                    // Se a matriz de valores foi fornecida, carrega o valor no campo de texto
                    if (values != null)
                    {
                        textBox.Text = values[i, j].ToString();
                    }

                    panelMatrixField.Controls.Add(textBox);
                }
            }
        }

        private static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            bool alreadyHasDot = textBox.Text.Contains(".");
            bool alreadyHasComma = textBox.Text.Contains(",");
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '-' || textBox.SelectionStart != 0 || (textBox.SelectionLength == 0 && textBox.SelectionStart < textBox.Text.Length && (textBox.Text[textBox.SelectionStart] == '.' || textBox.Text[textBox.SelectionStart] == ',')))
                && (e.KeyChar != '.' || alreadyHasDot || alreadyHasComma || textBox.SelectionStart == 0 || (textBox.SelectionLength == 0 && textBox.SelectionStart > 0 && textBox.Text[textBox.SelectionStart - 1] == '-'))
                && (e.KeyChar != ',' || alreadyHasComma || alreadyHasDot || textBox.SelectionStart == 0 || (textBox.SelectionLength == 0 && textBox.SelectionStart > 0 && textBox.Text[textBox.SelectionStart - 1] == '-')))
            {
                e.Handled = true;
            }
        }
    }
}