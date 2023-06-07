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
            panelExibeDadosSeguroDesemprego.Visible = false;
        }

        private void rdTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosSeguroDesemprego.Visible = true;
        }

        private void rdTemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosSeguroDesemprego.Visible = false;
        }

        

        private void rdDemisãoPorJustaCausaSim_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Infelismente voce não esta não pode receber o seguro desemprego se foi mandado embora por justa causa","Erro",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void rdDemisãoPorJustaCausaNao_CheckedChanged(object sender, EventArgs e)
        {

        }
            private void btnCalcularSeguroDesemprego_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtMesesTrabalhadosAnteriorSeguro.Text))
                {
                    MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesTrabalhadosAnteriorSeguro.Focus();
                    return;
                }
                try
                {
                    var quantidadeVezesSeguroroDesempregoSolicitado = double.Parse(txtVezesSeguroJaSolicitado.Text);
                    var quantidadeMesesTrabalhados = double.Parse(txtMesesTrabalhadosAnteriorSeguro.Text);
                    var resultadoSeguroDesemprego = SeguroDesemprego.calculaSeguroDesemprego(quantidadeMesesTrabalhados, quantidadeVezesSeguroroDesempregoSolicitado);
                   
                    if(resultadoSeguroDesemprego == 0)
                    {
                        MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMostrarResultadoSeguroDesemprego.Focus();
                    }
                    else if(resultadoSeguroDesemprego == 1)
                    {
                        MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMostrarResultadoSeguroDesemprego.Focus();
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesTrabalhadosAnteriorSeguro.Focus();

                    MessageBox.Show("Informe sua hora trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVezesSeguroJaSolicitado.Focus();

                    throw;
                }
                panelExibeDadosSeguroDesemprego.Show();
            }

        
        
    }
}
