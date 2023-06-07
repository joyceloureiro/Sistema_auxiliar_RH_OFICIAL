using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioferias : Form
    {
        public frmBeneficioferias()
        {
            InitializeComponent();
        }

        private void btnCalcularBonificacaoFerias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBonificacaoFerias.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBonificacaoFerias.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBonificacaoFerias.Text);
                var descontoInss = Inss.Calcula(salario);
                var valorIrrf = Irrf.CalculaIrrf(salario);
                var valorBonificacaoFerias = salario / 3;

                var descontos = descontoInss + valorIrrf;
                var valorTotalProventos = valorBonificacaoFerias + salario;
                var salarioLiquido = valorTotalProventos - descontos;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBonificacaoFerias.Focus();
                throw;
            }
            panelResultadoBonificacaoFerias.Show();
        }

    }
}

