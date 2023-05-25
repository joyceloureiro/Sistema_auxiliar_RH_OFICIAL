namespace iRh.Windows.simuladores
{
    partial class frmBeneficioDepositoFgts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioDepositoFgts));
            this.btnCalcularFgts = new System.Windows.Forms.Button();
            this.lblSalarioFgts = new System.Windows.Forms.Label();
            this.txtSalarioFgts = new System.Windows.Forms.TextBox();
            this.panelResultadoFgts = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoFgts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultadoFgts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularFgts
            // 
            this.btnCalcularFgts.Location = new System.Drawing.Point(42, 142);
            this.btnCalcularFgts.Name = "btnCalcularFgts";
            this.btnCalcularFgts.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularFgts.TabIndex = 5;
            this.btnCalcularFgts.Text = "CALCULAR";
            this.btnCalcularFgts.UseVisualStyleBackColor = true;
            this.btnCalcularFgts.Click += new System.EventHandler(this.btnCalcularFgts_Click);
            // 
            // lblSalarioFgts
            // 
            this.lblSalarioFgts.AutoSize = true;
            this.lblSalarioFgts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFgts.Location = new System.Drawing.Point(38, 46);
            this.lblSalarioFgts.Name = "lblSalarioFgts";
            this.lblSalarioFgts.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioFgts.TabIndex = 4;
            this.lblSalarioFgts.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioFgts
            // 
            this.txtSalarioFgts.Location = new System.Drawing.Point(42, 98);
            this.txtSalarioFgts.Name = "txtSalarioFgts";
            this.txtSalarioFgts.Size = new System.Drawing.Size(266, 20);
            this.txtSalarioFgts.TabIndex = 3;
            // 
            // panelResultadoFgts
            // 
            this.panelResultadoFgts.AutoSize = true;
            this.panelResultadoFgts.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoFgts.Controls.Add(this.lblMostrarResultadoFgts);
            this.panelResultadoFgts.Location = new System.Drawing.Point(42, 189);
            this.panelResultadoFgts.Name = "panelResultadoFgts";
            this.panelResultadoFgts.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoFgts.TabIndex = 6;
            this.panelResultadoFgts.TabStop = true;
            this.panelResultadoFgts.Visible = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioDepositoFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelResultadoFgts);
            this.Controls.Add(this.btnCalcularFgts);
            this.Controls.Add(this.lblSalarioFgts);
            this.Controls.Add(this.txtSalarioFgts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioDepositoFgts";
            this.Text = "frmBeneficioDepositoFgts";
            this.panelResultadoFgts.ResumeLayout(false);
            this.panelResultadoFgts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularFgts;
        private System.Windows.Forms.Label lblSalarioFgts;
        private System.Windows.Forms.TextBox txtSalarioFgts;
        private System.Windows.Forms.Panel panelResultadoFgts;
        private System.Windows.Forms.Label lblMostrarResultadoFgts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}