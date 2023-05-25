namespace iRh.Windows.simuladores
{
    partial class frmBeneficioValeTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioValeTransporte));
            this.lblSalarioVT = new System.Windows.Forms.Label();
            this.btnCalcularVT = new System.Windows.Forms.Button();
            this.panelResultadoVT = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoVT = new System.Windows.Forms.Label();
            this.lblValorPassagemVT = new System.Windows.Forms.Label();
            this.txtSalarioVT = new System.Windows.Forms.TextBox();
            this.txtValorPassagemVT = new System.Windows.Forms.TextBox();
            this.panelResultadoVT.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioVT
            // 
            this.lblSalarioVT.AutoSize = true;
            this.lblSalarioVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalarioVT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioVT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSalarioVT.Location = new System.Drawing.Point(71, 128);
            this.lblSalarioVT.Name = "lblSalarioVT";
            this.lblSalarioVT.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioVT.TabIndex = 1;
            this.lblSalarioVT.Text = "DIGITE SALARIO BASE:";
            // 
            // btnCalcularVT
            // 
            this.btnCalcularVT.Location = new System.Drawing.Point(75, 206);
            this.btnCalcularVT.Name = "btnCalcularVT";
            this.btnCalcularVT.Size = new System.Drawing.Size(102, 23);
            this.btnCalcularVT.TabIndex = 2;
            this.btnCalcularVT.Text = "CALCULAR";
            this.btnCalcularVT.UseVisualStyleBackColor = true;
            this.btnCalcularVT.Click += new System.EventHandler(this.btnCalcularVT_Click);
            // 
            // panelResultadoVT
            // 
            this.panelResultadoVT.AutoSize = true;
            this.panelResultadoVT.BackColor = System.Drawing.Color.Black;
            this.panelResultadoVT.Controls.Add(this.lblMostrarResultadoVT);
            this.panelResultadoVT.Location = new System.Drawing.Point(616, 128);
            this.panelResultadoVT.Name = "panelResultadoVT";
            this.panelResultadoVT.Size = new System.Drawing.Size(137, 111);
            this.panelResultadoVT.TabIndex = 5;
            this.panelResultadoVT.TabStop = true;
            this.panelResultadoVT.Visible = false;
            // 
            // lblMostrarResultadoVT
            // 
            this.lblMostrarResultadoVT.AutoSize = true;
            this.lblMostrarResultadoVT.BackColor = System.Drawing.Color.Black;
            this.lblMostrarResultadoVT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoVT.ForeColor = System.Drawing.Color.Yellow;
            this.lblMostrarResultadoVT.Location = new System.Drawing.Point(3, 9);
            this.lblMostrarResultadoVT.Name = "lblMostrarResultadoVT";
            this.lblMostrarResultadoVT.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoVT.TabIndex = 6;
            this.lblMostrarResultadoVT.Text = "RESULTADO:";
            // 
            // lblValorPassagemVT
            // 
            this.lblValorPassagemVT.AutoSize = true;
            this.lblValorPassagemVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValorPassagemVT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPassagemVT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorPassagemVT.Location = new System.Drawing.Point(71, 42);
            this.lblValorPassagemVT.Name = "lblValorPassagemVT";
            this.lblValorPassagemVT.Size = new System.Drawing.Size(332, 21);
            this.lblValorPassagemVT.TabIndex = 7;
            this.lblValorPassagemVT.Text = "DIGITE O VALOR DA PASAGEM DE ONIBUS:";
            // 
            // txtSalarioVT
            // 
            this.txtSalarioVT.Location = new System.Drawing.Point(75, 166);
            this.txtSalarioVT.Name = "txtSalarioVT";
            this.txtSalarioVT.Size = new System.Drawing.Size(266, 20);
            this.txtSalarioVT.TabIndex = 0;
            // 
            // txtValorPassagemVT
            // 
            this.txtValorPassagemVT.Location = new System.Drawing.Point(75, 78);
            this.txtValorPassagemVT.Name = "txtValorPassagemVT";
            this.txtValorPassagemVT.Size = new System.Drawing.Size(266, 20);
            this.txtValorPassagemVT.TabIndex = 8;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorPassagemVT);
            this.Controls.Add(this.lblValorPassagemVT);
            this.Controls.Add(this.panelResultadoVT);
            this.Controls.Add(this.btnCalcularVT);
            this.Controls.Add(this.lblSalarioVT);
            this.Controls.Add(this.txtSalarioVT);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Beneficio de ValeTransporte";
            this.Load += new System.EventHandler(this.frmBeneficioValeTransporte_Load);
            this.panelResultadoVT.ResumeLayout(false);
            this.panelResultadoVT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalarioVT;
        private System.Windows.Forms.Button btnCalcularVT;
        private System.Windows.Forms.Panel panelResultadoVT;
        private System.Windows.Forms.Label lblMostrarResultadoVT;
        private System.Windows.Forms.Label lblValorPassagemVT;
        private System.Windows.Forms.TextBox txtSalarioVT;
        private System.Windows.Forms.TextBox txtValorPassagemVT;
    }
}