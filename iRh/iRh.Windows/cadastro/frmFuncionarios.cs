using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            rdTemFilhosNao.Checked = true;
            panalExibeDadosFilhos.Visible = false;
        }

        private void rdTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panalExibeDadosFilhos.Visible = true;
        }

        private void rdTemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panalExibeDadosFilhos.Visible = false;
        }
           

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;
                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("A data de nascimento parece está errada, detalhamento: ", ex.Message); 
                }


                
            }

        }
        private string comprimentador(int opcaoSelecionada)
        {
            switch (opcaoSelecionada)
            {
                case 1: return "prezado, senhor: ";
                case 2: return "prezada, senhora: ";
                
                                                    
                default:
                    break;
            }
        }
    }
}
