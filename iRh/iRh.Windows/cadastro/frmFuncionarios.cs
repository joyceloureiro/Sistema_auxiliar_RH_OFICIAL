using iRh.Windows.Core;
using System;
using System.Windows.Forms;
using System.Linq;

namespace iRh.Windows.cadastro
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarEstados();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosOsEstados();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados.Order.By(x=> x.Sigla);
            cmbEstados.SelectedIndex = 0;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";
                       
        }

       
    }
}
