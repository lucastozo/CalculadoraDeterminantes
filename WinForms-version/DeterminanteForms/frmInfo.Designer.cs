namespace DeterminanteForms
{
    partial class frmInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pbIcon;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMiddleText = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            pbIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(pbIcon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMiddleText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbVersion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbAuthor, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            pbIcon.Image = global::DeterminanteForms.Properties.Resources.matrix_icon;
            pbIcon.Location = new System.Drawing.Point(203, 3);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(393, 119);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // lbMiddleText
            // 
            this.lbMiddleText.AutoSize = true;
            this.lbMiddleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMiddleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddleText.Location = new System.Drawing.Point(203, 175);
            this.lbMiddleText.Name = "lbMiddleText";
            this.lbMiddleText.Size = new System.Drawing.Size(393, 200);
            this.lbMiddleText.TabIndex = 1;
            this.lbMiddleText.Text = "Trabalho feito para a disciplina de V.G.A.\r\nprof. Dornellas\r\nUFMT - IC";
            this.lbMiddleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(203, 125);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(393, 50);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Calculadora de Determinante de Matrizes";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVersion.Location = new System.Drawing.Point(3, 375);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(194, 75);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "Versão: x.x";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAuthor.Location = new System.Drawing.Point(602, 375);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(195, 75);
            this.lbAuthor.TabIndex = 4;
            this.lbAuthor.Text = "Autor: Lucas Tozo Monção";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informações";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbMiddleText;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbAuthor;
    }
}