namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double calculaAD(double salario, double horasTrabalhadasMes, double horasNoturnasTrabalhadasMes)
        {
            double conversaoHorasEmMinutos = 0;
            double valorHora;
            double acrecimoHoraNoturna;
            double valorAdicionalNoturno;


            conversaoHorasEmMinutos = horasNoturnasTrabalhadasMes * 60;
            horasNoturnasTrabalhadasMes = conversaoHorasEmMinutos / 52.5;
            valorHora = salario / horasTrabalhadasMes;
            acrecimoHoraNoturna = valorHora * 0.2;
            valorAdicionalNoturno = horasNoturnasTrabalhadasMes * acrecimoHoraNoturna;

            return valorAdicionalNoturno;
        }
    }
    
}
