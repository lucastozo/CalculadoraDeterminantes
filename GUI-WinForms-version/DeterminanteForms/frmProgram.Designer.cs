namespace DeterminanteForms
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gerarNovaMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btCalcular = new System.Windows.Forms.ToolStripButton();
            this.panelMatrixField = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.btInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1204, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNovaMatrizToolStripMenuItem,
            this.salvarMatrizToolStripMenuItem,
            this.carregarMatrizToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Arquivo";
            // 
            // gerarNovaMatrizToolStripMenuItem
            // 
            this.gerarNovaMatrizToolStripMenuItem.Name = "gerarNovaMatrizToolStripMenuItem";
            this.gerarNovaMatrizToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gerarNovaMatrizToolStripMenuItem.Text = "Gerar Nova Matriz";
            this.gerarNovaMatrizToolStripMenuItem.Click += new System.EventHandler(this.btNovaMatriz_Click);
            // 
            // salvarMatrizToolStripMenuItem
            // 
            this.salvarMatrizToolStripMenuItem.Name = "salvarMatrizToolStripMenuItem";
            this.salvarMatrizToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salvarMatrizToolStripMenuItem.Text = "Salvar Matriz";
            this.salvarMatrizToolStripMenuItem.Click += new System.EventHandler(this.btSalvarMatriz_Click);
            // 
            // carregarMatrizToolStripMenuItem
            // 
            this.carregarMatrizToolStripMenuItem.Name = "carregarMatrizToolStripMenuItem";
            this.carregarMatrizToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.carregarMatrizToolStripMenuItem.Text = "Carregar Matriz";
            this.carregarMatrizToolStripMenuItem.Click += new System.EventHandler(this.btCarregarMatriz_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btInfo
            // 
            this.btInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(32, 22);
            this.btInfo.Text = "Info";
            this.btInfo.ToolTipText = "Informações sobre o programa";
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCalcular});
            this.toolStrip2.Location = new System.Drawing.Point(0, 607);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1204, 54);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btCalcular
            // 
            this.btCalcular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btCalcular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btCalcular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCalcular.Margin = new System.Windows.Forms.Padding(5);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Padding = new System.Windows.Forms.Padding(5);
            this.btCalcular.Size = new System.Drawing.Size(234, 44);
            this.btCalcular.Text = "Calcular Determinante";
            this.btCalcular.ToolTipText = "Calcular";
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // panelMatrixField
            // 
            this.panelMatrixField.AutoScroll = true;
            this.panelMatrixField.AutoSize = true;
            this.panelMatrixField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatrixField.Location = new System.Drawing.Point(0, 25);
            this.panelMatrixField.Name = "panelMatrixField";
            this.panelMatrixField.Size = new System.Drawing.Size(1204, 582);
            this.panelMatrixField.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.Controls.Add(this.panelMatrixField);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Determinantes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btInfo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panelMatrixField;
        private System.Windows.Forms.ToolStripButton btCalcular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem gerarNovaMatrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarMatrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarMatrizToolStripMenuItem;
    }
}

