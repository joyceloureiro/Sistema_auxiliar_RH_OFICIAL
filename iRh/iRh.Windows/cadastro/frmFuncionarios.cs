using iRh.Windows.Core;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Security.Policy;

namespace iRh.Windows.cadastro
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load_1(object sender, EventArgs e)
        {
            CarregarEstados();
            carregarDocumentos();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosOsEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
                       
        }
        private void carregarDocumentos()
        {
            var documento = new Documento();
            var listaDocumentos = documento.ObterTodosOsDocumentos();
            var todosDocumentos = listaDocumentos.OrderBy(x => x.Id).ToList();

            cmbDocumento.Items.Clear();
            cmbDocumento.DataSource = todosDocumentos;
            cmbDocumento.DisplayMember = "Nome";
            cmbDocumento.ValueMember = "Id";

        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            var cepDigitado = txtCep.Text;

            var endereco = new Endereco(0);
            endereco = endereco.ObterPorCep(cepDigitado);

        }
    }
}
