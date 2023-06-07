namespace iRh.Windows.Core
{
    public static class HoraExtra
    {
        public static double calculaHoraExtra(double salario, double horasTrabalhadasMes, double horasExtraTrabalhadasMes)
        {
            double valorHora;
            double valorHoraExtra;

            valorHora = salario / horasTrabalhadasMes;
            valorHoraExtra = valorHora + (valorHora * 0.5);
            valorHoraExtra = valorHoraExtra * horasExtraTrabalhadasMes;

            return valorHoraExtra;
        }
    }
}
