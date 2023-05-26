namespace iRh.Windows.Core
{
    public static class ValeTransporte
    {
        public static double calculaVT(double salario)
        {
            double valorValeTransporte = 0;


            valorValeTransporte = salario * 0.06;

            return valorValeTransporte;

        }
    }
    
}
