using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioDepositoFgts : Form
    {
        public frmBeneficioDepositoFgts()
        {
            InitializeComponent();
        }

        private void btnCalcularFgts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioFgts.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioFgts.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioFgts.Text);
                var valorFgts = Fgts.calculaFgts(salario);
                lblMostrarResultadoFgts.Text = "valor FGTS: " + valorFgts.ToString("C");
              
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioFgts.Focus();
                throw;
            }
            panelResultadoFgts.Show();
        }
    }      
}
