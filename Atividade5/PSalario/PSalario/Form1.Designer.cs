namespace PSalario
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhosqt = new System.Windows.Forms.Label();
            this.nupDFilhos = new System.Windows.Forms.NumericUpDown();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.mboNomeFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mboSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupDFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(108, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 1452;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(108, 88);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 100;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblFilhosqt
            // 
            this.lblFilhosqt.AutoSize = true;
            this.lblFilhosqt.Location = new System.Drawing.Point(109, 134);
            this.lblFilhosqt.Name = "lblFilhosqt";
            this.lblFilhosqt.Size = new System.Drawing.Size(107, 13);
            this.lblFilhosqt.TabIndex = 200;
            this.lblFilhosqt.Text = "Quantidade de Filhos";
            // 
            // nupDFilhos
            // 
            this.nupDFilhos.Location = new System.Drawing.Point(245, 132);
            this.nupDFilhos.Name = "nupDFilhos";
            this.nupDFilhos.Size = new System.Drawing.Size(40, 20);
            this.nupDFilhos.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(306, 129);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(108, 223);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaINSS.TabIndex = 7;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(108, 272);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblAliquotaIRPF.TabIndex = 8;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(245, 220);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.ReadOnly = true;
            this.txtINSS.Size = new System.Drawing.Size(136, 20);
            this.txtINSS.TabIndex = 9;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Location = new System.Drawing.Point(245, 269);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.ReadOnly = true;
            this.txtIRPF.Size = new System.Drawing.Size(136, 20);
            this.txtIRPF.TabIndex = 10;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(245, 362);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(136, 20);
            this.txtSalarioLiquido.TabIndex = 14;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(245, 313);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.ReadOnly = true;
            this.txtSalarioFamilia.Size = new System.Drawing.Size(136, 20);
            this.txtSalarioFamilia.TabIndex = 13;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(108, 365);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(108, 316);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 11;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(594, 269);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.ReadOnly = true;
            this.txtDescontoIRPF.Size = new System.Drawing.Size(136, 20);
            this.txtDescontoIRPF.TabIndex = 18;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(594, 220);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.ReadOnly = true;
            this.txtDescontoINSS.Size = new System.Drawing.Size(136, 20);
            this.txtDescontoINSS.TabIndex = 17;
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(457, 272);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 16;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(457, 223);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 15;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // mboNomeFuncionario
            // 
            this.mboNomeFuncionario.Location = new System.Drawing.Point(245, 49);
            this.mboNomeFuncionario.Name = "mboNomeFuncionario";
            this.mboNomeFuncionario.Size = new System.Drawing.Size(324, 20);
            this.mboNomeFuncionario.TabIndex = 0;
            // 
            // mboSalarioBruto
            // 
            this.mboSalarioBruto.Location = new System.Drawing.Point(245, 88);
            this.mboSalarioBruto.Mask = "9,999.99";
            this.mboSalarioBruto.Name = "mboSalarioBruto";
            this.mboSalarioBruto.Size = new System.Drawing.Size(324, 20);
            this.mboSalarioBruto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mboSalarioBruto);
            this.Controls.Add(this.mboNomeFuncionario);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.nupDFilhos);
            this.Controls.Add(this.lblFilhosqt);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupDFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhosqt;
        private System.Windows.Forms.NumericUpDown nupDFilhos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.MaskedTextBox mboNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mboSalarioBruto;
    }
}

