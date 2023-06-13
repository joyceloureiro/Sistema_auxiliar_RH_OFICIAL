namespace iRh.Windows
{
    partial class PrincipalMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadrastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdicionalNoturnu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioAdicionalFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioDepositoFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadrastroToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.funcionariosToolStripMenuItem.Text = "Cadrastros";
            // 
            // cadrastroToolStripMenuItem
            // 
            this.cadrastroToolStripMenuItem.Name = "cadrastroToolStripMenuItem";
            this.cadrastroToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cadrastroToolStripMenuItem.Text = "Funcionarios";
            this.cadrastroToolStripMenuItem.Click += new System.EventHandler(this.cadrastroToolStripMenuItem_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrrf,
            this.toolStripSeparator1,
            this.menuBeneficioAdicionalNoturnu,
            this.menuBeneficioAdicionalFerias,
            this.menuBeneficioPis,
            this.menuBeneficioSeguroDesemprego,
            this.menuBeneficioValeTransporte,
            this.menuBeneficioDepositoFgts,
            this.menuBeneficioHoraExtra,
            this.menuBeneficioPericulosidade});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.simuladoresToolStripMenuItem.Text = "simuladores";
            this.simuladoresToolStripMenuItem.Click += new System.EventHandler(this.simuladoresToolStripMenuItem_Click);
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(233, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(233, 22);
            this.menuDescontoIrrf.Text = "Desconto de IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // menuBeneficioAdicionalNoturnu
            // 
            this.menuBeneficioAdicionalNoturnu.Name = "menuBeneficioAdicionalNoturnu";
            this.menuBeneficioAdicionalNoturnu.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioAdicionalNoturnu.Text = "Beneficio Adicional Noturno";
            this.menuBeneficioAdicionalNoturnu.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturnu_Click);
            // 
            // menuBeneficioAdicionalFerias
            // 
            this.menuBeneficioAdicionalFerias.Name = "menuBeneficioAdicionalFerias";
            this.menuBeneficioAdicionalFerias.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioAdicionalFerias.Text = "Beneficio de Feriás";
            this.menuBeneficioAdicionalFerias.Click += new System.EventHandler(this.menuBeneficioAdicionalFerias_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioPis.Text = "Beneficio PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioSeguroDesemprego.Text = "Beneficio Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.menuBeneficioSeguroDesemprego_Click);
            // 
            // menuBeneficioValeTransporte
            // 
            this.menuBeneficioValeTransporte.Name = "menuBeneficioValeTransporte";
            this.menuBeneficioValeTransporte.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioValeTransporte.Text = "Beneficio Vale Transporte";
            this.menuBeneficioValeTransporte.Click += new System.EventHandler(this.menuBeneficioValeTransporte_Click);
            // 
            // menuBeneficioDepositoFgts
            // 
            this.menuBeneficioDepositoFgts.Name = "menuBeneficioDepositoFgts";
            this.menuBeneficioDepositoFgts.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioDepositoFgts.Text = "Beneficio Deposito FGTS";
            this.menuBeneficioDepositoFgts.Click += new System.EventHandler(this.menuBeneficioDepositoFgts_Click);
            // 
            // menuBeneficioHoraExtra
            // 
            this.menuBeneficioHoraExtra.Name = "menuBeneficioHoraExtra";
            this.menuBeneficioHoraExtra.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioHoraExtra.Text = "Beneficio Hora Extra";
            this.menuBeneficioHoraExtra.Click += new System.EventHandler(this.menuBeneficioHoraExtra_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(233, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources._900_473_rh_operacional_e_rh_estrategico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "PrincipalMdi";
            this.Text = "PrincipalMdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalMdi_Load);
            this.BackColorChanged += new System.EventHandler(this.PrincipalMdi_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadrastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalNoturnu;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdicionalFerias;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValeTransporte;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioDepositoFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
    }
}