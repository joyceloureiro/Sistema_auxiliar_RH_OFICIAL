using iRh.Windows.Core;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace iRh.Windows.simuladores
{
    public partial class SistemaSimulacaoCompleta : Form
    {
        public SistemaSimulacaoCompleta()
        {
            InitializeComponent();
        }


        private void btnCalcularSC_Click(object sender, System.EventArgs e)
        {
            if (rdValeTransporteNao.Checked & rdPericulosidadeNao.Checked) //Vt nao e PERc nao
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
                    var horasNoturnasTrabalhadasMes = double.Parse(txtHorasNoturnasMesSC.Text);
                    var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                    var horasTrabalhadasMes = double.Parse(txtCargaHoraria.Text);

                    var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadasMes, horasTrabalhadasMes);

                    var valorHoraExtra = HoraExtra.CalculaHoraExtra(salario, horasExtrasTrabalhadasMes, horasTrabalhadasMes);
                    
                    var descontoInss = Inss.Calcula(salario);
                    var valorIrrf = Irrf.CalculaIrrf(salario);
                    var valorFgts = Fgts.calculaFgts(salario);

                    var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra;
                    var salarioComDescontos = valorIrrf - descontoInss - valorFgts;
                    var salarioLiquido = salarioComAdicionais - valorIrrf - descontoInss - valorFgts;
                                       

                    lblMostrarHEEntrada.Text = "Horas Extras: " + horasExtrasTrabalhadasMes.ToString("C");
                    lblMostrarNotEntrada.Text = "Horas Noturnas: " + horasNoturnasTrabalhadasMes.ToString("C");
                    lblMostrarSalBrtEntrada.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblFgtsDepResultado.Text = "FGTS (Deposito): " + valorAdicionalNoturno.ToString("C");
                    lblHoraExrResultado.Text = "Hora Extra: " + valorHoraExtra.ToString("C");
                    lblInssResultado.Text = "INSS: " + descontoInss.ToString("C");
                    lblIrrfResultado.Text = "IRRF: " + valorIrrf.ToString("C");
                    lblNortResultado.Text = "Adicional Noturno: " + valorAdicionalNoturno.ToString("C");
                    lblPercResultado.Text = "Adicional Periculosidade: " + 0.ToString("C");
                    lblVtResultado.Text = "Desconto Vale transporte: " + 0.ToString("C");
                    lblSalarioResultado.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblTotalAdicResultado.Text = "Total Adicionais: " + salarioComAdicionais.ToString("C");
                    lblTotalDescResultado.Text = "Total Descontos: " + salarioComDescontos.ToString("C");
                    lblSalarioLiquidResultado.Text = "Salario Liquido: " + salarioLiquido.ToString("C");


                    lblMostrarHEEntrada.Visible = true;
                    lblMostrarNotEntrada.Visible = true;
                    lblMostrarSalBrtEntrada.Visible = true;

                    lblFgtsDepResultado.Visible = true;
                    lblHoraExrResultado.Visible = true;
                    lblInssResultado.Visible = true;
                    lblIrrfResultado.Visible = true;
                    lblNortResultado.Visible = true;
                    lblPercResultado.Visible = true;
                    lblVtResultado.Visible = true;
                    lblSalarioResultado.Visible = true;

                    lblTotalAdicResultado.Visible = true;
                    lblTotalDescResultado.Visible = true;
                    lblSalarioLiquidResultado.Visible = true;


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

                panelResultadoSimulacaoCompleta.Show();
            }
            else if (rdValeTransporteNao.Checked & rdPericulosidadeSim.Checked) //Vt nao e PERc sim
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
                    var horasNoturnasTrabalhadasMes = double.Parse(txtHorasNoturnasMesSC.Text);
                    var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                    var horasTrabalhadasMes = double.Parse(txtCargaHoraria.Text);


                    var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadasMes, horasTrabalhadasMes);
                    var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, horasTrabalhadasMes);
                    var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                    var valorValeTransporte = ValeTransporte.calculaVT(salario);

                    var descontoInss = Inss.Calcula(salario);
                    var valorIrrf = Irrf.CalculaIrrf(salario);
                    var valorFgts = Fgts.calculaFgts(salario);

                    var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorAdicionalPericulosidade;
                    var salarioComDescontos = valorIrrf - descontoInss - valorFgts;
                    var salarioLiquido = salarioComAdicionais - valorIrrf - descontoInss - valorFgts;

                    lblMostrarHEEntrada.Text = "Horas Extras: " + horasExtrasTrabalhadasMes.ToString("C");
                    lblMostrarNotEntrada.Text = "Horas Noturnas: " + horasNoturnasTrabalhadasMes.ToString("C");
                    lblMostrarSalBrtEntrada.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblFgtsDepResultado.Text = "FGTS (Deposito): " + valorAdicionalNoturno.ToString("C");
                    lblHoraExrResultado.Text = "Hora Extra: " + valorHoraExtra.ToString("C");
                    lblInssResultado.Text = "INSS: " + descontoInss.ToString("C");
                    lblIrrfResultado.Text = "IRRF: " + valorIrrf.ToString("C");
                    lblNortResultado.Text = "Adicional Noturno: " + valorAdicionalNoturno.ToString("C");
                    lblPercResultado.Text = "Adicional Periculosidade: " + valorAdicionalPericulosidade.ToString("C");
                    lblVtResultado.Text = "Desconto Vale transporte: " + 0.ToString("C");
                    lblSalarioResultado.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblTotalAdicResultado.Text = "Total Adicionais: " + salarioComAdicionais.ToString("C");
                    lblTotalDescResultado.Text = "Total Descontos: " + salarioComDescontos.ToString("C");
                    lblSalarioLiquidResultado.Text = "Salario Liquido: " + salarioLiquido.ToString("C");


                    lblMostrarHEEntrada.Visible = true;
                    lblMostrarNotEntrada.Visible = true;
                    lblMostrarSalBrtEntrada.Visible = true;

                    lblFgtsDepResultado.Visible = true;
                    lblHoraExrResultado.Visible = true;
                    lblInssResultado.Visible = true;
                    lblIrrfResultado.Visible = true;
                    lblNortResultado.Visible = true;
                    lblPercResultado.Visible = true;
                    lblVtResultado.Visible = true;
                    lblSalarioResultado.Visible = true;

                    lblTotalAdicResultado.Visible = true;
                    lblTotalDescResultado.Visible = true;
                    lblSalarioLiquidResultado.Visible = true;

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

                panelResultadoSimulacaoCompleta.Show();
            }
            else if (rdValeTransporteSim.Checked & rdPericulosidadeSim.Checked) //Vt sim e PERc sim
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
                    var horasNoturnasTrabalhadasMes = double.Parse(txtHorasNoturnasMesSC.Text);
                    var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                    var horasTrabalhadasMes = double.Parse(txtCargaHoraria.Text);

                    var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadasMes, horasTrabalhadasMes);
                    var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, horasTrabalhadasMes);
                    var valorAdicionalPericulosidade = Periculosidade.calculaPericulosidade(salario);
                    var valorValeTransporte = ValeTransporte.calculaVT(salario);

                    var descontoInss = Inss.Calcula(salario);
                    var valorIrrf = Irrf.CalculaIrrf(salario);
                    var valorFgts = Fgts.calculaFgts(salario);

                    var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorValeTransporte + valorAdicionalPericulosidade;
                    var salarioComDescontos =  valorIrrf - descontoInss - valorFgts;
                    var salarioLiquido = salarioComAdicionais - valorIrrf - descontoInss - valorFgts;


                    lblMostrarHEEntrada.Text = "Horas Extras: " + horasExtrasTrabalhadasMes.ToString("C");
                    lblMostrarNotEntrada.Text = "Horas Noturnas: " + horasNoturnasTrabalhadasMes.ToString("C");
                    lblMostrarSalBrtEntrada.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblFgtsDepResultado.Text = "FGTS (Deposito): " + valorAdicionalNoturno.ToString("C");
                    lblHoraExrResultado.Text = "Hora Extra: " + valorHoraExtra.ToString("C");
                    lblInssResultado.Text = "INSS: " + descontoInss.ToString("C");
                    lblIrrfResultado.Text = "IRRF: " + valorIrrf.ToString("C");
                    lblNortResultado.Text = "Adicional Noturno: " + valorAdicionalNoturno.ToString("C");
                    lblPercResultado.Text = "Adicional Periculosidade: " + valorAdicionalPericulosidade.ToString("C");
                    lblVtResultado.Text = "Desconto Vale transporte: " + valorValeTransporte.ToString("C");
                    lblSalarioResultado.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblTotalAdicResultado.Text = "Total Adicionais: " + salarioComAdicionais.ToString("C");
                    lblTotalDescResultado.Text = "Total Descontos: " + salarioComDescontos.ToString("C");
                    lblSalarioLiquidResultado.Text = "Salario Liquido: " + salarioLiquido.ToString("C");


                    lblMostrarHEEntrada.Visible = true;
                    lblMostrarNotEntrada.Visible = true;
                    lblMostrarSalBrtEntrada.Visible = true;

                    lblFgtsDepResultado.Visible = true;
                    lblHoraExrResultado.Visible = true;
                    lblInssResultado.Visible = true;
                    lblIrrfResultado.Visible = true;
                    lblNortResultado.Visible = true;
                    lblPercResultado.Visible = true;
                    lblVtResultado.Visible = true;
                    lblSalarioResultado.Visible = true;

                    lblTotalAdicResultado.Visible = true;
                    lblTotalDescResultado.Visible = true;
                    lblSalarioLiquidResultado.Visible = true;

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
            
            panelResultadoSimulacaoCompleta.Show();
            }
            else if (rdValeTransporteSim.Checked & rdPericulosidadeNao.Checked) //Vt sim e PERc nao
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
                    var horasNoturnasTrabalhadasMes = double.Parse(txtHorasNoturnasMesSC.Text);
                    var horasExtrasTrabalhadasMes = double.Parse(txtHorasExtrasTrabalhadasMesSc.Text);
                    var horasTrabalhadasMes = double.Parse(txtCargaHoraria.Text);

                    var valorAdicionalNoturno = AdicionalNoturno.calculaAD(salario, horasNoturnasTrabalhadasMes, horasTrabalhadasMes);
                    var valorHoraExtra = HoraExtra.calculaHoraExtra(salario, horasExtrasTrabalhadasMes, horasTrabalhadasMes);
                    var valorValeTransporte = ValeTransporte.calculaVT(salario);

                    var descontoInss = Inss.Calcula(salario);
                    var valorIrrf = Irrf.CalculaIrrf(salario);
                    var valorFgts = Fgts.calculaFgts(salario);

                    var salarioComAdicionais = salario + valorAdicionalNoturno + valorHoraExtra + valorValeTransporte;
                    var salarioComDescontos =  valorIrrf - descontoInss - valorFgts;
                    var salarioLiquido = salarioComAdicionais - valorIrrf - descontoInss - valorFgts;

        

                    lblMostrarHEEntrada.Text = "Horas Extras: " + txtHorasExtrasTrabalhadasMesSc;
                    lblMostrarNotEntrada.Text = "Horas Noturnas: " + txtHorasNoturnasMesSC;
                    lblMostrarSalBrtEntrada.Text = "valor salario Bruto: " + txtSalarioBaseSC;
                    
                    lblFgtsDepResultado.Text = "FGTS (Deposito): " + valorAdicionalNoturno.ToString("C");
                    lblHoraExrResultado.Text = "Hora Extra: " + valorHoraExtra.ToString("C");
                    lblInssResultado.Text = "INSS: " + descontoInss.ToString("C");
                    lblIrrfResultado.Text = "IRRF: " + valorIrrf.ToString("C");
                    lblNortResultado.Text = "Adicional Noturno: " + valorAdicionalNoturno.ToString("C");
                    lblPercResultado.Text = "Adicional Periculosidade: " + 0.ToString("C");
                    lblSalarioResultado.Text = "valor salario Bruto: " + salario.ToString("C");

                    lblTotalAdicResultado.Text = "Total Adicionais: " + salarioComAdicionais.ToString("C");
                    lblTotalDescResultado.Text = "Total Descontos: " + salarioComDescontos.ToString("C");
                    lblSalarioLiquidResultado.Text = "Salario Liquido: " + salarioLiquido.ToString("C");


                    lblMostrarHEEntrada.Visible = true;
                    lblMostrarNotEntrada.Visible = true;
                    lblMostrarSalBrtEntrada.Visible = true;

                    lblFgtsDepResultado.Visible = true;
                    lblHoraExrResultado.Visible = true;
                    lblInssResultado.Visible = true;
                    lblIrrfResultado.Visible = true;
                    lblNortResultado.Visible = true;
                    lblPercResultado.Visible = true;
                    lblVtResultado.Visible = true;
                    lblSalarioResultado.Visible = true;

                    lblTotalAdicResultado.Visible = true;
                    lblTotalDescResultado.Visible = true;
                    lblSalarioLiquidResultado.Visible = true;

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
    
    


