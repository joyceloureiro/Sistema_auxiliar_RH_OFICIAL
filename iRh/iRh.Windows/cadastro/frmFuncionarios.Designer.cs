namespace iRh.Windows.cadastro
{
    partial class frmFuncionarios
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.rdTemFilhosNao = new System.Windows.Forms.RadioButton();
            this.rdTemFilhosSim = new System.Windows.Forms.RadioButton();
            this.lblTenFilhos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.lblIDataNascimento = new System.Windows.Forms.Label();
            this.lblNomeFilho = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panalExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panalExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "feminino",
            "masculino",
            "binario",
            "poliflagtal-genero",
            "pansexual",
            "assexual",
            "trans feminino",
            "trans masculino",
            "ceterogeno",
            "não decidi"});
            this.cmbGenero.Location = new System.Drawing.Point(47, 44);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(209, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // rdTemFilhosNao
            // 
            this.rdTemFilhosNao.AutoSize = true;
            this.rdTemFilhosNao.Location = new System.Drawing.Point(125, 142);
            this.rdTemFilhosNao.Name = "rdTemFilhosNao";
            this.rdTemFilhosNao.Size = new System.Drawing.Size(51, 17);
            this.rdTemFilhosNao.TabIndex = 1;
            this.rdTemFilhosNao.TabStop = true;
            this.rdTemFilhosNao.Text = "NÂO!";
            this.rdTemFilhosNao.UseVisualStyleBackColor = true;
            this.rdTemFilhosNao.CheckedChanged += new System.EventHandler(this.rdTemFilhosNao_CheckedChanged);
            // 
            // rdTemFilhosSim
            // 
            this.rdTemFilhosSim.AutoSize = true;
            this.rdTemFilhosSim.Location = new System.Drawing.Point(47, 142);
            this.rdTemFilhosSim.Name = "rdTemFilhosSim";
            this.rdTemFilhosSim.Size = new System.Drawing.Size(44, 17);
            this.rdTemFilhosSim.TabIndex = 2;
            this.rdTemFilhosSim.TabStop = true;
            this.rdTemFilhosSim.Text = "SIM";
            this.rdTemFilhosSim.UseVisualStyleBackColor = true;
            this.rdTemFilhosSim.CheckedChanged += new System.EventHandler(this.rdTemFilhosSim_CheckedChanged);
            // 
            // lblTenFilhos
            // 
            this.lblTenFilhos.AutoSize = true;
            this.lblTenFilhos.Location = new System.Drawing.Point(44, 107);
            this.lblTenFilhos.Name = "lblTenFilhos";
            this.lblTenFilhos.Size = new System.Drawing.Size(109, 13);
            this.lblTenFilhos.TabIndex = 3;
            this.lblTenFilhos.Text = "VOCE TEM FILHOS?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(3, 44);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(147, 20);
            this.txtFilhoNome.TabIndex = 5;
            // 
            // lblIDataNascimento
            // 
            this.lblIDataNascimento.AutoSize = true;
            this.lblIDataNascimento.Location = new System.Drawing.Point(183, 17);
            this.lblIDataNascimento.Name = "lblIDataNascimento";
            this.lblIDataNascimento.Size = new System.Drawing.Size(131, 13);
            this.lblIDataNascimento.TabIndex = 7;
            this.lblIDataNascimento.Text = "DATA DE NASCIMENTO:";
            // 
            // lblNomeFilho
            // 
            this.lblNomeFilho.AutoSize = true;
            this.lblNomeFilho.Location = new System.Drawing.Point(3, 17);
            this.lblNomeFilho.Name = "lblNomeFilho";
            this.lblNomeFilho.Size = new System.Drawing.Size(120, 13);
            this.lblNomeFilho.TabIndex = 8;
            this.lblNomeFilho.Text = "NOME DO SEU FILHO:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(329, 47);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(33, 13);
            this.lblIdade.TabIndex = 9;
            this.lblIdade.Text = "idade";
            // 
            // panalExibeDadosFilhos
            // 
            this.panalExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panalExibeDadosFilhos.Controls.Add(this.lblNomeFilho);
            this.panalExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panalExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panalExibeDadosFilhos.Controls.Add(this.lblIDataNascimento);
            this.panalExibeDadosFilhos.Location = new System.Drawing.Point(47, 176);
            this.panalExibeDadosFilhos.Name = "panalExibeDadosFilhos";
            this.panalExibeDadosFilhos.Size = new System.Drawing.Size(385, 80);
            this.panalExibeDadosFilhos.TabIndex = 10;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(186, 44);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(70, 20);
            this.txtFilhoDataNascimento.TabIndex = 11;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panalExibeDadosFilhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenFilhos);
            this.Controls.Add(this.rdTemFilhosSim);
            this.Controls.Add(this.rdTemFilhosNao);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.panalExibeDadosFilhos.ResumeLayout(false);
            this.panalExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rdTemFilhosNao;
        private System.Windows.Forms.RadioButton rdTemFilhosSim;
        private System.Windows.Forms.Label lblTenFilhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label lblIDataNascimento;
        private System.Windows.Forms.Label lblNomeFilho;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panalExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}