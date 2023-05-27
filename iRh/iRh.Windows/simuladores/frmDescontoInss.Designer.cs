namespace iRh.Windows.simuladores
{
    partial class frmDescontoInss
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoInss));
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblMostrarResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(47, 39);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(152, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "SALARIO BASE";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.White;
            this.txtSalario.Location = new System.Drawing.Point(43, 89);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(253, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(43, 125);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 27);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR INSS";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.AutoSize = true;
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblMostrarResultado);
            this.panelResultado.Location = new System.Drawing.Point(597, 107);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(159, 136);
            this.panelResultado.TabIndex = 4;
            this.panelResultado.TabStop = true;
            this.panelResultado.Visible = false;
            // 
            // lblMostrarResultado
            // 
            this.lblMostrarResultado.AutoSize = true;
            this.lblMostrarResultado.BackColor = System.Drawing.Color.Yellow;
            this.lblMostrarResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultado.Location = new System.Drawing.Point(3, 6);
            this.lblMostrarResultado.Name = "lblMostrarResultado";
            this.lblMostrarResultado.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultado.TabIndex = 6;
            this.lblMostrarResultado.Text = "RESULTADO:";
            // 
            // frmDescontoInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Name = "frmDescontoInss";
            this.Text = "Desconto de Inss";
            this.Load += new System.EventHandler(this.frmDescontoInss_Load);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblMostrarResultado;
    }
}