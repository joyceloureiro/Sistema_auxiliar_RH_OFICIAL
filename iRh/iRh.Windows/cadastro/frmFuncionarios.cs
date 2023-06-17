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
            if(cepDigitado.Length < 9)
            {
                MessageBox.Show("Digite um cep valido");
                txtCep.Focus();
                return;
            }

            var endereco = new Endereco();
            endereco = endereco.ObterPorCep(cepDigitado);

            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            if(enderecoCompleto.Erro == true)
            {
                MessageBox.Show("O cep não existe");
                txtCep.Focus();
                return;
            }
            if(enderecoCompleto.Localidade != "")
            {
                txtCidade.Enabled = false;
            }
            if(endereco.Uf != "")
            {
                cmbEstados.Enabled = false;
            }

            txtLogadouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbEstados.SelectedValue = enderecoCompleto.Uf;

          
        }

        private void bntEnter_Click(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
            txtDdd.Enabled = false;
            cmbEstados.Enabled = false;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCep.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, só digite numeros.");
                txtCep.Text = txtCep.Text.Remove(txtCep.Text.Length - 1);
            }
            
        }
        private void txtNumero_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumero.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, só digite numeros.");
                txtNumero.Text = txtNumero.Text.Remove(txtNumero.Text.Length - 1);
            }
        }
               
        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCidade.Text, "[^a-z]"))
            {
                MessageBox.Show("Por favor, só digite letras.");
                txtCidade.Text = txtCidade.Text.Remove(txtCidade.Text.Length - 1);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNome.Text, "[^a-z]"))
            {
                MessageBox.Show("Por favor, só digite letras.");
                txtNome.Text = txtNome.Text.Remove(txtNome.Text.Length - 1);
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBairro.Text, "[^a-z]"))
            {
                MessageBox.Show("Por favor, só digite letras.");
                txtBairro.Text = txtBairro.Text.Remove(txtBairro.Text.Length - 1);
            }
        }

        private void txtLogadouro_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLogadouro.Text, "[^a-z]"))
            {
                MessageBox.Show("Por favor, só digite letras.");
                txtLogadouro.Text = txtLogadouro.Text.Remove(txtLogadouro.Text.Length - 1);
            }
        }

        private void txtDdd_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDdd.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, só digite numeros.");
                txtDdd.Text = txtDdd.Text.Remove(txtDdd.Text.Length - 1);
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCpf.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, só digite numeros.");
                txtCpf.Text = txtCpf.Text.Remove(txtCpf.Text.Length - 1);
            }
        }
                
        private void linkLblWhats_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void linkLblWhats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ddd = txtDdd;
            var numero = txtNumero;

            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=" + ddd + numero + "&text=ol%C3%A1%20amigo%20");
        }

        private void btnImagemWhatszap_Click(object sender, EventArgs e)
        {

        }
    }
}
