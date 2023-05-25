using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void frmBeneficioValeTransporte_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcularVT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioVT.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioVT.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioVT.Text);
                var valorPassagemvalorPassagem = double.Parse(txtValorPassagemVT.Text);
                var valorValeTransporte = ValeTransporte.calculaVT(salario);
                lblMostrarResultadoVT.Text = valorValeTransporte.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioVT.Focus();
                throw;
            }
            panelResultadoVT.Show();
        }







    }
}
