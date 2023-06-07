namespace iRh.Windows.Core
{
    public static class Pis
    {
        const double salarioMinimo = 1320.00;
        public static double CalculaPis(double salario,double mesesTrabalhadosAnoBasePiss, double anoInscritoPis)
        {
            double pisMensal = 0;
            double valorPis;

            if (anoInscritoPis >5)
            {
                
                  if (salario < (2 * salarioMinimo))
                 {
                        if (mesesTrabalhadosAnoBasePiss > 1)
                       {
                           pisMensal = salarioMinimo / 12;
                            valorPis = mesesTrabalhadosAnoBasePiss * pisMensal;
                        }
                        else
                       {
                           valorPis = 0;
                       }
                 }
                 else
                 {
                    valorPis = 0;
                 }

            }
            else
            {
                valorPis = 0;
            }

            

    


            return valorPis;
        }
    }
}
