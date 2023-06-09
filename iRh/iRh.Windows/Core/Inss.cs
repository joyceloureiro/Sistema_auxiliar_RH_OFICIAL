﻿namespace iRh.Windows.Core
{  //entrou no formulario limpa, remove using
    public static class Inss
    {
        const double Faixa01 = 1302.00;
        const double Faixa02 = 2571.65;
        const double Faixa03 = 3856.94;
        const double Faixa04 = 7507.49;

        //FUNCAO RETORNO
        public static double Calcula(double salario)
        {
            
            double valorInss = 0;

            if(salario <= Faixa01)
            {
                valorInss = Core.Inss.CalculaFaixa0(salario);
            }
            else if(salario <= Faixa02)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                valorInss = 0.09 * (salario - Faixa01) + descontoFaixa1;
            }
            else if (salario <= Faixa03)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                valorInss = 12/100 * (salario - Faixa01) + descontoFaixa1 + descontoFaixa2;
            }
            else if (salario <= Faixa04)
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                var descontoFaixa3 = Core.Inss.CalculaFaixa3(salario);
                valorInss = 0.14 * (salario - Faixa03) + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            else
            {
                var descontoFaixa1 = Core.Inss.CalculaFaixa1(salario);
                var descontoFaixa2 = Core.Inss.CalculaFaixa2(salario);
                var descontoFaixa3 = Core.Inss.CalculaFaixa2(salario);
                valorInss = 0.14 * (Faixa04 - Faixa03) + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }

            return valorInss;
        }

        private static double CalculaFaixa0(double salario)
        {
            return (0.075 * salario);
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * Faixa01);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (Faixa02 - Faixa01);
        }
        private static double CalculaFaixa3(double salario)
        {
            return 0.12 * (Faixa03 - Faixa02);
        }
    }
}
