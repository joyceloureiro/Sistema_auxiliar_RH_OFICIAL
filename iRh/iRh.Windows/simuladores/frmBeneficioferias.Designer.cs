namespace iRh.Windows.simuladores
{
    partial class frmBeneficioferias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioferias));
            this.panelResultadoBonificacaoFerias = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoFgts = new System.Windows.Forms.Label();
            this.btnCalcularBonificacaoFerias = new System.Windows.Forms.Button();
            this.lblSalarioBonificacaoFerias = new System.Windows.Forms.Label();
            this.txtSalarioBonificacaoFerias = new System.Windows.Forms.TextBox();
            this.panelResultadoBonificacaoFerias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultadoBonificacaoFerias
            // 
            this.panelResultadoBonificacaoFerias.AutoSize = true;
            this.panelResultadoBonificacaoFerias.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoBonificacaoFerias.Controls.Add(this.lblMostrarResultadoFgts);
            this.panelResultadoBonificacaoFerias.Location = new System.Drawing.Point(46, 188);
            this.panelResultadoBonificacaoFerias.Name = "panelResultadoBonificacaoFerias";
            this.panelResultadoBonificacaoFerias.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoBonificacaoFerias.TabIndex = 10;
            this.panelResultadoBonificacaoFerias.TabStop = true;
            this.panelResultadoBonificacaoFerias.Visible = false;
            // 
            // lblMostrarResultadoFgts
            // 
            this.lblMostrarResultadoFgts.AutoSize = true;
            this.lblMostrarResultadoFgts.BackColor = System.Drawing.Color.White;
            this.lblMostrarResultadoFgts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoFgts.Location = new System.Drawing.Point(3, 15);
            this.lblMostrarResultadoFgts.Name = "lblMostrarResultadoFgts";
            this.lblMostrarResultadoFgts.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoFgts.TabIndex = 6;
            this.lblMostrarResultadoFgts.Text = "RESULTADO:";
            // 
            // btnCalcularBonificacaoFerias
            // 
            this.btnCalcularBonificacaoFerias.Location = new System.Drawing.Point(46, 141);
            this.btnCalcularBonificacaoFerias.Name = "btnCalcularBonificacaoFerias";
            this.btnCalcularBonificacaoFerias.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularBonificacaoFerias.TabIndex = 9;
            this.btnCalcularBonificacaoFerias.Text = "CALCULAR";
            this.btnCalcularBonificacaoFerias.UseVisualStyleBackColor = true;
            this.btnCalcularBonificacaoFerias.Click += new System.EventHandler(this.btnCalcularBonificacaoFerias_Click);
            // 
            // lblSalarioBonificacaoFerias
            // 
            this.lblSalarioBonificacaoFerias.AutoSize = true;
            this.lblSalarioBonificacaoFerias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBonificacaoFerias.Location = new System.Drawing.Point(42, 45);
            this.lblSalarioBonificacaoFerias.Name = "lblSalarioBonificacaoFerias";
            this.lblSalarioBonificacaoFerias.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioBonificacaoFerias.TabIndex = 8;
            this.lblSalarioBonificacaoFerias.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioBonificacaoFerias
            // 
            this.txtSalarioBonificacaoFerias.Location = new System.Drawing.Point(46, 93);
            this.txtSalarioBonificacaoFerias.Name = "txtSalarioBonificacaoFerias";
            this.txtSalarioBonificacaoFerias.Size = new System.Drawing.Size(266, 20);
            this.txtSalarioBonificacaoFerias.TabIndex = 7;
            // 
            // frmBeneficioferias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 347);
            this.Controls.Add(this.panelResultadoBonificacaoFerias);
            this.Controls.Add(this.btnCalcularBonificacaoFerias);
            this.Controls.Add(this.lblSalarioBonificacaoFerias);
            this.Controls.Add(this.txtSalarioBonificacaoFerias);
            this.Name = "frmBeneficioferias";
            this.Text = "frmBeneficioferias";
            this.panelResultadoBonificacaoFerias.ResumeLayout(false);
            this.panelResultadoBonificacaoFerias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultadoBonificacaoFerias;
        private System.Windows.Forms.Label lblMostrarResultadoFgts;
        private System.Windows.Forms.Button btnCalcularBonificacaoFerias;
        private System.Windows.Forms.Label lblSalarioBonificacaoFerias;
        private System.Windows.Forms.TextBox txtSalarioBonificacaoFerias;
    }
}