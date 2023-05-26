namespace iRh.Windows.simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.panelResultadoAD = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoAD = new System.Windows.Forms.Label();
            this.btnCalcularAD = new System.Windows.Forms.Button();
            this.lblSalarioAD = new System.Windows.Forms.Label();
            this.txtSalarioAD = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasMes = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadasMes = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnasMes = new System.Windows.Forms.Label();
            this.txtHorasNoturnasMes = new System.Windows.Forms.TextBox();
            this.panelResultadoAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultadoAD
            // 
            this.panelResultadoAD.AutoSize = true;
            this.panelResultadoAD.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoAD.Controls.Add(this.lblMostrarResultadoAD);
            this.panelResultadoAD.Location = new System.Drawing.Point(604, 166);
            this.panelResultadoAD.Name = "panelResultadoAD";
            this.panelResultadoAD.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoAD.TabIndex = 14;
            this.panelResultadoAD.TabStop = true;
            this.panelResultadoAD.Visible = false;
            // 
            // lblMostrarResultadoAD
            // 
            this.lblMostrarResultadoAD.AutoSize = true;
            this.lblMostrarResultadoAD.BackColor = System.Drawing.Color.Yellow;
            this.lblMostrarResultadoAD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoAD.Location = new System.Drawing.Point(3, 0);
            this.lblMostrarResultadoAD.Name = "lblMostrarResultadoAD";
            this.lblMostrarResultadoAD.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoAD.TabIndex = 6;
            this.lblMostrarResultadoAD.Text = "RESULTADO:";
            // 
            // btnCalcularAD
            // 
            this.btnCalcularAD.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularAD.Location = new System.Drawing.Point(47, 298);
            this.btnCalcularAD.Name = "btnCalcularAD";
            this.btnCalcularAD.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularAD.TabIndex = 13;
            this.btnCalcularAD.Text = "CALCULAR";
            this.btnCalcularAD.UseVisualStyleBackColor = true;
            this.btnCalcularAD.Click += new System.EventHandler(this.btnCalcularAD_Click);
            // 
            // lblSalarioAD
            // 
            this.lblSalarioAD.AutoSize = true;
            this.lblSalarioAD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioAD.Location = new System.Drawing.Point(43, 20);
            this.lblSalarioAD.Name = "lblSalarioAD";
            this.lblSalarioAD.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioAD.TabIndex = 12;
            this.lblSalarioAD.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioAD
            // 
            this.txtSalarioAD.Location = new System.Drawing.Point(47, 68);
            this.txtSalarioAD.Name = "txtSalarioAD";
            this.txtSalarioAD.Size = new System.Drawing.Size(224, 20);
            this.txtSalarioAD.TabIndex = 11;
            // 
            // lblHorasTrabalhadasMes
            // 
            this.lblHorasTrabalhadasMes.AutoSize = true;
            this.lblHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasMes.Location = new System.Drawing.Point(43, 117);
            this.lblHorasTrabalhadasMes.Name = "lblHorasTrabalhadasMes";
            this.lblHorasTrabalhadasMes.Size = new System.Drawing.Size(252, 21);
            this.lblHorasTrabalhadasMes.TabIndex = 16;
            this.lblHorasTrabalhadasMes.Text = "HORAS TRABALHADAS NO MES:";
            // 
            // txtHorasTrabalhadasMes
            // 
            this.txtHorasTrabalhadasMes.Location = new System.Drawing.Point(47, 157);
            this.txtHorasTrabalhadasMes.Name = "txtHorasTrabalhadasMes";
            this.txtHorasTrabalhadasMes.Size = new System.Drawing.Size(248, 20);
            this.txtHorasTrabalhadasMes.TabIndex = 15;
            // 
            // lblHorasNoturnasMes
            // 
            this.lblHorasNoturnasMes.AutoSize = true;
            this.lblHorasNoturnasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnasMes.Location = new System.Drawing.Point(43, 202);
            this.lblHorasNoturnasMes.Name = "lblHorasNoturnasMes";
            this.lblHorasNoturnasMes.Size = new System.Drawing.Size(304, 21);
            this.lblHorasNoturnasMes.TabIndex = 18;
            this.lblHorasNoturnasMes.Text = "HORAS NOTURNAS TRABALHDAS MES:";
            // 
            // txtHorasNoturnasMes
            // 
            this.txtHorasNoturnasMes.Location = new System.Drawing.Point(47, 242);
            this.txtHorasNoturnasMes.Name = "txtHorasNoturnasMes";
            this.txtHorasNoturnasMes.Size = new System.Drawing.Size(287, 20);
            this.txtHorasNoturnasMes.TabIndex = 17;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHorasNoturnasMes);
            this.Controls.Add(this.txtHorasNoturnasMes);
            this.Controls.Add(this.lblHorasTrabalhadasMes);
            this.Controls.Add(this.txtHorasTrabalhadasMes);
            this.Controls.Add(this.panelResultadoAD);
            this.Controls.Add(this.btnCalcularAD);
            this.Controls.Add(this.lblSalarioAD);
            this.Controls.Add(this.txtSalarioAD);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.Load += new System.EventHandler(this.frmBeneficioAdicionalNoturno_Load);
            this.panelResultadoAD.ResumeLayout(false);
            this.panelResultadoAD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultadoAD;
        private System.Windows.Forms.Label lblMostrarResultadoAD;
        private System.Windows.Forms.Button btnCalcularAD;
        private System.Windows.Forms.Label lblSalarioAD;
        private System.Windows.Forms.TextBox txtSalarioAD;
        private System.Windows.Forms.Label lblHorasTrabalhadasMes;
        private System.Windows.Forms.TextBox txtHorasTrabalhadasMes;
        private System.Windows.Forms.Label lblHorasNoturnasMes;
        private System.Windows.Forms.TextBox txtHorasNoturnasMes;
    }
}