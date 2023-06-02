namespace iRh.Windows.simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.lblSeguroDesempregoSolicitado = new System.Windows.Forms.Label();
            this.txtSeguroDesempregoSolicitado = new System.Windows.Forms.TextBox();
            this.panelResultadoSD = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoSD = new System.Windows.Forms.Label();
            this.btnCalcularSD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDemisãoPorJustaCausaSouN = new System.Windows.Forms.Label();
            this.rdDemisãoPorJustaCausaSim = new System.Windows.Forms.RadioButton();
            this.rdDemisãoPorJustaCausaNao = new System.Windows.Forms.RadioButton();
            this.panalExibeDadosSeguroDesemprego = new System.Windows.Forms.Panel();
            this.panelResultadoSD.SuspendLayout();
            this.panalExibeDadosSeguroDesemprego.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(3, 94);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(389, 21);
            this.lblMesesTrabalhados.TabIndex = 24;
            this.lblMesesTrabalhados.Text = "DIGITE A QUANTIDADE DE MESES TRABALHADOS:";
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(7, 144);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(261, 20);
            this.txtMesesTrabalhados.TabIndex = 23;
            // 
            // lblSeguroDesempregoSolicitado
            // 
            this.lblSeguroDesempregoSolicitado.AutoSize = true;
            this.lblSeguroDesempregoSolicitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSeguroDesempregoSolicitado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroDesempregoSolicitado.Location = new System.Drawing.Point(11, 11);
            this.lblSeguroDesempregoSolicitado.Name = "lblSeguroDesempregoSolicitado";
            this.lblSeguroDesempregoSolicitado.Size = new System.Drawing.Size(482, 21);
            this.lblSeguroDesempregoSolicitado.TabIndex = 22;
            this.lblSeguroDesempregoSolicitado.Text = "QUANTAS VEZES O SEGURO DESEMPREGO JÀ FOI SOLICITADO:";
            // 
            // txtSeguroDesempregoSolicitado
            // 
            this.txtSeguroDesempregoSolicitado.Location = new System.Drawing.Point(7, 45);
            this.txtSeguroDesempregoSolicitado.Name = "txtSeguroDesempregoSolicitado";
            this.txtSeguroDesempregoSolicitado.Size = new System.Drawing.Size(248, 20);
            this.txtSeguroDesempregoSolicitado.TabIndex = 21;
            // 
            // panelResultadoSD
            // 
            this.panelResultadoSD.AutoSize = true;
            this.panelResultadoSD.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoSD.Controls.Add(this.lblMostrarResultadoSD);
            this.panelResultadoSD.Location = new System.Drawing.Point(604, 172);
            this.panelResultadoSD.Name = "panelResultadoSD";
            this.panelResultadoSD.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoSD.TabIndex = 20;
            this.panelResultadoSD.TabStop = true;
            this.panelResultadoSD.Visible = false;
            // 
            // lblMostrarResultadoSD
            // 
            this.lblMostrarResultadoSD.AutoSize = true;
            this.lblMostrarResultadoSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoSD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoSD.Location = new System.Drawing.Point(3, 0);
            this.lblMostrarResultadoSD.Name = "lblMostrarResultadoSD";
            this.lblMostrarResultadoSD.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoSD.TabIndex = 6;
            this.lblMostrarResultadoSD.Text = "RESULTADO:";
            // 
            // btnCalcularSD
            // 
            this.btnCalcularSD.BackColor = System.Drawing.Color.Silver;
            this.btnCalcularSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSD.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularSD.Location = new System.Drawing.Point(3, 170);
            this.btnCalcularSD.Name = "btnCalcularSD";
            this.btnCalcularSD.Size = new System.Drawing.Size(227, 26);
            this.btnCalcularSD.TabIndex = 19;
            this.btnCalcularSD.Text = "CALCULAR SEGURO DESEMPREGO";
            this.btnCalcularSD.UseVisualStyleBackColor = false;
            this.btnCalcularSD.Click += new System.EventHandler(this.btnCalcularSD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // lblDemisãoPorJustaCausaSouN
            // 
            this.lblDemisãoPorJustaCausaSouN.AutoSize = true;
            this.lblDemisãoPorJustaCausaSouN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDemisãoPorJustaCausaSouN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemisãoPorJustaCausaSouN.Location = new System.Drawing.Point(34, 35);
            this.lblDemisãoPorJustaCausaSouN.Name = "lblDemisãoPorJustaCausaSouN";
            this.lblDemisãoPorJustaCausaSouN.Size = new System.Drawing.Size(319, 21);
            this.lblDemisãoPorJustaCausaSouN.TabIndex = 29;
            this.lblDemisãoPorJustaCausaSouN.Text = "VOCÊ FOI DEMITIDO POR JUSTA CAUSA ?";
            // 
            // rdDemisãoPorJustaCausaSim
            // 
            this.rdDemisãoPorJustaCausaSim.AutoSize = true;
            this.rdDemisãoPorJustaCausaSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdDemisãoPorJustaCausaSim.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDemisãoPorJustaCausaSim.Location = new System.Drawing.Point(30, 73);
            this.rdDemisãoPorJustaCausaSim.Name = "rdDemisãoPorJustaCausaSim";
            this.rdDemisãoPorJustaCausaSim.Size = new System.Drawing.Size(54, 24);
            this.rdDemisãoPorJustaCausaSim.TabIndex = 28;
            this.rdDemisãoPorJustaCausaSim.TabStop = true;
            this.rdDemisãoPorJustaCausaSim.Text = "SIM";
            this.rdDemisãoPorJustaCausaSim.UseVisualStyleBackColor = false;
            this.rdDemisãoPorJustaCausaSim.CheckedChanged += new System.EventHandler(this.rdDemisãoPorJustaCausaSim_CheckedChanged);
            // 
            // rdDemisãoPorJustaCausaNao
            // 
            this.rdDemisãoPorJustaCausaNao.AutoSize = true;
            this.rdDemisãoPorJustaCausaNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdDemisãoPorJustaCausaNao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDemisãoPorJustaCausaNao.Location = new System.Drawing.Point(130, 73);
            this.rdDemisãoPorJustaCausaNao.Name = "rdDemisãoPorJustaCausaNao";
            this.rdDemisãoPorJustaCausaNao.Size = new System.Drawing.Size(66, 24);
            this.rdDemisãoPorJustaCausaNao.TabIndex = 27;
            this.rdDemisãoPorJustaCausaNao.TabStop = true;
            this.rdDemisãoPorJustaCausaNao.Text = "NÂO!";
            this.rdDemisãoPorJustaCausaNao.UseVisualStyleBackColor = false;
            this.rdDemisãoPorJustaCausaNao.CheckedChanged += new System.EventHandler(this.rdDemisãoPorJustaCausaNao_CheckedChanged);
            // 
            // panalExibeDadosSeguroDesemprego
            // 
            this.panalExibeDadosSeguroDesemprego.BackColor = System.Drawing.Color.Transparent;
            this.panalExibeDadosSeguroDesemprego.Controls.Add(this.lblMesesTrabalhados);
            this.panalExibeDadosSeguroDesemprego.Controls.Add(this.lblSeguroDesempregoSolicitado);
            this.panalExibeDadosSeguroDesemprego.Controls.Add(this.txtSeguroDesempregoSolicitado);
            this.panalExibeDadosSeguroDesemprego.Controls.Add(this.txtMesesTrabalhados);
            this.panalExibeDadosSeguroDesemprego.Controls.Add(this.btnCalcularSD);
            this.panalExibeDadosSeguroDesemprego.Location = new System.Drawing.Point(23, 123);
            this.panalExibeDadosSeguroDesemprego.Name = "panalExibeDadosSeguroDesemprego";
            this.panalExibeDadosSeguroDesemprego.Size = new System.Drawing.Size(496, 208);
            this.panalExibeDadosSeguroDesemprego.TabIndex = 31;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panalExibeDadosSeguroDesemprego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDemisãoPorJustaCausaSouN);
            this.Controls.Add(this.rdDemisãoPorJustaCausaSim);
            this.Controls.Add(this.rdDemisãoPorJustaCausaNao);
            this.Controls.Add(this.panelResultadoSD);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "Beneficio de SeguroDesemprego";
            this.panelResultadoSD.ResumeLayout(false);
            this.panelResultadoSD.PerformLayout();
            this.panalExibeDadosSeguroDesemprego.ResumeLayout(false);
            this.panalExibeDadosSeguroDesemprego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesesTrabalhados;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Label lblSeguroDesempregoSolicitado;
        private System.Windows.Forms.TextBox txtSeguroDesempregoSolicitado;
        private System.Windows.Forms.Panel panelResultadoSD;
        private System.Windows.Forms.Label lblMostrarResultadoSD;
        private System.Windows.Forms.Button btnCalcularSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDemisãoPorJustaCausaSouN;
        private System.Windows.Forms.RadioButton rdDemisãoPorJustaCausaSim;
        private System.Windows.Forms.RadioButton rdDemisãoPorJustaCausaNao;
        private System.Windows.Forms.Panel panalExibeDadosSeguroDesemprego;
    }
}