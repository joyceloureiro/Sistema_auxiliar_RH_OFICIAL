namespace iRh.Windows.simuladores
{
    partial class SistemaSimulacaoCompleta
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
            this.lblSalarioBaseSC = new System.Windows.Forms.Label();
            this.txtSalarioBaseSC = new System.Windows.Forms.TextBox();
            this.lblHorasExtrasTrabalhadasSC = new System.Windows.Forms.Label();
            this.txtHorasExtrasTrabalhadasMesSc = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnasMesSC = new System.Windows.Forms.Label();
            this.txtHorasNoturnasMesSC = new System.Windows.Forms.TextBox();
            this.btnCalcularSC = new System.Windows.Forms.Button();
            this.lblPericulosidadeSimouNao = new System.Windows.Forms.Label();
            this.rdPericulosidadeSim = new System.Windows.Forms.RadioButton();
            this.rdPericulosidadeNao = new System.Windows.Forms.RadioButton();
            this.lblValeTranporte = new System.Windows.Forms.Label();
            this.rdValeTransporteSim = new System.Windows.Forms.RadioButton();
            this.rdValeTransporteNao = new System.Windows.Forms.RadioButton();
            this.panelResultadoSimulacaoCompleta = new System.Windows.Forms.Panel();
            this.lblMostrarResultadoSimulacaoCompleta = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.groupBoxAdicionalPericulosidade = new System.Windows.Forms.GroupBox();
            this.panelResultadoSimulacaoCompleta.SuspendLayout();
            this.groupBoxAdicionalPericulosidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBaseSC
            // 
            this.lblSalarioBaseSC.AutoSize = true;
            this.lblSalarioBaseSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSalarioBaseSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBaseSC.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioBaseSC.Location = new System.Drawing.Point(43, 27);
            this.lblSalarioBaseSC.Name = "lblSalarioBaseSC";
            this.lblSalarioBaseSC.Size = new System.Drawing.Size(178, 21);
            this.lblSalarioBaseSC.TabIndex = 22;
            this.lblSalarioBaseSC.Text = "DIGITE SALARIO BASE:";
            // 
            // txtSalarioBaseSC
            // 
            this.txtSalarioBaseSC.Location = new System.Drawing.Point(47, 51);
            this.txtSalarioBaseSC.Name = "txtSalarioBaseSC";
            this.txtSalarioBaseSC.Size = new System.Drawing.Size(224, 20);
            this.txtSalarioBaseSC.TabIndex = 21;
            // 
            // lblHorasExtrasTrabalhadasSC
            // 
            this.lblHorasExtrasTrabalhadasSC.AutoSize = true;
            this.lblHorasExtrasTrabalhadasSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHorasExtrasTrabalhadasSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtrasTrabalhadasSC.Location = new System.Drawing.Point(43, 144);
            this.lblHorasExtrasTrabalhadasSC.Name = "lblHorasExtrasTrabalhadasSC";
            this.lblHorasExtrasTrabalhadasSC.Size = new System.Drawing.Size(314, 21);
            this.lblHorasExtrasTrabalhadasSC.TabIndex = 28;
            this.lblHorasExtrasTrabalhadasSC.Text = "HORAS EXTRAS TRABALHADAS NO MES:";
            // 
            // txtHorasExtrasTrabalhadasMesSc
            // 
            this.txtHorasExtrasTrabalhadasMesSc.Location = new System.Drawing.Point(47, 168);
            this.txtHorasExtrasTrabalhadasMesSc.Name = "txtHorasExtrasTrabalhadasMesSc";
            this.txtHorasExtrasTrabalhadasMesSc.Size = new System.Drawing.Size(248, 20);
            this.txtHorasExtrasTrabalhadasMesSc.TabIndex = 27;
            // 
            // lblHorasNoturnasMesSC
            // 
            this.lblHorasNoturnasMesSC.AutoSize = true;
            this.lblHorasNoturnasMesSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHorasNoturnasMesSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnasMesSC.Location = new System.Drawing.Point(43, 208);
            this.lblHorasNoturnasMesSC.Name = "lblHorasNoturnasMesSC";
            this.lblHorasNoturnasMesSC.Size = new System.Drawing.Size(304, 21);
            this.lblHorasNoturnasMesSC.TabIndex = 31;
            this.lblHorasNoturnasMesSC.Text = "HORAS NOTURNAS TRABALHDAS MES:";
            // 
            // txtHorasNoturnasMesSC
            // 
            this.txtHorasNoturnasMesSC.Location = new System.Drawing.Point(47, 232);
            this.txtHorasNoturnasMesSC.Name = "txtHorasNoturnasMesSC";
            this.txtHorasNoturnasMesSC.Size = new System.Drawing.Size(287, 20);
            this.txtHorasNoturnasMesSC.TabIndex = 30;
            // 
            // btnCalcularSC
            // 
            this.btnCalcularSC.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularSC.Location = new System.Drawing.Point(47, 271);
            this.btnCalcularSC.Name = "btnCalcularSC";
            this.btnCalcularSC.Size = new System.Drawing.Size(122, 24);
            this.btnCalcularSC.TabIndex = 29;
            this.btnCalcularSC.Text = "CALCULAR";
            this.btnCalcularSC.UseVisualStyleBackColor = true;
            this.btnCalcularSC.Click += new System.EventHandler(this.btnCalcularSC_Click);
            // 
            // lblPericulosidadeSimouNao
            // 
            this.lblPericulosidadeSimouNao.AutoSize = true;
            this.lblPericulosidadeSimouNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPericulosidadeSimouNao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPericulosidadeSimouNao.ForeColor = System.Drawing.Color.Black;
            this.lblPericulosidadeSimouNao.Location = new System.Drawing.Point(405, 27);
            this.lblPericulosidadeSimouNao.Name = "lblPericulosidadeSimouNao";
            this.lblPericulosidadeSimouNao.Size = new System.Drawing.Size(325, 21);
            this.lblPericulosidadeSimouNao.TabIndex = 35;
            this.lblPericulosidadeSimouNao.Text = "RECEBE ADICIONAL DE PERICULOSIDADE:";
            // 
            // rdPericulosidadeSim
            // 
            this.rdPericulosidadeSim.AutoSize = true;
            this.rdPericulosidadeSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdPericulosidadeSim.Location = new System.Drawing.Point(22, 19);
            this.rdPericulosidadeSim.Name = "rdPericulosidadeSim";
            this.rdPericulosidadeSim.Size = new System.Drawing.Size(44, 17);
            this.rdPericulosidadeSim.TabIndex = 34;
            this.rdPericulosidadeSim.TabStop = true;
            this.rdPericulosidadeSim.Text = "SIM";
            this.rdPericulosidadeSim.UseVisualStyleBackColor = false;
            // 
            // rdPericulosidadeNao
            // 
            this.rdPericulosidadeNao.AutoSize = true;
            this.rdPericulosidadeNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdPericulosidadeNao.Location = new System.Drawing.Point(124, 19);
            this.rdPericulosidadeNao.Name = "rdPericulosidadeNao";
            this.rdPericulosidadeNao.Size = new System.Drawing.Size(51, 17);
            this.rdPericulosidadeNao.TabIndex = 33;
            this.rdPericulosidadeNao.TabStop = true;
            this.rdPericulosidadeNao.Text = "NÂO!";
            this.rdPericulosidadeNao.UseVisualStyleBackColor = false;
            // 
            // lblValeTranporte
            // 
            this.lblValeTranporte.AutoSize = true;
            this.lblValeTranporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblValeTranporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeTranporte.ForeColor = System.Drawing.Color.Black;
            this.lblValeTranporte.Location = new System.Drawing.Point(405, 120);
            this.lblValeTranporte.Name = "lblValeTranporte";
            this.lblValeTranporte.Size = new System.Drawing.Size(308, 21);
            this.lblValeTranporte.TabIndex = 38;
            this.lblValeTranporte.Text = "O VALE TRANSPORTES È DESCONTADO:";
            // 
            // rdValeTransporteSim
            // 
            this.rdValeTransporteSim.AutoSize = true;
            this.rdValeTransporteSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdValeTransporteSim.Location = new System.Drawing.Point(409, 166);
            this.rdValeTransporteSim.Name = "rdValeTransporteSim";
            this.rdValeTransporteSim.Size = new System.Drawing.Size(44, 17);
            this.rdValeTransporteSim.TabIndex = 37;
            this.rdValeTransporteSim.TabStop = true;
            this.rdValeTransporteSim.Text = "SIM";
            this.rdValeTransporteSim.UseVisualStyleBackColor = false;
            // 
            // rdValeTransporteNao
            // 
            this.rdValeTransporteNao.AutoSize = true;
            this.rdValeTransporteNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdValeTransporteNao.Location = new System.Drawing.Point(521, 166);
            this.rdValeTransporteNao.Name = "rdValeTransporteNao";
            this.rdValeTransporteNao.Size = new System.Drawing.Size(51, 17);
            this.rdValeTransporteNao.TabIndex = 36;
            this.rdValeTransporteNao.TabStop = true;
            this.rdValeTransporteNao.Text = "NÂO!";
            this.rdValeTransporteNao.UseVisualStyleBackColor = false;
            // 
            // panelResultadoSimulacaoCompleta
            // 
            this.panelResultadoSimulacaoCompleta.AutoSize = true;
            this.panelResultadoSimulacaoCompleta.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoSimulacaoCompleta.Controls.Add(this.lblMostrarResultadoSimulacaoCompleta);
            this.panelResultadoSimulacaoCompleta.Location = new System.Drawing.Point(409, 212);
            this.panelResultadoSimulacaoCompleta.Name = "panelResultadoSimulacaoCompleta";
            this.panelResultadoSimulacaoCompleta.Size = new System.Drawing.Size(153, 83);
            this.panelResultadoSimulacaoCompleta.TabIndex = 39;
            this.panelResultadoSimulacaoCompleta.TabStop = true;
            this.panelResultadoSimulacaoCompleta.Visible = false;
            // 
            // lblMostrarResultadoSimulacaoCompleta
            // 
            this.lblMostrarResultadoSimulacaoCompleta.AutoSize = true;
            this.lblMostrarResultadoSimulacaoCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMostrarResultadoSimulacaoCompleta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarResultadoSimulacaoCompleta.Location = new System.Drawing.Point(3, 0);
            this.lblMostrarResultadoSimulacaoCompleta.Name = "lblMostrarResultadoSimulacaoCompleta";
            this.lblMostrarResultadoSimulacaoCompleta.Size = new System.Drawing.Size(131, 30);
            this.lblMostrarResultadoSimulacaoCompleta.TabIndex = 6;
            this.lblMostrarResultadoSimulacaoCompleta.Text = "RESULTADO:";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCargaHoraria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.lblCargaHoraria.Location = new System.Drawing.Point(43, 84);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(207, 21);
            this.lblCargaHoraria.TabIndex = 41;
            this.lblCargaHoraria.Text = "CARGA HORARIA MENSAL";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(47, 108);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(224, 20);
            this.txtCargaHoraria.TabIndex = 40;
            // 
            // groupBoxAdicionalPericulosidade
            // 
            this.groupBoxAdicionalPericulosidade.Controls.Add(this.rdPericulosidadeSim);
            this.groupBoxAdicionalPericulosidade.Controls.Add(this.rdPericulosidadeNao);
            this.groupBoxAdicionalPericulosidade.Location = new System.Drawing.Point(393, 59);
            this.groupBoxAdicionalPericulosidade.Name = "groupBoxAdicionalPericulosidade";
            this.groupBoxAdicionalPericulosidade.Size = new System.Drawing.Size(200, 58);
            this.groupBoxAdicionalPericulosidade.TabIndex = 42;
            this.groupBoxAdicionalPericulosidade.TabStop = false;
            // 
            // SistemaSimulacaoCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAdicionalPericulosidade);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.panelResultadoSimulacaoCompleta);
            this.Controls.Add(this.lblValeTranporte);
            this.Controls.Add(this.rdValeTransporteSim);
            this.Controls.Add(this.rdValeTransporteNao);
            this.Controls.Add(this.lblPericulosidadeSimouNao);
            this.Controls.Add(this.lblHorasNoturnasMesSC);
            this.Controls.Add(this.txtHorasNoturnasMesSC);
            this.Controls.Add(this.btnCalcularSC);
            this.Controls.Add(this.lblHorasExtrasTrabalhadasSC);
            this.Controls.Add(this.txtHorasExtrasTrabalhadasMesSc);
            this.Controls.Add(this.lblSalarioBaseSC);
            this.Controls.Add(this.txtSalarioBaseSC);
            this.Name = "SistemaSimulacaoCompleta";
            this.Text = "SistemaSimulacaoCompleta";
            this.panelResultadoSimulacaoCompleta.ResumeLayout(false);
            this.panelResultadoSimulacaoCompleta.PerformLayout();
            this.groupBoxAdicionalPericulosidade.ResumeLayout(false);
            this.groupBoxAdicionalPericulosidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBaseSC;
        private System.Windows.Forms.TextBox txtSalarioBaseSC;
        private System.Windows.Forms.Label lblHorasExtrasTrabalhadasSC;
        private System.Windows.Forms.TextBox txtHorasExtrasTrabalhadasMesSc;
        private System.Windows.Forms.Label lblHorasNoturnasMesSC;
        private System.Windows.Forms.TextBox txtHorasNoturnasMesSC;
        private System.Windows.Forms.Button btnCalcularSC;
        private System.Windows.Forms.Label lblPericulosidadeSimouNao;
        private System.Windows.Forms.RadioButton rdPericulosidadeSim;
        private System.Windows.Forms.RadioButton rdPericulosidadeNao;
        private System.Windows.Forms.Label lblValeTranporte;
        private System.Windows.Forms.RadioButton rdValeTransporteSim;
        private System.Windows.Forms.RadioButton rdValeTransporteNao;
        private System.Windows.Forms.Panel panelResultadoSimulacaoCompleta;
        private System.Windows.Forms.Label lblMostrarResultadoSimulacaoCompleta;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.GroupBox groupBoxAdicionalPericulosidade;
    }
}