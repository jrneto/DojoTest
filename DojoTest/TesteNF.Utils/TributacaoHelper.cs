using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNF.Utils
{
    public static class TributacaoHelper
    {
        public static double CalcularPIS(double valorBase)
        {
            return Math.Round(valorBase * 0.65 / 100, 2);
        }

        public static double CalcularCOFINS(double valorBase)
        {
            return Math.Round(valorBase * 3 / 100, 2);
        }

        public static double CalcularIRPJ(double valorBase)
        {
            return Math.Round(valorBase * 1.5 / 100, 2);
        }

        public static double CalcularCSLL(double valorBase)
        {
            return Math.Round(valorBase * 1 / 100, 2);
        }
    }
}
