namespace iRh.Windows.Core

{
    public static class Fgts
    {
        public static double calculaFgts(double salario)
        {
            double valorFgts = 0;


            valorFgts = salario * 0.08;

            return valorFgts;

        }
    }
}
