using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {

        public frmBeneficioSeguroDesemprego()
        {
               InitializeComponent();
        }
                         
        private void rdDemisãoPorJustaCausaSim_CheckedChanged(object sender, EventArgs e)
        {
               MessageBox.Show("Infelismente voce não está apto a receber o seguro desemprego, por que foi mandado embora por justa causa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void rdDemisãoPorJustaCausaNao_CheckedChanged(object sender, EventArgs e)
        {

        }
            private void btnCalcularSeguroDesemprego_Click(object sender, EventArgs e)
            {

            try
            {
                if (string.IsNullOrEmpty(txtMesesTrabalhadosAnteriorSeguro.Text))
                {
                    MessageBox.Show("Informe seu o numero de meses trabalhados: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesTrabalhadosAnteriorSeguro.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtVezesSeguroJaSolicitado.Text)
 )
                {
                    MessageBox.Show("Informe o numero de vezes que o seguro foi solicitado: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVezesSeguroJaSolicitado.Focus();
                    return;
                }

                var quantidadeVezesSeguroroDesempregoSolicitado = double.Parse(txtVezesSeguroJaSolicitado.Text);
                var quantidadeMesesTrabalhados = double.Parse(txtMesesTrabalhadosAnteriorSeguro.Text);
                var resultadoSeguroDesemprego = SeguroDesemprego.calculaSeguroDesemprego(quantidadeMesesTrabalhados, quantidadeVezesSeguroroDesempregoSolicitado);



                if (resultadoSeguroDesemprego == 0)
                {
                    MessageBox.Show("A quantidade de parcelas a receber é: ", "Voce não tem direiro a recener o seguro desemprego", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMostrarResultadoSeguroDesemprego.Focus();
                }
                else if (resultadoSeguroDesemprego > 0)
                {
                   
                    lblMostrarResultadoSeguroDesemprego.Text = " parcelas: " + resultadoSeguroDesemprego.ToString("");
                    lblMostrarResultadoSeguroDesemprego.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os dados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesesTrabalhadosAnteriorSeguro.Focus();

                MessageBox.Show("Verifique se os dados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVezesSeguroJaSolicitado.Focus();

                throw;
            }
                panelExibeDadosSeguroDesemprego.Visible = true;
            }
    }
}
