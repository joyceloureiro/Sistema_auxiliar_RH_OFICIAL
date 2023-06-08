using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioPi : Form
    {
        public frmBeneficioPi()
        {
            InitializeComponent();
        }

        private void btnCalcularPis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioMensalPis.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioMensalPis.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioMensalPis.Text);
                var mesesTrabalhadosAnoBasePis = double.Parse(txtMesesTrabalhadosAnoBasePis.Text);
                var anoInscritoPis = double.Parse(txtAnosInscritoPis.Text);
                var valorPis = Pis.CalculaPis(salario, mesesTrabalhadosAnoBasePis, anoInscritoPis);
                lblMostrarResultadoPis.Text = " Resultado valor pis: " + valorPis.ToString("C");
                lblMostrarResultadoPis.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seus anos inscritos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnosInscritoPis.Focus();

                MessageBox.Show("Informe seus meses trabalhados: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesesTrabalhadosAnoBasePis.Focus();

                MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioMensalPis.Focus();
                throw;
            }
            panelResultadoPis.Show();
        }
    }
}
