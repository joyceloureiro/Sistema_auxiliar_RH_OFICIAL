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
            this.rdDemisãoPorJustaCausaSim = new System.Windows.Forms.RadioButton();
            this.rdDemisãoPorJustaCausaNao = new System.Windows.Forms.RadioButton();
            this.lblMesesTrabalhadosAnteriorSeguro = new System.Windows.Forms.Label();
            this.txtMesesTrabalhadosAnteriorSeguro = new System.Windows.Forms.TextBox();
            this.lblVezezSeguroJaSolicitado = new System.Windows.Forms.Label();
            this.txtVezesSeguroJaSolicitado = new System.Windows.Forms.TextBox();
            this.btnCalcularSeguroDesemprego = new System.Windows.Forms.Button();
            this.lblJustaCausaSimouNao = new System.Windows.Forms.Label();
            this.panelExibeDadosSeguroDesemprego = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoSeguroDesemprego = new System.Windows.Forms.Label();
            this.panelExibeDadosSeguroDesemprego.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdDemisãoPorJustaCausaSim
            // 
            this.rdDemisãoPorJustaCausaSim.AutoSize = true;
            this.rdDemisãoPorJustaCausaSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdDemisãoPorJustaCausaSim.Location = new System.Drawing.Point(25, 59);
            this.rdDemisãoPorJustaCausaSim.Name = "rdDemisãoPorJustaCausaSim";
            this.rdDemisãoPorJustaCausaSim.Size = new System.Drawing.Size(44, 17);
            this.rdDemisãoPorJustaCausaSim.TabIndex = 4;
            this.rdDemisãoPorJustaCausaSim.TabStop = true;
            this.rdDemisãoPorJustaCausaSim.Text = "SIM";
            this.rdDemisãoPorJustaCausaSim.UseVisualStyleBackColor = false;
            this.rdDemisãoPorJustaCausaSim.CheckedChanged += new System.EventHandler(this.rdDemisãoPorJustaCausaSim_CheckedChanged);
            // 
            // rdDemisãoPorJustaCausaNao
            // 
            this.rdDemisãoPorJustaCausaNao.AutoSize = true;
            this.rdDemisãoPorJustaCausaNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdDemisãoPorJustaCausaNao.Location = new System.Drawing.Point(105, 59);
            this.rdDemisãoPorJustaCausaNao.Name = "rdDemisãoPorJustaCausaNao";
            this.rdDemisãoPorJustaCausaNao.Size = new System.Drawing.Size(51, 17);
            this.rdDemisãoPorJustaCausaNao.TabIndex = 3;
            this.rdDemisãoPorJustaCausaNao.TabStop = true;
            this.rdDemisãoPorJustaCausaNao.Text = "NÂO!";
            this.rdDemisãoPorJustaCausaNao.UseVisualStyleBackColor = false;
            this.rdDemisãoPorJustaCausaNao.CheckedChanged += new System.EventHandler(this.rdDemisãoPorJustaCausaNao_CheckedChanged);
            // 
            // lblMesesTrabalhadosAnteriorSeguro
            // 
            this.lblMesesTrabalhadosAnteriorSeguro.AutoSize = true;
            this.lblMesesTrabalhadosAnteriorSeguro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMesesTrabalhadosAnteriorSeguro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhadosAnteriorSeguro.Location = new System.Drawing.Point(22, 180);
            this.lblMesesTrabalhadosAnteriorSeguro.Name = "lblMesesTrabalhadosAnteriorSeguro";
            this.lblMesesTrabalhadosAnteriorSeguro.Size = new System.Drawing.Size(442, 20);
            this.lblMesesTrabalhadosAnteriorSeguro.TabIndex = 31;
            this.lblMesesTrabalhadosAnteriorSeguro.Text = "QUANTOS MESES VOCE TRABALHOU ANTERIOR AO SEGURO:";
            // 
            // txtMesesTrabalhadosAnteriorSeguro
            // 
            this.txtMesesTrabalhadosAnteriorSeguro.Location = new System.Drawing.Point(26, 213);
            this.txtMesesTrabalhadosAnteriorSeguro.Name = "txtMesesTrabalhadosAnteriorSeguro";
            this.txtMesesTrabalhadosAnteriorSeguro.Size = new System.Drawing.Size(287, 20);
            this.txtMesesTrabalhadosAnteriorSeguro.TabIndex = 30;
            // 
            // lblVezezSeguroJaSolicitado
            // 
            this.lblVezezSeguroJaSolicitado.AutoSize = true;
            this.lblVezezSeguroJaSolicitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblVezezSeguroJaSolicitado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezezSeguroJaSolicitado.Location = new System.Drawing.Point(21, 95);
            this.lblVezezSeguroJaSolicitado.Name = "lblVezezSeguroJaSolicitado";
            this.lblVezezSeguroJaSolicitado.Size = new System.Drawing.Size(456, 20);
            this.lblVezezSeguroJaSolicitado.TabIndex = 29;
            this.lblVezezSeguroJaSolicitado.Text = "QUANTAS VEZES O SEGURO DESEMPREGO JÁ FOI SOLICITADO?";
            // 
            // txtVezesSeguroJaSolicitado
            // 
            this.txtVezesSeguroJaSolicitado.Location = new System.Drawing.Point(26, 139);
            this.txtVezesSeguroJaSolicitado.Name = "txtVezesSeguroJaSolicitado";
            this.txtVezesSeguroJaSolicitado.Size = new System.Drawing.Size(248, 20);
            this.txtVezesSeguroJaSolicitado.TabIndex = 28;
            // 
            // btnCalcularSeguroDesemprego
            // 
            this.btnCalcularSeguroDesemprego.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularSeguroDesemprego.Location = new System.Drawing.Point(25, 254);
            this.btnCalcularSeguroDesemprego.Name = "btnCalcularSeguroDesemprego";
            this.btnCalcularSeguroDesemprego.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularSeguroDesemprego.TabIndex = 27;
            this.btnCalcularSeguroDesemprego.Text = "CALCULAR";
            this.btnCalcularSeguroDesemprego.UseVisualStyleBackColor = true;
            this.btnCalcularSeguroDesemprego.Click += new System.EventHandler(this.btnCalcularSeguroDesemprego_Click);
            // 
            // lblJustaCausaSimouNao
            // 
            this.lblJustaCausaSimouNao.AutoSize = true;
            this.lblJustaCausaSimouNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblJustaCausaSimouNao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustaCausaSimouNao.ForeColor = System.Drawing.Color.Black;
            this.lblJustaCausaSimouNao.Location = new System.Drawing.Point(21, 21);
            this.lblJustaCausaSimouNao.Name = "lblJustaCausaSimouNao";
            this.lblJustaCausaSimouNao.Size = new System.Drawing.Size(292, 21);
            this.lblJustaCausaSimouNao.TabIndex = 32;
            this.lblJustaCausaSimouNao.Text = "FOI DISPENDADO POR JUSTA CAUSA:";
            // 
            // panelExibeDadosSeguroDesemprego
            // 
            this.panelExibeDadosSeguroDesemprego.AutoSize = true;
            this.panelExibeDadosSeguroDesemprego.BackColor = System.Drawing.Color.Transparent;
            this.panelExibeDadosSeguroDesemprego.Controls.Add(this.lblMostrarResultadoSeguroDesemprego);
            this.panelExibeDadosSeguroDesemprego.Location = new System.Drawing.Point(510, 180);
            this.panelExibeDadosSeguroDesemprego.Name = "panelExibeDadosSeguroDesemprego";
            this.panelExibeDadosSeguroDesemprego.Size = new System.Drawing.Size(166, 105);
            this.panelExibeDadosSeguroDesemprego.TabIndex = 33;
            this.panelExibeDadosSeguroDesemprego.TabStop = true;
            this.panelExibeDadosSeguroDesemprego.Visible = false;
            // 
            // lblMostrarResultadoSeguroDesemprego
            // 
            this.lblMostrarResultadoSeguroDesemprego.AutoSize = true;
            this.lblMostrarResultadoSeguroDesemprego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoSeguroDesemprego.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoSeguroDesemprego.Location = new System.Drawing.Point(13, 34);
            this.lblMostrarResultadoSeguroDesemprego.Name = "lblMostrarResultadoSeguroDesemprego";
            this.lblMostrarResultadoSeguroDesemprego.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoSeguroDesemprego.TabIndex = 6;
            this.lblMostrarResultadoSeguroDesemprego.Text = "RESULTADO:";
            this.lblMostrarResultadoSeguroDesemprego.Visible = false;
            // 
            // frmBeneficioSeguroDesemprego
            // 
           
            this.ClientSize = new System.Drawing.Size(679, 320);
            this.Controls.Add(this.panelExibeDadosSeguroDesemprego);
            this.Controls.Add(this.lblJustaCausaSimouNao);
            this.Controls.Add(this.lblMesesTrabalhadosAnteriorSeguro);
            this.Controls.Add(this.txtMesesTrabalhadosAnteriorSeguro);
            this.Controls.Add(this.lblVezezSeguroJaSolicitado);
            this.Controls.Add(this.txtVezesSeguroJaSolicitado);
            this.Controls.Add(this.btnCalcularSeguroDesemprego);
            this.Controls.Add(this.rdDemisãoPorJustaCausaSim);
            this.Controls.Add(this.rdDemisãoPorJustaCausaNao);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.panelExibeDadosSeguroDesemprego.ResumeLayout(false);
            this.panelExibeDadosSeguroDesemprego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.RadioButton rdDemisãoPorJustaCausaSim;
        private System.Windows.Forms.RadioButton rdDemisãoPorJustaCausaNao;
        private System.Windows.Forms.Label lblMesesTrabalhadosAnteriorSeguro;
        private System.Windows.Forms.TextBox txtMesesTrabalhadosAnteriorSeguro;
        private System.Windows.Forms.Label lblVezezSeguroJaSolicitado;
        private System.Windows.Forms.TextBox txtVezesSeguroJaSolicitado;
        private System.Windows.Forms.Button btnCalcularSeguroDesemprego;
        private System.Windows.Forms.Label lblJustaCausaSimouNao;
        private System.Windows.Forms.Panel panelExibeDadosSeguroDesemprego;
        private System.Windows.Forms.Label lblMostrarResultadoSeguroDesemprego;
    }
}