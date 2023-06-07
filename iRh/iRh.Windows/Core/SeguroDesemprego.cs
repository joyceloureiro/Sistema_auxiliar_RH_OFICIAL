namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double calculaSeguroDesemprego(double quantidadeMesesTrabalhados, double quantidadeVezesSeguroroDesempregoSolicitado)
        {
            double resultadoSeguroDesemprego =0;
            double quantidadeParcelasSeguro ;

            if (quantidadeVezesSeguroroDesempregoSolicitado == 0)
            {
                if(quantidadeMesesTrabalhados <12)
                {
                    return resultadoSeguroDesemprego = 0;
                }
                else if  (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 25)
                {
                    return quantidadeParcelasSeguro = 4;
                    resultadoSeguroDesemprego = 1;
                }
                else
                {
                    return quantidadeParcelasSeguro = 5;
                    resultadoSeguroDesemprego = 1;
                }
            }
            else if (quantidadeVezesSeguroroDesempregoSolicitado == 1)
            {
                if (quantidadeMesesTrabalhados < 9)
                {
                    return resultadoSeguroDesemprego = 0;
                }
                else if (quantidadeVezesSeguroroDesempregoSolicitado >= 9 & quantidadeVezesSeguroroDesempregoSolicitado < 12)
                {
                    return quantidadeParcelasSeguro = 3;
                    resultadoSeguroDesemprego = 1;
                }
                 else if (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 25)
                {
                    return quantidadeParcelasSeguro = 4;
                    resultadoSeguroDesemprego = 1;
                }
                else
                {
                    return quantidadeParcelasSeguro = 5;
                    resultadoSeguroDesemprego = 1;
                }
            }
            else
            {
                if (quantidadeMesesTrabalhados < 6)
                {
                    return resultadoSeguroDesemprego = 0;
                }
                else if (quantidadeVezesSeguroroDesempregoSolicitado >= 6 & quantidadeVezesSeguroroDesempregoSolicitado < 12)
                {
                    return quantidadeParcelasSeguro = 3;
                    resultadoSeguroDesemprego = 1;
                }
                 else if (quantidadeVezesSeguroroDesempregoSolicitado >= 12 & quantidadeVezesSeguroroDesempregoSolicitado < 24)
                {
                    return quantidadeParcelasSeguro = 4;
                    resultadoSeguroDesemprego = 1;
                }
                else
                {
                    return quantidadeParcelasSeguro = 5;
                    resultadoSeguroDesemprego = 1;
                }
            }
            return resultadoSeguroDesemprego;
        }
    }
}
