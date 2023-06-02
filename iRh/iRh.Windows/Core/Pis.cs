namespace iRh.Windows.Core
{
    public static class Pis
    {
        const double salarioMinimo = 1320.00;
        public static double calculaPis(double salario,double mesesTrabalhadosAnoBasePiss, double anoInscritoPis)
        {
            double pisMensal = 0;

            if (anoInscritoPis >5)
            {
                
                  if (salario < (2 * salarioMinimo))
                 {
                    pisMensal = salarioMinimo / 12;
                    valorPis = mesesTrabalhadosAnoBasePiss * pisMensal;
                 }
            }

    {

    


            return valorPis;
        }
    }
}
