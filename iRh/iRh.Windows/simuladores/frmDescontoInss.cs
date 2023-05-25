using iRh.Windows.Core;
using System;
using System.Windows.Forms;


namespace iRh.Windows.simuladores
{
    public partial class frmDescontoInss : Form
    {

        //construtor
        public frmDescontoInss()
        {
            InitializeComponent();
        }

        private void frmDescontoInss_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var descontoInss = Inss.Calcula(salario);
                lblMostrarResultado.Text = descontoInss.ToString("C");

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                throw;
            }
            panelResultado.Show();
        }
    }
}
