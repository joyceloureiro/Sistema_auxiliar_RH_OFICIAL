namespace iRh.Windows.simuladores
{
    partial class frmDescontoIrrf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoIrrf));
            this.panelResultadoIrrf = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoIrrf = new System.Windows.Forms.Label();
            this.btnCalcularIrrf = new System.Windows.Forms.Button();
            this.lblSalarioIrrf = new System.Windows.Forms.Label();
            this.txtSalarioIrrf = new System.Windows.Forms.TextBox();
            this.panelResultadoIrrf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultadoIrrf
            // 
            this.panelResultadoIrrf.AutoSize = true;
            this.panelResultadoIrrf.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoIrrf.Controls.Add(this.lblMostrarResultadoIrrf);
            this.panelResultadoIrrf.Location = new System.Drawing.Point(600, 195);
            this.panelResultadoIrrf.Name = "panelResultadoIrrf";
            this.panelResultadoIrrf.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoIrrf.TabIndex = 10;
            this.panelResultadoIrrf.TabStop = true;
            this.panelResultadoIrrf.Visible = false;
            // 
            // lblMostrarResultadoIrrf
            // 
            this.lblMostrarResultadoIrrf.AutoSize = true;
            this.lblMostrarResultadoIrrf.BackColor = System.Drawing.Color.White;
            this.lblMostrarResultadoIrrf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoIrrf.Location = new System.Drawing.Point(3, 15);
            this.lblMostrarResultadoIrrf.Name = "lblMostrarResultadoIrrf";
            this.lblMostrarResultadoIrrf.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoIrrf.TabIndex = 6;
            this.lblMostrarResultadoIrrf.Text = "RESULTADO:";
            // 
            // btnCalcularIrrf
            // 
            this.btnCalcularIrrf.Location = new System.Drawing.Point(44, 151);
            this.btnCalcularIrrf.Name = "btnCalcularIrrf";
            this.btnCalcularIrrf.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularIrrf.TabIndex = 9;
            this.btnCalcularIrrf.Text = "CALCULAR";
            this.btnCalcularIrrf.UseVisualStyleBackColor = true;
            this.btnCalcularIrrf.Click += new System.EventHandler(this.btnCalcularIrrf_Click);
            // 
            // lblSalarioIrrf
            // 
            this.lblSalarioIrrf.AutoSize = true;
            this.lblSalarioIrrf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioIrrf.Location = new System.Drawing.Point(40, 45);
            this.lblSalarioIrrf.Name = "lblSalarioIrrf";
            this.lblSalarioIrrf.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioIrrf.TabIndex = 8;
            this.lblSalarioIrrf.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioIrrf
            // 
            this.txtSalarioIrrf.Location = new System.Drawing.Point(44, 89);
            this.txtSalarioIrrf.Name = "txtSalarioIrrf";
            this.txtSalarioIrrf.Size = new System.Drawing.Size(266, 20);
            this.txtSalarioIrrf.TabIndex = 7;
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoIrrf);
            this.Controls.Add(this.btnCalcularIrrf);
            this.Controls.Add(this.lblSalarioIrrf);
            this.Controls.Add(this.txtSalarioIrrf);
            this.Name = "frmDescontoIrrf";
            this.Text = "frmDescontoIrrf";
            this.Load += new System.EventHandler(this.frmDescontoIrrf_Load);
            this.panelResultadoIrrf.ResumeLayout(false);
            this.panelResultadoIrrf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultadoIrrf;
        private System.Windows.Forms.Label lblMostrarResultadoIrrf;
        private System.Windows.Forms.Button btnCalcularIrrf;
        private System.Windows.Forms.Label lblSalarioIrrf;
        private System.Windows.Forms.TextBox txtSalarioIrrf;
    }
}