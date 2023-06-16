using iRh.Windows.Core;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class SistemaSimulacaoCompleta : Form
    {
        public SistemaSimulacaoCompleta()
        {
            InitializeComponent();
        }

       

        private void rdPericulosidadeNao_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void btnCalcularSC_Click(object sender, System.EventArgs e)
        {
            if (rdPericulosidadeNao.Checked)
            {
                if (rdPericulosidadeNao.Checked)
                {
                    if (string.IsNullOrEmpty(txtSalarioBaseSC.Text))
                    {
                        MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();
                        return;
                    }
                    try
                    {
                        var salario = double.Parse(txtSalarioBaseSC.Text);
                        var horasNoturnasTrabalhadas = double.Parse(txtHorasNoturnasMesSC.Text);
                        var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                        var cargaHorariaMes = double.Parse(txtCargaHoraria.Text);

                        var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadas, cargaHorariaMes);
                        var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, cargaHorariaMes);
                        var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                        var valorValeTransporte = ValeTransporte.calculaVT(salario);
                        var descontoInss = Inss.Calcula(salario);
                        var valorIrrf = Irrf.CalculaIrrf(salario);
                        var valorFgts = Fgts.calculaFgts(salario);

                        var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorAdicionalPericulosidade + valorValeTransporte;
                        var salarioComDescontos = salarioComAdicionais - valorIrrf - descontoInss - valorValeTransporte - valorFgts;

                        lblMostrarResultadoSimulacaoCompleta.Text = "valor salario liquído: " + salarioComDescontos.ToString("C");
                        lblMostrarResultadoSimulacaoCompleta.Visible = true;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();

                        MessageBox.Show("Informe sua horas trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCargaHoraria.Focus();

                        MessageBox.Show("Informe sua horas extras trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasExtrasTrabalhadasMesSc.Focus();

                        MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasNoturnasMesSC.Focus();
                        throw;
                    }
                }
                panelResultadoSimulacaoCompleta.Show();
            }
            else
            {
                if (rdPericulosidadeNao.Checked)
                {
                    if (string.IsNullOrEmpty(txtSalarioBaseSC.Text))
                    {
                        MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();
                        return;
                    }
                    try
                    {
                        var salario = double.Parse(txtSalarioBaseSC.Text);
                        var horasNoturnasTrabalhadas = double.Parse(txtHorasNoturnasMesSC.Text);
                        var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                        var cargaHorariaMes = double.Parse(txtCargaHoraria.Text);

                        var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadas, cargaHorariaMes);
                        var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, cargaHorariaMes);
                        var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                        var valorValeTransporte = ValeTransporte.calculaVT(salario);
                        var descontoInss = Inss.Calcula(salario);
                        var valorIrrf = Irrf.CalculaIrrf(salario);
                        var valorFgts = Fgts.calculaFgts(salario);

                        var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorAdicionalPericulosidade + valorValeTransporte;
                        var salarioComDescontos = salarioComAdicionais - valorIrrf - descontoInss - valorValeTransporte - valorFgts;

                        lblMostrarResultadoSimulacaoCompleta.Text = "valor salario liquído: " + salarioComDescontos.ToString("C");
                        lblMostrarResultadoSimulacaoCompleta.Visible = true;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();

                        MessageBox.Show("Informe sua horas trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCargaHoraria.Focus();

                        MessageBox.Show("Informe sua horas extras trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasExtrasTrabalhadasMesSc.Focus();

                        MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasNoturnasMesSC.Focus();
                        throw;
                    }
                }
                panelResultadoSimulacaoCompleta.Show();
                else
                {
                    if (string.IsNullOrEmpty(txtSalarioBaseSC.Text))
                    {
                        MessageBox.Show("Informe seu sálario base: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();
                        return;
                    }
                    try
                    {
                        var salario = double.Parse(txtSalarioBaseSC.Text);
                        var horasNoturnasTrabalhadas = double.Parse(txtHorasNoturnasMesSC.Text);
                        var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                        var cargaHorariaMes = double.Parse(txtCargaHoraria.Text);

                        var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadas, cargaHorariaMes);
                        var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, cargaHorariaMes);
                        var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                        var valorValeTransporte = ValeTransporte.calculaVT(salario);
                        var descontoInss = Inss.Calcula(salario);
                        var valorIrrf = Irrf.CalculaIrrf(salario);
                        var valorFgts = Fgts.calculaFgts(salario);

                        var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorAdicionalPericulosidade + valorValeTransporte;
                        var salarioComDescontos = salarioComAdicionais - valorIrrf - descontoInss - valorValeTransporte - valorFgts;

                        lblMostrarResultadoSimulacaoCompleta.Text = "valor salario liquído: " + salarioComDescontos.ToString("C");
                        lblMostrarResultadoSimulacaoCompleta.Visible = true;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Informe seu sálario base: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalarioBaseSC.Focus();

                        MessageBox.Show("Informe sua horas trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCargaHoraria.Focus();

                        MessageBox.Show("Informe sua horas extras trabalhadas no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasExtrasTrabalhadasMesSc.Focus();

                        MessageBox.Show("Informe sua hora noturna trabalhada no mes: ex:1506", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHorasNoturnasMesSC.Focus();
                        throw;
                    }
                }
                panelResultadoSimulacaoCompleta.Show();
            }
        }
    }


    }
}
