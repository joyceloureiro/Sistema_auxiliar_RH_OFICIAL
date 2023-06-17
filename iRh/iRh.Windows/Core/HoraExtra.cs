namespace iRh.Windows.Core
{
    public static class HoraExtra
    {
        public static double CalculaHoraExtra(double salario, double horasTrabalhadasMes, double horasExtraTrabalhadasMes)
        {
            double valorHora;
            double valorHoraExtra;
            double resultadoHoraExtra;

            valorHora = salario / horasTrabalhadasMes;
            valorHoraExtra = valorHora + (valorHora * 0.5);
            resultadoHoraExtra = valorHoraExtra * horasExtraTrabalhadasMes;

            return resultadoHoraExtra;
        }
    }
}
