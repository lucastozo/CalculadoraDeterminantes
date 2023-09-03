using DeterminanteForms.Helper;
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
        int matrixSize;

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if(matrixSize <= 0)
            {
                btNovaMatriz_Click(sender, e);
                return;
            }
            MessageBox.Show("Determinante: " + Calculate.CalcularDeterminante(matrixSize, panelMatrixField), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btNovaMatriz_Click(object sender, EventArgs e)
        {
            matrixSize = DrawMatrix.RequestMatrixSize(matrixSize, panelMatrixField);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            frmInfo form = new frmInfo();
            form.ShowDialog();
        }
    }
}
