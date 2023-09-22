using DeterminanteForms.Helper;
using DeterminanteForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeterminanteForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private static double[,] matriz;
        int matrixSize;

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (matrixSize <= 0)
            {
                btNovaMatriz_Click(sender, e);
                return;
            }
            MessageBox.Show("Determinante: " + Calculo.CalcularDeterminante(matrixSize, panelMatrixField), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btNovaMatriz_Click(object sender, EventArgs e)
        {
            matrixSize = DesenharMatriz.RequestMatrixSize(matrixSize, panelMatrixField);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            frmInfo form = new frmInfo();
            form.ShowDialog();
        }

        private void btSalvarMatriz_Click(object sender, EventArgs e)
        {
            double[,] matrix = Calculo.GetMatrixFromFields(matrixSize, panelMatrixField);
            SaveLoad.SalvarMatriz(matrix);
        }

        private void btCarregarMatriz_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo MTX (*.mtx)|*.mtx";
            openFileDialog.Title = "Carregar matriz de";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                matriz = SaveLoad.CarregarMatriz(openFileDialog.FileName);
                if (matriz != null)
                {
                    matrixSize = matriz.GetLength(0);
                    DesenharMatriz.AddMatrixFields(matrixSize, panelMatrixField, matriz);
                }
            }
        }
    }
}