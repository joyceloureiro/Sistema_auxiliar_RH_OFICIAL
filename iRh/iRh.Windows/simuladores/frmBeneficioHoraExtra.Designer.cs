namespace iRh.Windows.simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.lblHorasExtrasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasExtrasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasMes = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadasMes = new System.Windows.Forms.TextBox();
            this.panelResultadoHoraExtra = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoHoraExtra = new System.Windows.Forms.Label();
            this.btnCalcularHoraExtra = new System.Windows.Forms.Button();
            this.lblSalarioHoraExtra = new System.Windows.Forms.Label();
            this.txtSalarioHoraExtra = new System.Windows.Forms.TextBox();
            this.panelResultadoHoraExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHorasExtrasTrabalhadas
            // 
            this.lblHorasExtrasTrabalhadas.AutoSize = true;
            this.lblHorasExtrasTrabalhadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHorasExtrasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtrasTrabalhadas.Location = new System.Drawing.Point(28, 211);
            this.lblHorasExtrasTrabalhadas.Name = "lblHorasExtrasTrabalhadas";
            this.lblHorasExtrasTrabalhadas.Size = new System.Drawing.Size(314, 21);
            this.lblHorasExtrasTrabalhadas.TabIndex = 26;
            this.lblHorasExtrasTrabalhadas.Text = "HORAS EXTRAS TRABALHADAS NO MES:";
            // 
            // txtHorasExtrasTrabalhadas
            // 
            this.txtHorasExtrasTrabalhadas.Location = new System.Drawing.Point(32, 171);
            this.txtHorasExtrasTrabalhadas.Name = "txtHorasExtrasTrabalhadas";
            this.txtHorasExtrasTrabalhadas.Size = new System.Drawing.Size(287, 20);
            this.txtHorasExtrasTrabalhadas.TabIndex = 25;
            // 
            // lblHorasTrabalhadasMes
            // 
            this.lblHorasTrabalhadasMes.AutoSize = true;
            this.lblHorasTrabalhadasMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHorasTrabalhadasMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasMes.Location = new System.Drawing.Point(28, 130);
            this.lblHorasTrabalhadasMes.Name = "lblHorasTrabalhadasMes";
            this.lblHorasTrabalhadasMes.Size = new System.Drawing.Size(223, 21);
            this.lblHorasTrabalhadasMes.TabIndex = 24;
            this.lblHorasTrabalhadasMes.Text = "HORAS TRABALHADAS MES:";
            // 
            // txtHorasTrabalhadasMes
            // 
            this.txtHorasTrabalhadasMes.Location = new System.Drawing.Point(32, 248);
            this.txtHorasTrabalhadasMes.Name = "txtHorasTrabalhadasMes";
            this.txtHorasTrabalhadasMes.Size = new System.Drawing.Size(248, 20);
            this.txtHorasTrabalhadasMes.TabIndex = 23;
            // 
            // panelResultadoHoraExtra
            // 
            this.panelResultadoHoraExtra.AutoSize = true;
            this.panelResultadoHoraExtra.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoHoraExtra.Controls.Add(this.lblMostrarResultadoHoraExtra);
            this.panelResultadoHoraExtra.Location = new System.Drawing.Point(589, 185);
            this.panelResultadoHoraExtra.Name = "panelResultadoHoraExtra";
            this.panelResultadoHoraExtra.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoHoraExtra.TabIndex = 22;
            this.panelResultadoHoraExtra.TabStop = true;
            this.panelResultadoHoraExtra.Visible = false;
            // 
            // lblMostrarResultadoHoraExtra
            // 
            this.lblMostrarResultadoHoraExtra.AutoSize = true;
            this.lblMostrarResultadoHoraExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoHoraExtra.Location = new System.Drawing.Point(3, 0);
            this.lblMostrarResultadoHoraExtra.Name = "lblMostrarResultadoHoraExtra";
            this.lblMostrarResultadoHoraExtra.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoHoraExtra.TabIndex = 6;
            this.lblMostrarResultadoHoraExtra.Text = "RESULTADO:";
            // 
            // btnCalcularHoraExtra
            // 
            this.btnCalcularHoraExtra.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularHoraExtra.Location = new System.Drawing.Point(32, 317);
            this.btnCalcularHoraExtra.Name = "btnCalcularHoraExtra";
            this.btnCalcularHoraExtra.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularHoraExtra.TabIndex = 21;
            this.btnCalcularHoraExtra.Text = "CALCULAR";
            this.btnCalcularHoraExtra.UseVisualStyleBackColor = true;
            this.btnCalcularHoraExtra.Click += new System.EventHandler(this.btnCalcularHoraExtra_Click);
            // 
            // lblSalarioHoraExtra
            // 
            this.lblSalarioHoraExtra.AutoSize = true;
            this.lblSalarioHoraExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalarioHoraExtra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHoraExtra.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioHoraExtra.Location = new System.Drawing.Point(28, 39);
            this.lblSalarioHoraExtra.Name = "lblSalarioHoraExtra";
            this.lblSalarioHoraExtra.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioHoraExtra.TabIndex = 20;
            this.lblSalarioHoraExtra.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioHoraExtra
            // 
            this.txtSalarioHoraExtra.Location = new System.Drawing.Point(32, 87);
            this.txtSalarioHoraExtra.Name = "txtSalarioHoraExtra";
            this.txtSalarioHoraExtra.Size = new System.Drawing.Size(224, 20);
            this.txtSalarioHoraExtra.TabIndex = 19;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.images__2_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHorasExtrasTrabalhadas);
            this.Controls.Add(this.txtHorasExtrasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadasMes);
            this.Controls.Add(this.txtHorasTrabalhadasMes);
            this.Controls.Add(this.panelResultadoHoraExtra);
            this.Controls.Add(this.btnCalcularHoraExtra);
            this.Controls.Add(this.lblSalarioHoraExtra);
            this.Controls.Add(this.txtSalarioHoraExtra);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "frmBeneficioHoraExtra";
            this.panelResultadoHoraExtra.ResumeLayout(false);
            this.panelResultadoHoraExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorasExtrasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasExtrasTrabalhadas;
        private System.Windows.Forms.Label lblHorasTrabalhadasMes;
        private System.Windows.Forms.TextBox txtHorasTrabalhadasMes;
        private System.Windows.Forms.Panel panelResultadoHoraExtra;
        private System.Windows.Forms.Label lblMostrarResultadoHoraExtra;
        private System.Windows.Forms.Button btnCalcularHoraExtra;
        private System.Windows.Forms.Label lblSalarioHoraExtra;
        private System.Windows.Forms.TextBox txtSalarioHoraExtra;
    }
}