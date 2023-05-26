using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void frmDescontoIrrf_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularIrrf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioIrrf.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioIrrf.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioIrrf.Text);
                var valorIrrf = Irrf.CalculaIrrf(salario);
                lblMostrarResultadoIrrf.Text = valorIrrf.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioIrrf.Focus();
                throw;
            }
            panelResultadoIrrf.Show();
        }
    }
}
