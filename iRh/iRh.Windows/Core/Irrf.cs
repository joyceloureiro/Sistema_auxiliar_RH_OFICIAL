namespace iRh.Windows.Core
{
    public static class Irrf
    {
        const double Faixa01 = 1903.98;
        const double Faixa02 = 2826.65;
        const double Faixa03 = 3751.05;
        const double Faixa04 = 4664.68;

        const double ValorReduzidoAliquota1 = 142.80;
        const double ValorReduzidoAliquota2 = 354.80;
        const double ValorReduzidoAliquota3 = 636.13;
        const double ValorReduzidoAliquota4 = 869.36;


        public static double CalculaIrrf(double salario)
        {
            double descontoInss = Inss.Calcula(salario);
            double salarioDescontadoInss = salario - descontoInss;
            double valorIrrf = 0;
            double valorAliquota = 0;


            if (salarioDescontadoInss < Faixa01)
            {
                valorIrrf = 0.0;
            }
            else if(salarioDescontadoInss > Faixa01 & salarioDescontadoInss <= Faixa02)
            {
                valorAliquota = 0.075 * salarioDescontadoInss;
                valorIrrf = valorAliquota - ValorReduzidoAliquota1;
            }
            else if (salarioDescontadoInss > Faixa02 & salarioDescontadoInss <= Faixa03)
            {
                valorAliquota = 0.15 * salarioDescontadoInss;
                valorIrrf = valorAliquota - ValorReduzidoAliquota2;
            }
            else if (salarioDescontadoInss > Faixa03 & salarioDescontadoInss <= Faixa04)
            {
                valorAliquota = 0.225 * salarioDescontadoInss;
                valorIrrf = valorAliquota - ValorReduzidoAliquota3;
            }
            else
            {
                valorAliquota = 0.275 * salarioDescontadoInss;
                valorIrrf = valorAliquota - ValorReduzidoAliquota4;
            }

            return valorIrrf;

        }
    }
}
