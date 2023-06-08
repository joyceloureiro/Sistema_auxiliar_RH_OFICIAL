namespace iRh.Windows.Core
{
    public static class HoraExtra
    {
        public static double calculaHoraExtra(double salario, double horasTrabalhadasMes, double horasExtraTrabalhadasMes)
        {
            double valorHora;
            double valorHoraExtra;
            double resultadoHoraExtra;

            valorHora = salario / horasTrabalhadasMes;
            valorHoraExtra = valorHora + (valorHora/2);
            resultadoHoraExtra = valorHoraExtra * horasExtraTrabalhadasMes;

            return resultadoHoraExtra;
        }
    }
}
