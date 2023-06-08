namespace iRh.Windows.simuladores
{
    partial class frmBeneficioPi
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
            this.lblSalarioMensalPis = new System.Windows.Forms.Label();
            this.txtSalarioMensalPis = new System.Windows.Forms.TextBox();
            this.lblMesesTrabalhadosAnoBasePis = new System.Windows.Forms.Label();
            this.txtMesesTrabalhadosAnoBasePis = new System.Windows.Forms.TextBox();
            this.panelResultadoPis = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoPis = new System.Windows.Forms.Label();
            this.btnCalcularPis = new System.Windows.Forms.Button();
            this.lblAnosInscritoPis = new System.Windows.Forms.Label();
            this.txtAnosInscritoPis = new System.Windows.Forms.TextBox();
            this.panelResultadoPis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMensalPis
            // 
            this.lblSalarioMensalPis.AutoSize = true;
            this.lblSalarioMensalPis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalarioMensalPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensalPis.Location = new System.Drawing.Point(43, 227);
            this.lblSalarioMensalPis.Name = "lblSalarioMensalPis";
            this.lblSalarioMensalPis.Size = new System.Drawing.Size(368, 21);
            this.lblSalarioMensalPis.TabIndex = 26;
            this.lblSalarioMensalPis.Text = "VALOR DO SALARIO RECEBIDO MENSALMENTE:";
            // 
            // txtSalarioMensalPis
            // 
            this.txtSalarioMensalPis.Location = new System.Drawing.Point(47, 270);
            this.txtSalarioMensalPis.Name = "txtSalarioMensalPis";
            this.txtSalarioMensalPis.Size = new System.Drawing.Size(287, 20);
            this.txtSalarioMensalPis.TabIndex = 25;
            // 
            // lblMesesTrabalhadosAnoBasePis
            // 
            this.lblMesesTrabalhadosAnoBasePis.AutoSize = true;
            this.lblMesesTrabalhadosAnoBasePis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMesesTrabalhadosAnoBasePis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhadosAnoBasePis.Location = new System.Drawing.Point(43, 125);
            this.lblMesesTrabalhadosAnoBasePis.Name = "lblMesesTrabalhadosAnoBasePis";
            this.lblMesesTrabalhadosAnoBasePis.Size = new System.Drawing.Size(540, 21);
            this.lblMesesTrabalhadosAnoBasePis.TabIndex = 24;
            this.lblMesesTrabalhadosAnoBasePis.Text = "QUANTIDADE DE MESES TRABALHADOS NO ANO BASE (até 12 meses)";
            // 
            // txtMesesTrabalhadosAnoBasePis
            // 
            this.txtMesesTrabalhadosAnoBasePis.Location = new System.Drawing.Point(47, 167);
            this.txtMesesTrabalhadosAnoBasePis.Name = "txtMesesTrabalhadosAnoBasePis";
            this.txtMesesTrabalhadosAnoBasePis.Size = new System.Drawing.Size(248, 20);
            this.txtMesesTrabalhadosAnoBasePis.TabIndex = 23;
            // 
            // panelResultadoPis
            // 
            this.panelResultadoPis.AutoSize = true;
            this.panelResultadoPis.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoPis.Controls.Add(this.lblMostrarResultadoPis);
            this.panelResultadoPis.Location = new System.Drawing.Point(514, 227);
            this.panelResultadoPis.Name = "panelResultadoPis";
            this.panelResultadoPis.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoPis.TabIndex = 22;
            this.panelResultadoPis.TabStop = true;
            this.panelResultadoPis.Visible = false;
            // 
            // lblMostrarResultadoPis
            // 
            this.lblMostrarResultadoPis.AutoSize = true;
            this.lblMostrarResultadoPis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoPis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoPis.Location = new System.Drawing.Point(3, 0);
            this.lblMostrarResultadoPis.Name = "lblMostrarResultadoPis";
            this.lblMostrarResultadoPis.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoPis.TabIndex = 6;
            this.lblMostrarResultadoPis.Text = "RESULTADO:";
            // 
            // btnCalcularPis
            // 
            this.btnCalcularPis.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularPis.Location = new System.Drawing.Point(47, 319);
            this.btnCalcularPis.Name = "btnCalcularPis";
            this.btnCalcularPis.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularPis.TabIndex = 21;
            this.btnCalcularPis.Text = "CALCULAR";
            this.btnCalcularPis.UseVisualStyleBackColor = true;
            this.btnCalcularPis.Click += new System.EventHandler(this.btnCalcularPis_Click);
            // 
            // lblAnosInscritoPis
            // 
            this.lblAnosInscritoPis.AutoSize = true;
            this.lblAnosInscritoPis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAnosInscritoPis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnosInscritoPis.Location = new System.Drawing.Point(43, 27);
            this.lblAnosInscritoPis.Name = "lblAnosInscritoPis";
            this.lblAnosInscritoPis.Size = new System.Drawing.Size(386, 21);
            this.lblAnosInscritoPis.TabIndex = 20;
            this.lblAnosInscritoPis.Text = "QUANTIDADE DE ANOS INSCRITO NO PIS/PASEP :";
            // 
            // txtAnosInscritoPis
            // 
            this.txtAnosInscritoPis.Location = new System.Drawing.Point(47, 63);
            this.txtAnosInscritoPis.Name = "txtAnosInscritoPis";
            this.txtAnosInscritoPis.Size = new System.Drawing.Size(224, 20);
            this.txtAnosInscritoPis.TabIndex = 19;
            // 
            // frmBeneficioPi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.pagamento_pis1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalarioMensalPis);
            this.Controls.Add(this.txtSalarioMensalPis);
            this.Controls.Add(this.lblMesesTrabalhadosAnoBasePis);
            this.Controls.Add(this.txtMesesTrabalhadosAnoBasePis);
            this.Controls.Add(this.panelResultadoPis);
            this.Controls.Add(this.btnCalcularPis);
            this.Controls.Add(this.lblAnosInscritoPis);
            this.Controls.Add(this.txtAnosInscritoPis);
            this.Name = "frmBeneficioPi";
            this.Text = "frmBeneficioPis";
            this.panelResultadoPis.ResumeLayout(false);
            this.panelResultadoPis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioMensalPis;
        private System.Windows.Forms.TextBox txtSalarioMensalPis;
        private System.Windows.Forms.Label lblMesesTrabalhadosAnoBasePis;
        private System.Windows.Forms.TextBox txtMesesTrabalhadosAnoBasePis;
        private System.Windows.Forms.Panel panelResultadoPis;
        private System.Windows.Forms.Label lblMostrarResultadoPis;
        private System.Windows.Forms.Button btnCalcularPis;
        private System.Windows.Forms.Label lblAnosInscritoPis;
        private System.Windows.Forms.TextBox txtAnosInscritoPis;
    }
}