namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double calculaSeguroDesemprego(double quantidadeMesesTrabalhados, double quantidadeVezesSeguroroDesempregoSolicitado)
        {

            if (quantidadeVezesSeguroroDesempregoSolicitado == 0)
            {
                if(quantidadeMesesTrabalhados <12)
                {
                    return 0;
                }
                else if  (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 25)
                {
                    return 4;                   
                }
                else
                {
                    return 5;                    
                }
            }
            else if (quantidadeVezesSeguroroDesempregoSolicitado == 1)
            {
                if (quantidadeMesesTrabalhados < 9)
                {
                    return 0;
                }
                else if (quantidadeVezesSeguroroDesempregoSolicitado >= 9 & quantidadeVezesSeguroroDesempregoSolicitado < 12)
                {
                    return 3;                    
                }
                 else if (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 25)
                {
                    return 4;                    
                }
                else
                {
                    return 5;                   
                }
            }
            else
            {
                if (quantidadeMesesTrabalhados < 6)
                {
                    return 0;
                }
                else if (quantidadeVezesSeguroroDesempregoSolicitado >= 6 & quantidadeVezesSeguroroDesempregoSolicitado < 12)
                {
                    return 3;
                 }
                 else if (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 24)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
