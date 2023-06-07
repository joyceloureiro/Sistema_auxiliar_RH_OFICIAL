namespace iRh.Windows.simuladores
{
    partial class frmBeneficioPericulosidade
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
            this.panelResultadoPericulosidade = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoPericulosidade = new System.Windows.Forms.Label();
            this.btnCalcularPericulosidade = new System.Windows.Forms.Button();
            this.lblSalarioPericulosidade = new System.Windows.Forms.Label();
            this.txtSalarioPericulosidade = new System.Windows.Forms.TextBox();
            this.panelResultadoPericulosidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultadoPericulosidade
            // 
            this.panelResultadoPericulosidade.AutoSize = true;
            this.panelResultadoPericulosidade.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoPericulosidade.Controls.Add(this.lblMostrarResultadoPericulosidade);
            this.panelResultadoPericulosidade.Location = new System.Drawing.Point(511, 180);
            this.panelResultadoPericulosidade.Name = "panelResultadoPericulosidade";
            this.panelResultadoPericulosidade.Size = new System.Drawing.Size(172, 83);
            this.panelResultadoPericulosidade.TabIndex = 10;
            this.panelResultadoPericulosidade.TabStop = true;
            this.panelResultadoPericulosidade.Visible = false;
            // 
            // lblMostrarResultadoPericulosidade
            // 
            this.lblMostrarResultadoPericulosidade.AutoSize = true;
            this.lblMostrarResultadoPericulosidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoPericulosidade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoPericulosidade.Location = new System.Drawing.Point(38, 12);
            this.lblMostrarResultadoPericulosidade.Name = "lblMostrarResultadoPericulosidade";
            this.lblMostrarResultadoPericulosidade.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoPericulosidade.TabIndex = 6;
            this.lblMostrarResultadoPericulosidade.Text = "RESULTADO:";
            // 
            // btnCalcularPericulosidade
            // 
            this.btnCalcularPericulosidade.Location = new System.Drawing.Point(43, 215);
            this.btnCalcularPericulosidade.Name = "btnCalcularPericulosidade";
            this.btnCalcularPericulosidade.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularPericulosidade.TabIndex = 9;
            this.btnCalcularPericulosidade.Text = "CALCULAR";
            this.btnCalcularPericulosidade.UseVisualStyleBackColor = true;
            this.btnCalcularPericulosidade.Click += new System.EventHandler(this.btnCalcularPericulosidade_Click);
            // 
            // lblSalarioPericulosidade
            // 
            this.lblSalarioPericulosidade.AutoSize = true;
            this.lblSalarioPericulosidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalarioPericulosidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioPericulosidade.Location = new System.Drawing.Point(29, 47);
            this.lblSalarioPericulosidade.Name = "lblSalarioPericulosidade";
            this.lblSalarioPericulosidade.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioPericulosidade.TabIndex = 8;
            this.lblSalarioPericulosidade.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioPericulosidade
            // 
            this.txtSalarioPericulosidade.Location = new System.Drawing.Point(33, 113);
            this.txtSalarioPericulosidade.Name = "txtSalarioPericulosidade";
            this.txtSalarioPericulosidade.Size = new System.Drawing.Size(266, 20);
            this.txtSalarioPericulosidade.TabIndex = 7;
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.Capa_dos_artigos_1_1024x5761;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoPericulosidade);
            this.Controls.Add(this.btnCalcularPericulosidade);
            this.Controls.Add(this.lblSalarioPericulosidade);
            this.Controls.Add(this.txtSalarioPericulosidade);
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "frmBeneficioPericulosidade";
            this.panelResultadoPericulosidade.ResumeLayout(false);
            this.panelResultadoPericulosidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultadoPericulosidade;
        private System.Windows.Forms.Label lblMostrarResultadoPericulosidade;
        private System.Windows.Forms.Button btnCalcularPericulosidade;
        private System.Windows.Forms.Label lblSalarioPericulosidade;
        private System.Windows.Forms.TextBox txtSalarioPericulosidade;
    }
}