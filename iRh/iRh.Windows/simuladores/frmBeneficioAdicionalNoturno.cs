using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void frmBeneficioAdicionalNoturno_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularAD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioAD.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioAD.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioAD.Text);
                var horasNoturnasTrabalhadas = double.Parse(txtHorasTrabalhadasMes.Text);
                var horasTrabalhadasMes = double.Parse(txtHorasNoturnasMes.Text);
                var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadas, horasTrabalhadasMes);
                lblMostrarResultadoAD.Text = valorAdicionalNoturno.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioAD.Focus();

                MessageBox.Show("Informe sua hora trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasTrabalhadasMes.Focus();

                MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasNoturnasMes.Focus();
                throw;
            }
            panelResultadoAD.Show();
        }
    }
}
