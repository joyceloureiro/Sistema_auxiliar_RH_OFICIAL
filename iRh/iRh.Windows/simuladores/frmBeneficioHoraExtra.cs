using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void btnCalcularHoraExtra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioHoraExtra.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioHoraExtra.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioHoraExtra.Text);
                var horasTrabalhadasMes = double.Parse(txtHorasTrabalhadasMes.Text);
                var horasExtraTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadas.Text);
                var valorAdicionalNoturno = HoraExtra.calculaHoraExtra(salario, horasExtraTrabalhadasMes, horasTrabalhadasMes);
                lblMostrarResultadoHoraExtra.Text = valorAdicionalNoturno.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioHoraExtra.Focus();

                MessageBox.Show("Informe sua hora trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasTrabalhadasMes.Focus();

                MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasExtrasTrabalhadas.Focus();
                throw;
            }
            panelResultadoHoraExtra.Show();
        }
    }
}
