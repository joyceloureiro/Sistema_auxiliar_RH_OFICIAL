using iRh.Windows.simuladores;
using iRh.Windows.cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows
{
    public partial class PrincipalMdi : Form
    {
        public PrincipalMdi()
        {
            InitializeComponent();
        }

        private void PrincipalMdi_Load(object sender, EventArgs e)
        {

        }

        private void menuDescontoInss_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoInss();            
            form.MdiParent = this;
            form.Show();
        }

        private void menuDescontoIrrf_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrrf();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioAdicionalNoturnu_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioAdicionalNoturno();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioAdicionalFerias_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioferias();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPis_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPi();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioSeguroDesemprego_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioValeTransporte_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioDepositoFgts_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioDepositoFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioHoraExtra_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtra();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBeneficioPericulosidade_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

          
        private void contraChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SistemaSimulacaoCompleta();
            form.MdiParent = this;
            form.Show();
        }

       
    }
}
