using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

            rdDemisãoPorJustaCausaNao.Checked = true;
            panalExibeDadosSeguroDesemprego.Visible = false;
        }

        private void rdTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panalExibeDadosSeguroDesemprego.Visible = true;
        }

        private void rdTemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panalExibeDadosSeguroDesemprego.Visible = false;
        }

        

        private void rdDemisãoPorJustaCausaSim_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Invelismente voce não esta não pode receber o seguro desemprego se foi mandado embora por justa causa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdDemisãoPorJustaCausaNao_CheckedChanged(object sender, EventArgs e)
        {
            public void btnCalcularSD_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtSeguroDesempregoSolicitado.Text))
                {
                    MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSeguroDesempregoSolicitado.Focus();
                    return;
                }
                try
                {

                    var quantidadeVezesSeguroroDesempregoSolicitado = double.Parse(txtSeguroDesempregoSolicitado.Text);
                    var quantidadeMesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
                    var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadas, horasTrabalhadasMe;
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
}
