﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterminanteForms.Helper
{
    internal class DrawMatrix
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
        public static void AddMatrixFields(int size, Panel panelMatrixField)
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
                    textBox.Width = 50;
                    textBox.Height = 20;
                    textBox.MaxLength = 5;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Top = margin + i * (textBox.Height + 5);
                    textBox.Left = margin + j * (textBox.Width + 5);
                    textBox.KeyPress += TextBox_KeyPress;
                    textBox.Margin = new Padding(10);
                    panelMatrixField.Controls.Add(textBox);
                }
            }
        }

        private static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
    }
}