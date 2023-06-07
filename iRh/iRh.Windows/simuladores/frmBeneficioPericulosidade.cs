using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalcularPericulosidade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioPericulosidade.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioPericulosidade.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioPericulosidade.Text);
                var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                lblMostrarResultadoPericulosidade.Text = valorAdicionalPericulosidade.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioPericulosidade.Focus();
                throw;
            }
            panelResultadoPericulosidade.Show();
        }
    }
}
