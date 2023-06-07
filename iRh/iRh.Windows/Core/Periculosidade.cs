namespace iRh.Windows.Core
{
    public static class Periculosidade
    {
        public static double calculaPericulosidade(double salario)
        {
            double valorPericulosidade;

            valorPericulosidade = salario * 0.3;

            return valorPericulosidade;
        }
    }
    
}
